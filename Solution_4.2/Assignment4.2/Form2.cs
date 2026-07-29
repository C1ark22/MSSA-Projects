using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Assignment4._2
{
    public partial class Form2 : Form
    {
        
        private Dictionary<int, Student> studentDictionary = new Dictionary<int, Student>();
        private BindingList<Student> studentsBinding = new BindingList<Student>();
        private BindingSource studentBindingSource = new BindingSource();
        public Form2()
        {
            InitializeComponent();
            studentBindingSource.DataSource = studentsBinding;
            dataGridViewStudents.DataSource = studentBindingSource;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtboxStudentID.Focus();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // invalid if it contains letters
            if (!int.TryParse(txtboxStudentID.Text, out int studentID))
            {
                MessageBox.Show("Student ID must be a whole number");
                return;
            }

            string studentName = txtboxStudentName.Text.Trim();

            if (string.IsNullOrWhiteSpace(studentName))
            {
                MessageBox.Show("Please enter the student's name.");
                return;
            }

            foreach (char character in studentName)
            {
                if (!char.IsLetter(character) && character != ' ')
                {
                    MessageBox.Show("Student name can only contain letters and spaces.");
                    return;
                }
            }

            // GPA must be valid
            if (!double.TryParse(txtboxGPA.Text, out double gpa))
            {
                MessageBox.Show("GPA must be a valid number ");
                return;
            }

            if (gpa < 0.00 || gpa > 4.00)
            {
                MessageBox.Show("GPA must be between 0.00 and 4.00");
                return;
            }

            // Created a student object
            Student newStudent = new Student
            {
                StudentID = studentID,
                StudentName = studentName,
                GPA = gpa
            };

            // Adding student to the dictionary
            studentDictionary.Add(newStudent.StudentID, newStudent);
            studentsBinding.Add(newStudent);

            // Method to save the student with the highest GPA
            SaveHighestGPAStudent();

            txtboxStudentID.Clear();
            txtboxStudentName.Clear();
            txtboxGPA.Clear();

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Student? selectedStudent = studentBindingSource.Current as Student;

            if (selectedStudent == null)
            {
                MessageBox.Show("Please select a student");
                return;
            }

            DialogResult result = MessageBox.Show
                ($"Are you sure you want to delete {selectedStudent.StudentName}?", 
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // removing the student from the dictionary and the table
            if (result == DialogResult.Yes)
            {
                studentDictionary.Remove(selectedStudent.StudentID);

                studentBindingSource.RemoveCurrent();

                SaveHighestGPAStudent();
            }
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void SaveHighestGPAStudent()
        {
            string documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fileName = Path.Combine(documentsFolder, "StudentDetails.txt");

            // If there are no students, clear the file
            if (studentsBinding == null || studentsBinding.Count == 0)
            {
                File.WriteAllText(fileName, string.Empty);
                return;
            }
            // Assuming that the first student has the highest GPA
            Student highest = studentsBinding[0];
            
            // comparing every student's GPA
            foreach (Student student in studentsBinding)
            {
                if (student.GPA > highest.GPA)
                    highest = student;
            }

            // Writing the student info in the txtfile
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine("Student with the highest GPA");
                writer.WriteLine($"Student ID: {highest.StudentID}");
                writer.WriteLine($"Student Name: {highest.StudentName}");
                writer.WriteLine($"Highest GPA: {highest.GPA:F2}");
            }

            Process.Start(new ProcessStartInfo
            {
                FileName = fileName,
                UseShellExecute = true
            });
        }
    }
}
