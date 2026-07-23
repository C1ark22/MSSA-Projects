using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment_3._4._1.Modules;

namespace Assignment_3._4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Coffee> coffees = new List<Coffee>();
            coffees.Add(new Coffee("Espresso", "Small", "Medium", false));
            coffees.Add(new Coffee("Latte", "Medium", "Dark", false));
            coffees.Add(new Coffee("Cappuccino", "Large", "Light", true));

            var list = new BindingList<Coffee>(coffees);
            dataGridView1.DataSource = list;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}