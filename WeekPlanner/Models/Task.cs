﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeekPlanner.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Finished { get; set; }
    }
}