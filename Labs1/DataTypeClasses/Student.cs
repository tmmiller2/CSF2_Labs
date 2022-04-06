﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeClasses
{
    public class Student
    {
        private string _firstName;
        private string _lastName;
        private string _id;
        private float _gpa;

        public string FirstName
        { 
            get { return _firstName; } 
            set { _firstName = value; } 
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public float Gpa
        {
            get { return _gpa; }

            set
            {
                if (value >= 0)
                {
                    _gpa = value;
                }
                else
                {
                    _gpa = 1;
                }
            }
        }
    }
}