using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_manager_app
{
    public class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public int ExpectedDuration { get; set; }
        public Project Project { get; set; }

        public Task(string name, string description, DateTime deadline, int expected_duration, Project project)
        {
            this.Name = name;
            this.Description = description;
            this.Deadline = deadline;
            this.ExpectedDuration = expected_duration;
            this.Project = project;
        }
    }
}
