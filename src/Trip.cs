using System;
using System.Collections.Generic;
using System.Text;

namespace src
{
    class Trip
    {
        string duration = "";
        int price = 0;
        int number_of_people = 0;


        public string Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
        public int Number
        {
            get { return this.number_of_people; }
            set { this.number_of_people = value; }
        }
        public int Price 
        {
            get { return this.price; }
            set { this.price = value; }
        }
    }
}
