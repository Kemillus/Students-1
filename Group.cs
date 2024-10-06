﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    internal class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Group(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public override string ToString() 
        {
            return Name;
        }
        
    }
}
