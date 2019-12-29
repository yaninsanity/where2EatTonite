using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Where2EatTonite
{
    public partial class main : Form
    {
        addRestaurant tmpAddNewRestaurantForm;
        viewRestaurant tmpViewRestaurant;
        help myHelp;
        BindingList<Restaurant> restaurantList;
        int numOfResturant=0;
        public main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            restaurantList = new BindingList<Restaurant>();
        }

        private void RestaurantForm_newResturantCreated(Restaurant r)
        {
            restaurantList.Add(r);

            numOfResturant = restaurantList.Count();

            restaurantNumDisplayLabel.Text = $"Number Of Resturant in the System ----- {numOfResturant}";
            statusLabel.Text = $"New Restaurants Creaded! The System has {numOfResturant} right now.";
            timer.Enabled = true;
        }

        private void addResturantAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instantiate a new add resturant form
            tmpAddNewRestaurantForm = new addRestaurant();
            //create
            tmpAddNewRestaurantForm.ResutrantCreated += new RestaurantEventHandle(this.RestaurantForm_newResturantCreated);
            //show
            tmpAddNewRestaurantForm.Show();

        }

        private void searchARestarurantFToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutMeMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://jlblog.tech/index.php/about-me.html");
        }

        private void readMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myHelp = new help();
            myHelp.Show();
        }

        private void importIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.FileName = "";
                openFileDialog.Filter = "App Data Files (*.dat)|*.dat|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;

                DialogResult dialogResult = openFileDialog.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;

                    FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    BinaryFormatter bf = new BinaryFormatter();
                    restaurantList = (BindingList<Restaurant>)bf.Deserialize(file);
                    numOfResturant = restaurantList.Count();
                    statusLabel.Text = $"{numOfResturant} resturants are loaded. ";
                    restaurantNumDisplayLabel.Text = $"Number Of Resturant in the System ----- {numOfResturant}";
                    timer.Enabled = true;
                }

            }
            catch (Exception)
            {

                statusLabel.Text = "Data loading not successful";
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //check the time
            timer.Enabled = false;
            statusLabel.Text = "Ready;";
        }

        private void saveRestaurantSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "";
            saveFileDialog.Filter = "App Data Files (*.dat)|*.dat|All Files (*.*)|*.*";
            DialogResult dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                try
                {
                    FileStream file = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(file, restaurantList);
                    file.Close();
                    statusLabel.Text = "File saved.";
                    timer.Enabled = true;
                }
                catch (Exception)
                {

                    statusLabel.Text = "Save Not successful";
                    timer.Enabled = true;
                }

            }
        }

        private void exitEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void updateResturantUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmpViewRestaurant = new viewRestaurant(this.restaurantList);
            tmpViewRestaurant.Show();
            tmpViewRestaurant.NewList += new SavingChanges(this.UpdateMyList);
        }

        private void UpdateMyList(BindingList<Restaurant> editedRestaurantList)
        {
            restaurantList = editedRestaurantList;
            restaurantList.ResetBindings();
            numOfResturant = restaurantList.Count();
            restaurantNumDisplayLabel.Text = $"Number Of Restaurants In The System ---- {numOfResturant}";
            statusLabel.Text = $"{numOfResturant} restaurants are just updated";
            timer.Enabled = true;

        }

        private void randomButton_Click(object sender, EventArgs e)
        {

            if (numOfResturant == 0) { MessageBox.Show("There Are No Restaurants In The System", "Error");}

            else

            {
                Random random = new Random();
                int randomNumber = random.Next(0, numOfResturant);
                Restaurant godSelectedRestaurant = restaurantList[randomNumber];

                restaurantInfoLabel.Text = $"{godSelectedRestaurant.ResultString()} \nAddress : {godSelectedRestaurant.Address}";

            }


        

        }
    }
}
