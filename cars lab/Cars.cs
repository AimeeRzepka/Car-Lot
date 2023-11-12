using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace cars_lab
{
    public class Cars
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public Cars()
        {

        }

        public Cars(string make, string model, int year, decimal price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;

        }

        public override string ToString()
        {
            string output = $"Make: {Make}, Model:{Model}, Year: {Year}, Price: {Price}";
            return output;
        }

        
      
          
        }





    }







