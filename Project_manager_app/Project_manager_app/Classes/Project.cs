﻿using Project_manager_app.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_manager_app
{
    public class Project
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public StatusProject Status { get; set; }

        public Project(string name, string description, DateTime startDate, DateTime endDate, StatusProject status)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            Status = status;
        }
    }
}
