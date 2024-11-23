using Project_manager_app.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_manager_app
{
    public class Task
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public StatusTask Status { get; set; }
        public int ExpectedDuration { get; set; }
        public Priority Priority { get; set; }
        public Project Project { get; set; }

        public Task(string name, string description, DateTime deadline, StatusTask status, int expected_duration, Priority priority, Project project)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            Deadline = deadline;
            Status = status;
            ExpectedDuration = expected_duration;
            Priority = priority;
            Project = project;
        }
    }
}
