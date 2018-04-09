﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CornerstoneAssessmentMVC.Models
{
    //Person class holds the properties of a person
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string EyeColor { get; set; }
        public List<string> Friends { get; set; }
    }
}