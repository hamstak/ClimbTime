﻿using System;

namespace WebApplication3
{
    public class Student
    {
        public int ID { get; set; }
        public Boolean Selected { get; set; }
        public string Name { get; set; }

        public Student(int ID, string Name) {
            this.ID = ID;
            this.Name = Name;
            this.Selected = true;
        }
    }
}
