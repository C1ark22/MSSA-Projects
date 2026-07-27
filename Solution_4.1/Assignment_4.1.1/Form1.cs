using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Assignment_4._1._1.Models;
using System.Linq;

namespace Assignment_4._1._1
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Person> personDictionary =
            new Dictionary<string, Person>(StringComparer.OrdinalIgnoreCase);
        private BindingList<Person> personBinding = new BindingList<Person>();
        private BindingSource personBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            personBindingSource.DataSource = personBinding;
            dataGridView1.DataSource = personBindingSource;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string firstName = txtboxFirstName.Text;
            string lastName = txtboxLastName.Text;
            string mobileNumber = txtboxMobileNumber.Text;
            string workPhoneNumber = txtboxWorkNumber.Text;
            string address = txtboxAddress.Text;

            string fullName = $"{firstName} {lastName}".Trim();

            Person newPerson = new Person
            {
                FirstName = firstName,
                LastName = lastName,
                MobileNumber = mobileNumber,
                WorkPhoneNumber = workPhoneNumber,
                Address = address
            };

            personDictionary.Add(newPerson.FullName, newPerson);
            personBinding.Add(newPerson);

            txtboxFirstName.Clear();
            txtboxLastName.Clear();
            txtboxMobileNumber.Clear();
            txtboxWorkNumber.Clear();
            txtboxAddress.Clear();

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Person selectedPerson = personBindingSource.Current as Person;

            if (selectedPerson == null)
            {
                MessageBox.Show("Please select a person to delete.");
            }

            DialogResult result =
                MessageBox.Show($"Are you sure you want to delete {selectedPerson.FullName}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                personDictionary.Remove(selectedPerson.FullName);

                personBinding.Remove(selectedPerson);

                personBindingSource.RemoveCurrent();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtboxSearch.Text.Trim();

            if (personDictionary.ContainsKey(searchName))
            {
                BindingList<Person> searchResults = new BindingList<Person>();
                searchResults.Add(personDictionary[searchName]);
                personBindingSource.DataSource = searchResults;
            }
            else
            {
                MessageBox.Show($"No person found with the name '{searchName}'.");

            }
            txtboxSearch.Clear();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            BindingList<Person> allPersons = new BindingList<Person>(new List<Person>(personDictionary.Values));
            personBindingSource.DataSource = allPersons;
        }
    }
}
