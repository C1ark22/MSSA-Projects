using System;
using System.ComponentModel;
using Solution_3_3.Models;

namespace Solution_3_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BindingList<Student> students = new BindingList<Student>();
            students.Add(new Student(1, "John", "Doe", "123 Main St", "January", 'A'));
            students.Add(new Student(2, "Jane", "Smith", "456 Elm St", "February", 'B'));

            dataGridView1.DataSource = students;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
