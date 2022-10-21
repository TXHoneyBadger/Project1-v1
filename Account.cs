using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject_v2
{
    class Account
    {
        private string _name { get; set; }
        private string _breed { get; set; }
        private string _gender { get; set; }
        private int _age { get; set; }
        private double _weight { get; set; }
        private string _fixed { get; set; }

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public string Breed
        {
            get { return this._breed; }
            set { this._breed = value; }
        }
        public string Gender
        {
            
            get { return this._gender; }
            set { this._gender = value;}
            
        }
        
    }


}







