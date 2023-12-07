﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace FruitBazzar1.Model
{
	public partial class MenuItems
	{
        public int Id { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public string Body { get; set; }
        public Type TargetType { get; set; }
    }
}