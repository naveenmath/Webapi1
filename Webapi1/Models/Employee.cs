﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webapi1.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime JoiningDate { get; set; }
        public int Age { get; set; }
        public string blood_group { get; set; }

    }
}