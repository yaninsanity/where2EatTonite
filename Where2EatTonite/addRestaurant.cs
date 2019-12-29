using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Where2EatTonite
{
    public delegate void RestaurantEventHandle(Restaurant r);
    public partial class addRestaurant : Form
    {
        public event RestaurantEventHandle ResutrantCreated;
        Restaurant tmpRestaurant;

        public addRestaurant()
        {
            InitializeComponent();
            //initialize combobox

            restaurantTypeComboBox.Items.Insert(0, "------Select------");
            restaurantTypeComboBox.SelectedIndex = 0;
            //set focus
            restaurantNameTextBox.Focus();

        }

        private void addRestaurant_Load(object sender, EventArgs e)
        {

        }

        private void preferenceLabel_Click(object sender, EventArgs e)
        {

        }

        private bool filledCheck()
        {   //init bool var filled
            bool filled = true;
            //check every info is filled
            foreach (Control c in this.Controls)
            {
                if (c is TextBox && c.Text == "")
                {
                    filled = false;

                }

                if (c is ComboBox && c.Text == "------Select------")
                {
                    filled = false;
                   
                }

            }
            if (preference1RadioButton.Checked == false && preference2RadioButton.Checked == false && preference3RadioButton.Checked == false && preference4RadioButton.Checked == false && preference5RadioButton.Checked == false)
            {
                filled = false;
                            }
            if (filled == false)
            {
                MessageBox.Show("Information Incompleted, Please Fill Every Information", "Error");

            }
            
            return filled;
        }
        private void cleanUpEverything()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox) { ((TextBox)c).Text = ""; }
                if (c is RadioButton) { ((RadioButton)c).Checked = false; }
                if (c is ComboBox) { ((ComboBox)c).Text = "------Select------"; }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //instantiate new restaurant
            tmpRestaurant = new Restaurant();
            tmpRestaurant.Name = restaurantNameTextBox.Text;
            tmpRestaurant.Address = restaurantAddressTextBox.Text;
            //default preference is 5
            int tmpPreference = 0;
            tmpRestaurant.Type = restaurantTypeComboBox.Text;


            
            string choiceValue = "";
            //get the preference from the the radio button check
            if (preference1RadioButton.Checked)
            {
                choiceValue = preference1RadioButton.Text;
            }
            if (preference2RadioButton.Checked)
            {
                choiceValue = preference2RadioButton.Text;
            }
            if (preference3RadioButton.Checked)
            {
                choiceValue = preference3RadioButton.Text;
            }
            if (preference4RadioButton.Checked)
            {
                choiceValue = preference4RadioButton.Text;
            }
            if (preference5RadioButton.Checked)
            {
                choiceValue = preference5RadioButton.Text;
            }

            Int32.TryParse(choiceValue, out tmpPreference);

            tmpRestaurant.Preference = tmpPreference;




            bool allset=filledCheck();
            if (ResutrantCreated != null && allset == true)
            {
                ResutrantCreated(tmpRestaurant);
                cleanUpEverything();
                
                MessageBox.Show("A Resturant Has Been Successfully Added!", "System");
            }
         
            


        }

    }
            



 }