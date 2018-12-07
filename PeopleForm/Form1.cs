using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleForm
{
    public partial class Form1 : Form
    {
        List<Customer> people = new List<Customer>();

        public Form1()
        {
            InitializeComponent();

            searchListBox.DataSource = people;
            searchListBox.DisplayMember = "FullInfo";
        }


        public void UpdateBinding() {
            searchListBox.DataSource = people;
            searchListBox.DisplayMember = "FullInfo";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            people = db.GetCustomers(FirstNameTextBox.Text);
            searchListBox.Refresh();
            UpdateBinding();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.InsertPerson(firstNameInsText.Text, lastNameInsText.Text, emailInsText.Text,
                phoneInsText.Text, cityInsText.Text, stateInsText.Text, zipInsText.Text);
            
            //Clear the text
            firstNameInsText.Text = "";
            lastNameInsText.Text = "";
            emailInsText.Text = "";
            phoneInsText.Text = "";
            cityInsText.Text = "";
            stateInsText.Text = "";
            zipInsText.Text = "";
        }
    }
}
