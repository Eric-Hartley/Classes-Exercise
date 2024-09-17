using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Classes
{
    internal class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public Car(string Make, string Model, int Year) 
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
        }

        public void DisplayProperties(string Make, string Model, int Year)
        {
            Console.WriteLine($"{Make}, {Model}, {Year}");
        }
    } 
} 
