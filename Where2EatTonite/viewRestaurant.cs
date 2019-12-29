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
    public delegate void SavingChanges(BindingList<Restaurant> NewList);
    public partial class viewRestaurant : Form
    {
        BindingList<Restaurant> restaurantList;
        BindingList<Restaurant> searchRestaurantList;
        editForm myEditForm;
        public event SavingChanges NewList;
        int currentListBoxIndex;
        int editIndex = 0;
        string tmpLongString;


        public viewRestaurant()
        {
            InitializeComponent();
        }

        public viewRestaurant(BindingList<Restaurant> myList)
        {
            InitializeComponent();
            restaurantList = myList;

        }

        private void viewRestaurant_Load(object sender, EventArgs e)
        {
            restaurantListBox.DataSource = restaurantList;

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
           

            if (restaurantListBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select The Restaurant.", "System Error");
            }
            else
            {
                Restaurant tmpRestaurant = (Restaurant)restaurantListBox.SelectedItem;

                if (restaurantListBox.DataSource == searchRestaurantList)
                {
                    searchRestaurantList.Remove(tmpRestaurant);
                }
                restaurantList.Remove(tmpRestaurant);
            }
        }

        private void RestaurantUpdate(Restaurant r)
        {
            if (restaurantListBox.DataSource == searchRestaurantList)
            {
                searchRestaurantList[currentListBoxIndex] = r;
                searchRestaurantList.ResetBindings();
                restaurantListBox.Refresh();

            }

            restaurantList[editIndex] = r;
            restaurantList.ResetBindings();
            restaurantListBox.Refresh();


        }
        private void editButton_Click(object sender, EventArgs e)
        {
            if (restaurantListBox.SelectedItem == null)
            { MessageBox.Show("Please Select The Restaurant!", "Error"); }
            else
            {
                Restaurant tmpResaurant = (Restaurant)restaurantListBox.SelectedItem;
                myEditForm = new editForm(tmpResaurant);
                myEditForm.Show();
                editIndex = restaurantList.IndexOf(tmpResaurant);
                currentListBoxIndex = restaurantListBox.SelectedIndex;
                myEditForm.UpdateRestaurant += new RestaurantEventHandle(this.RestaurantUpdate);
            }
        }

        

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (NewList != null)
            {
                NewList(restaurantList);
            }
            this.Close();

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchRestaurantList = new BindingList<Restaurant>();
            if (restaurantSearchTextbox.Text == null)
            {
                MessageBox.Show("Please Type Searching Keyword Into Textbox", "Error");

            }
            else
            {
                string keyword = restaurantSearchTextbox.Text;

                foreach (Restaurant r in restaurantList)
                {
                    tmpLongString = r.Address + " " + r.Description + " " + r.Name + " " + r.Type;
                    tmpLongString = tmpLongString.ToUpper();
                    if (tmpLongString.Contains(keyword.ToUpper()))
                    {
                        searchRestaurantList.Add(r);
                    }
                }

            }

            if (searchRestaurantList.Count == 0)
            {
                MessageBox.Show("Keyword Was Not Found In The Database", "Error");

            }
            else

            {
                restaurantListBox.DataSource = searchRestaurantList;
            }

        }

        private void refreshListButton_Click(object sender, EventArgs e)
        {
            restaurantListBox.DataSource = restaurantList;
        }
    }
}
