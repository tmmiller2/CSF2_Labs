using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeClasses
{
    public class Vehicle
    {
        private string _make;
        private string _model;
        private int _year;
        private float _weight;

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public float Weight
        {
            get { return _weight; }

            set
            {
                if (value >= 0)
                {
                    _weight = value;
                }
                else
                {
                    _weight = 1;
                }
            }
        }
    }
}