using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cars_lab
{
    public class UsedCars : Cars
    { 
            public double Miles { get; set; }


            public UsedCars(string make, string model, int year, decimal price, double miles) : base(make, model, year, price)
            {
                this.Miles = miles;

            }

        public UsedCars()
        {

        }

        
        public override string ToString()
            {
            return base.ToString() + $" Miles: {Miles}";

            }
        }
    }
