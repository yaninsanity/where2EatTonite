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
    public partial class editForm : Form
    {
        Restaurant tmpRestaurant;
        public event RestaurantEventHandle UpdateRestaurant;
        public editForm()
        {
            InitializeComponent();
        }

        public editForm(Restaurant r)
        {
           
            this.tmpRestaurant = r;
            InitializeComponent();
            restaurantNameTextBox.Text = r.Name;
            restaurantAddressTextBox.Text = r.Address;
            restaurantTypeComboBox.Text = r.Type;
            int tmpRate = r.Preference;

            switch (tmpRate)
            {
                case 1:
                    {
                        preference1RadioButton.Checked = true;  
                        break;
                    }

                case 2:
                    {
                        preference2RadioButton.Checked = true;
                        break;
                    }

                case 3:
                    {
                        preference3RadioButton.Checked = true;
                        break;
                    }

                case 4:
                    {
                        preference4RadioButton.Checked = true;
                        break;
                    }

                case 5:
                    {
                        preference5RadioButton.Checked = true;
                        break;
                    }



            }


            
        

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

            private void updateButton_Click(object sender, EventArgs e)
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




            bool allset = filledCheck();
            if (UpdateRestaurant != null && allset == true)
            {
                UpdateRestaurant(tmpRestaurant);
                MessageBox.Show("A Resturant Has Been Successfully Updateded!", "System");
                this.Close();
            }

        }



      
    }
}
