using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Where2EatTonite
{
    [Serializable]
    public class Restaurant
    {
        private string name;
        private string description;
        private string address;
        private string type;
        private int preference;

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Address { get => address; set => address = value; }
        public string Type { get => type; set => type = value; }
        public int Preference { get => preference; set => preference = value; }
        


        public Restaurant(string name,string address, string type, int preference)
        {
            this.name = name;
            this.address = address;
            this.type = type;
            this.preference = preference;

        }
        public Restaurant(string name, string description, string address, string type, int preference)
        {
            this.name = name;
            this.description = description;
            this.address = address;
            this.type = type;
            this.preference = preference;
   
        }

        public Restaurant()
        {

        }

        private string stars(int starNum)
        {
            string starString = "";
            for (int i=0; i < starNum; i++)
            {
                starString += " ★ ";
            }
            for (int i = 0; i < (5-starNum); i++)
            {
                starString += " ☆ ";
            }

            return starString;
        }

        public override string ToString()
        {
            string returnValue = type + "-------" + name +"    "+stars(preference);
            return returnValue;
        }

        public string ResultString()
        {
            string resultValue = type + " : " + name + "    " + stars(preference);
            return resultValue;
            
        }


    }
}
