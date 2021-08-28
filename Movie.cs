using System;
using System.Collections.Generic;
using System.Text;

namespace Kinoteka
{
    public class Movie
    {
        
        public decimal durration { get; set; }
        public decimal rating { get; set; }
        public string name { get; set; }

        public Movie() { }
        public Movie(string name, decimal durration, decimal rating) {

            this.name = name;
            this.durration = durration;
            this.rating = rating;
        
        
        }
        public override string ToString()
        {
            return string.Format("{0} lasts for {1} minutes, {2}/10 rating",name, durration,rating);
        }

    }
}
