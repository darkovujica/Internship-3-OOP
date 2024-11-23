using Microsoft.SqlServer.Server;
using Project_manager_app.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_manager_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var projectsAndTasks = new Dictionary<Project, List<Task>>();

            var project1 = new Project(
                "E-commerce Website",
                "Develop a fully functional e-commerce platform.",
                new DateTime(2024, 11, 2),
                new DateTime(2024, 11, 30),
                StatusProject.Active);

            projectsAndTasks[project1] = new List<Task>
            {
                new Task
                (
                    "Database Design",
                    "Create a scalable database for storing product and user data.",
                    new DateTime(2024, 11, 30),
                    StatusTask.Active,
                    240,
                    project1
                ),
                new Task
                (
                    "User Authentication Module",
                    "Implement secure login and registration functionality.",
                    new DateTime(2024, 11, 29),
                    StatusTask.Active,
                    180,
                    project1
                ),
                new Task
                (
                    "Payment Integration",
                    "Integrate multiple payment gateways.",
                    new DateTime(2024, 11, 10),
                    StatusTask.Completed,
                    300,
                    project1
                )
            };

            var project2 = new Project
            (
                "Mobile App for Fitness Tracking",
                "Develop a cross-platform mobile app for tracking workouts and health stats.",
                new DateTime(2024, 2, 1),
                new DateTime(2024, 12, 5),
                StatusProject.Active);

            projectsAndTasks[project2] = new List<Task>
            {
                new Task
                (
                    "UI/UX Design",
                    "Create a user-friendly design for the app.",
                    new DateTime(2024, 11, 29),
                    StatusTask.Active,
                    200,
                    project2
                ),
                new Task
                (
                    "Activity Tracking Algorithm",
                    "Develop an algorithm to track various workout activities.",
                    new DateTime(2024, 12, 1),
                    StatusTask.Active,
                    240,
                    project2
                ),
                new Task
                (
                    "Beta Testing",
                    "Conduct beta testing with a selected group of users.",
                    new DateTime(2024, 11, 27),
                    StatusTask.Active,
                    120,
                    project2
                )
            };

            var project3 = new Project(
                "Corporate Training Program",
                "Organize training sessions for employees on new technologies.",
                new DateTime(2024, 3, 1),
                new DateTime(2024, 11, 30),
                StatusProject.OnHold);

            projectsAndTasks[project3] = new List<Task>
            {
                new Task
                (
                    "Material Preparation",
                   "Prepare materials and documentation for the training.",
                    new DateTime(2024, 11, 25),
                    StatusTask.Postponed,
                    150,
                    project3
                ),
                new Task
                (
                    "Schedule Sessions",
                    "Organize training sessions and set schedules.",
                    new DateTime(2024, 11, 26),
                    StatusTask.Completed,
                    100,
                    project3
                )
            };

            var project4 = new Project(
                "AI-Powered Chatbot",
                "Develop an AI chatbot for customer support.",
                new DateTime(2023, 11, 1),
                new DateTime(2024, 12, 28),
                StatusProject.Completed);

            projectsAndTasks[project4] = new List<Task>
            {
                new Task
                (
                    "Natural Language Processing Model",
                    "Train an NLP model for understanding user queries.",
                    new DateTime(2023, 12, 15),
                    StatusTask.Completed,
                    300, 
                    project4
                ),
                new Task
                (
                    "Chatbot Deployment",
                    "Deploy the chatbot on the company website.",
                    new DateTime(2024, 2, 10),
                    StatusTask.Completed,
                    120,
                    project4
                )
            };

            var project5 = new Project(
                "Online Learning Platform",
                "Develop a platform for hosting and managing online courses.",
                new DateTime(2024, 1, 15),
                new DateTime(2024, 6, 30),
                StatusProject.Active);

            projectsAndTasks[project5] = new List<Task>
            {
                new Task(
                    "Course Management System",
                    "Implement a system to manage courses and enrollments.",
                    new DateTime(2024, 2, 20),
                    StatusTask.Completed,
                    240,
                    project5
                ),
                new Task(
                    "Video Hosting Integration",
                    "Integrate with a video hosting service for course content.",
                    new DateTime(2024, 3, 10),
                    StatusTask.Postponed,
                    180,
                    project5
                ),
                new Task(
                    "Feedback and Ratings Module",
                    "Allow users to provide feedback and rate courses.",
                    new DateTime(2024, 4, 25),
                    StatusTask.Active,
                    120,
                    project5
                )
            };

            var project6 = new Project(
                "Data Analytics Dashboard",
                "Build a dashboard for visualizing key business metrics.",
                new DateTime(2023, 11, 1),
                new DateTime(2024, 3, 31),
                StatusProject.Completed);

            projectsAndTasks[project6] = new List<Task>
            {
                new Task(
                    "Data Integration",
                    "Connect various data sources to the dashboard.",
                    new DateTime(2023, 12, 15),
                    StatusTask.Completed,
                    200,
                    project6
                ),
                new Task(
                    "Visualization Design",
                    "Design intuitive and interactive visualizations.",
                    new DateTime(2024, 1, 20),
                    StatusTask.Completed,
                    180,
                    project6
                ),
                new Task(
                    "User Testing",
                    "Conduct testing sessions to gather feedback.",
                    new DateTime(2024, 2, 10),
                    StatusTask.Completed,
                    90,
                    project6
                )
            };

            var project7 = new Project(
                "Customer Loyalty Program",
                "Implement a rewards program to increase customer retention.",
                new DateTime(2024, 2, 1),
                new DateTime(2024, 5, 31),
                StatusProject.OnHold);

            projectsAndTasks[project7] = new List<Task>
            {
                new Task(
                    "Reward Structure Design",
                    "Define rewards and redemption options.",
                    new DateTime(2024, 2, 25),
                    StatusTask.Postponed,
                    150,
                    project7
                ),
                new Task(
                    "Marketing Campaign Planning",
                    "Plan a campaign to announce the loyalty program.",
                    new DateTime(2024, 3, 15),
                    StatusTask.Postponed,
                    120,
                    project7
                ),
                new Task(
                    "Technical Implementation",
                    "Develop the backend to track rewards and points.",
                    new DateTime(2024, 4, 30),
                    StatusTask.Postponed,
                    200,
                    project7
                )
            };

            var project8 = new Project(
                "Inventory Management System",
                "Build a system to manage and track inventory across locations.",
                new DateTime(2023, 10, 1),
                new DateTime(2024, 2, 15),
                StatusProject.Completed);

            projectsAndTasks[project8] = new List<Task>
            {
                new Task(
                    "Database Setup",
                    "Create a database structure for inventory tracking.",
                new DateTime(2023, 11, 1),
                    StatusTask.Completed,
                    240,
                    project8
                ),
                new Task(
                        "Real-Time Tracking",
                    "Implement real-time inventory tracking functionality.",
                    new DateTime(2023, 12, 20),
                    StatusTask.Completed,
                    180,
                    project8
                ),
                new Task(
                    "User Access Controls",
                    "Add role-based access control for different users.",
                    new DateTime(2024, 1, 15),
                    StatusTask.Completed,
                    90,
                    project8
                )
            };

            var project9 = new Project(
                "Event Management Tool",
                "Develop a tool for planning and managing events.",
                new DateTime(2024, 3, 1),
                new DateTime(2024, 9, 1),
                StatusProject.Active);

            projectsAndTasks[project9] = new List<Task>
            {
                new Task(
                    "Event Scheduling Module",
                    "Create a module for scheduling and managing events.",
                    new DateTime(2024, 4, 10),
                    StatusTask.Active,
                    200,
                    project9
                ),
                new Task(
                    "Participant Management",
                    "Add functionality to manage event participants.",
                    new DateTime(2024, 5, 15),
                    StatusTask.Active,
                    180,
                    project9
                ),
                new Task(
                    "Notification System",
                    "Implement email and SMS notifications for event updates.",
                    new DateTime(2024, 6, 25),
                    StatusTask.Postponed,
                    120,
                    project9
                )
            };

            MainMenu(projectsAndTasks);
        }
        static void MainMenu(Dictionary<Project, List<Task>> projectsAndTasks)
        {
            var exitMenu = false;
            do
            {
                Console.Clear();
                Console.Write("1 - View all projects with their tasks\n2 - Add new project\n3 - Delete project\n4 - View all tasks upcoming within seven days\n5 - View projects filtered by their status\n6 - Manage the project\n7 - Manage the task\n8 - Exit the application\n");
                var choosenOption = ChooseOption(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 });

                Console.Clear();
                switch (choosenOption)
                {
                    case 1:
                        ViewAllProjectsWithTasks(projectsAndTasks);
                        Console.ReadKey();
                        break;
                    case 2:
                        AddNewProject(projectsAndTasks);
                        break;
                    case 3:
                        DeleteProject(projectsAndTasks);
                        break;
                    case 4:
                        ViewUpcomingTasksWithinSevenDays(projectsAndTasks);
                        Console.ReadKey();
                        break;
                    case 5:
                        ViewAllProjectsWithChoosenStatus(projectsAndTasks);
                        Console.ReadKey();
                        break;
                    case 6:
                        ManageProject(projectsAndTasks);
                        break;
                    case 7:
                        ManageTask(projectsAndTasks);
                        break;
                    case 8:
                        exitMenu = true;
                        break;
                    default:
                        break;
                }
            } while (!exitMenu);
            Console.Clear();
        }
        static void ViewAllProjectsWithTasks(Dictionary<Project, List<Task>> projectsAndTasks)
        {
            foreach(var project in projectsAndTasks.Keys)
            {
                Console.Write($"\nProject name:\n\t{project.Name}\nTask names:\n");
                PrintNamesOfTasksInsideList(projectsAndTasks[project], "\t");
            }
        }
        static void AddNewProject(Dictionary<Project, List<Task>> projectsAndTasks)
        {
            var name = NewString("Enter project name: ");
            while (ProjectExists(name, projectsAndTasks))
            {
                name = NewString("There is already project with that name. Enter new project name: ");
            }
            var description = NewString("Enter description: ");
            var startDate = NewFutureDate("project start");
            var endDate = NewFutureDate("project end");
            while (startDate > endDate)
            {
                Console.Write($"Project cannot end before it starts. Start date is {startDate}\n");
                endDate = NewFutureDate("project end");
            }
            var status = StatusOfNewProject();
            var project = new Project(name, description, startDate, endDate, status);

            projectsAndTasks[project] = new List<Task>();
            Console.Clear();

            if (ChooseOptionText("Do you want to add tasks? "))
                AddNewTasks(project, projectsAndTasks);
        }
        static void DeleteProject(Dictionary<Project, List<Task>> projectsAndTasks)
        {
            PrintNamesOfAllProjects(projectsAndTasks);
            do
            {
                var project = ChooseProject(projectsAndTasks);
                Console.Clear();

                PrintProject(project);

                if (ChooseOptionText("Are you sure you want to delete this project? "))
                {
                    Console.Clear();
                    projectsAndTasks.Remove(project);
                    Console.WriteLine("Project is deleted.\n");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Project is not deleted.\n");
                }

                PrintNamesOfAllProjects(projectsAndTasks);

            } while (ChooseOptionText("\nDo you want to delete another project? "));
        }
        static void ViewUpcomingTasksWithinSevenDays(Dictionary<Project, List<Task>> projectsAndTasks)
        {
            foreach(var project in projectsAndTasks.Keys)
            {
                foreach(Task task in projectsAndTasks[project])
                {
                    if(DateTime.Today <= task.Deadline && task.Deadline <= DateTime.Today.AddDays(7))
                        PrintTask(task);
                }
            }
        }
        static void ViewAllProjectsWithChoosenStatus(Dictionary<Project, List<Task>> projectsAndTasks)
        {
            var atLeastOneProjectExists = false;
            var status = NewStatusProject();
            Console.Clear();

            foreach (var project in projectsAndTasks.Keys)
            {
                if (project.Status == status)
                {
                    PrintProject(project);
                    atLeastOneProjectExists = true;
                }
            }
            if (!atLeastOneProjectExists)
                Console.WriteLine($"There are no projects with status {status}\n");
        }
        static void ManageProject(Dictionary<Project, List<Task>> projectsAndTasks)
        {
            var changeProject = false;
            do
            {
                Console.Clear();
                changeProject = false;
                var exitMenu = false;

                var project = ChooseProject(projectsAndTasks);
                do
                {
                    Console.Clear();
                    Console.Write("1 - View all tasks inside the project\n2 - View details of the project\n3 - Edit status of the project\n4 - Add task to the project\n5 - Delete task from the project\n6 - Expected duration of all active tasks in the project\n7 - Choose another project\n8 - Exit the submenu\n");

                    switch (ChooseOption(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }))
                    {
                        case 1:
                            PrintNamesOfTasksInsideList(projectsAndTasks[project]);
                            Console.ReadKey();
                            break;
                        case 2:
                            PrintProject(project);
                            Console.ReadKey();
                            break;
                        case 3:
                            EditStatusOfProject(project, projectsAndTasks);
                            Console.ReadKey();
                            break;
                        case 4:
                            projectsAndTasks[project].Add(AddNewTask(project, projectsAndTasks));
                            break;
                        case 5:
                            DeleteTask(project, projectsAndTasks);
                            break;
                        case 6:
                            ExpectedDurationForAllActivTasksInProject(project, projectsAndTasks);
                            Console.ReadKey();
                            break;
                        case 7:
                            changeProject = true;
                            exitMenu = true;
                            break;
                        case 8:
                            exitMenu = true;
                            break;
                        default:
                            break;
                    }
                } while (!exitMenu);
            } while (changeProject);
        }
        static void EditStatusOfProject(Project project, Dictionary<Project, List<Task>> projectsAndTasks)
        {
            if (project.Status == StatusProject.Completed)
                Console.WriteLine("Status of completed project cannot be changed.");
            else
            {
                project.Status = NewStatusProject();
                Console.WriteLine("Status of project changed.");

                if (project.Status == StatusProject.Completed)
                    CompleteTasksInProject(project, projectsAndTasks);
            }
        }
        static void CompleteTasksInProject(Project project, Dictionary<Project, List<Task>> projectsAndTasks)
        {
            foreach (var task in projectsAndTasks[project])
                task.Status = StatusTask.Completed;
        }

        static void AddNewTasks(Project project, Dictionary<Project, List<Task>> projectsAndTasks)
        {
            do
            {
                Console.Clear();
                projectsAndTasks[project].Add(AddNewTask(project, projectsAndTasks));
            } while (ChooseOptionText("\nTask is added.\nDo you want to add new task to the project? "));
        }
        static Task AddNewTask(Project project, Dictionary<Project, List<Task>> projectsAndTasks)
        {
            var name = NewString("Enter task name: ");
            while (TaskExists(name, project, projectsAndTasks))
            {
                name = NewString("There is already task with that name in this project. Enter new task name: ");
            }
            var description = NewString("Enter description: ");
            var deadline = NewFutureDate("task start");
            var status = NewStatusTask();
            var expectedDuration = NewNumber("Expected duration of project in minutes: ");

            return new Task(name, description, deadline, status, expectedDuration, project);
        }
        static void DeleteTask(Project project, Dictionary<Project, List<Task>> projectsAndTasks)
        {
            var name = NewString("Enter task name: ");
            while (!TaskExists(name, project, projectsAndTasks))
            {
                name = NewString("There is no task with that name in this project. Enter task name: ");
            }
            var task = FindTask(name, projectsAndTasks[project]);
            PrintTask(task);

            if (ChooseOptionText("Are you sure you want to delete this task? "))
            {
                projectsAndTasks[project].Remove(task);
                Console.WriteLine("Task is deleted.");
            }
            else
                Console.WriteLine("Task is not deleted.");
        }
        static void ExpectedDurationForAllActivTasksInProject(Project project, Dictionary<Project, List<Task>> projectsAndTasks)
        {
            var expectedDuration = 0;
            foreach(var task in projectsAndTasks[project])
            {
                if (task.Status == StatusTask.Active)
                    expectedDuration += task.ExpectedDuration;
            }
            Console.WriteLine($"Expected duration for all active tasks is {expectedDuration} minutes.\n");
        }

        static void ManageTask(Dictionary<Project, List<Task>> projectsAndTasks)
        {
            var changeTask = false;
            do
            {
                Console.Clear();
                changeTask = false;
                var exitMenu = false;

                var task = ChooseTask(projectsAndTasks);
                do
                {
                    Console.Clear();
                    Console.Write("1 - View details of task\n2 - Edit status of task\n3 - Choose new task\n4 - Exit submenu\n");

                    switch (ChooseOption(new List<int>() { 1, 2, 3, 4 }))
                    {
                        case 1:
                            PrintTask(task);
                            Console.ReadKey();
                            break;
                        case 2:
                            EditStatusOfTask(task, projectsAndTasks);
                            Console.ReadKey();
                            break;
                        case 3:
                            changeTask = true;
                            exitMenu = true;
                            break;
                        case 4:
                            exitMenu = true;
                            break;
                        default:
                            break;
                    }
                } while (!exitMenu);
            } while (changeTask);
        }
        static void EditStatusOfTask(Task task, Dictionary<Project, List<Task>> projectsAndTasks)
        {
            if (task.Status == StatusTask.Completed)
                Console.WriteLine("\nStatus of completed task cannot be changed. ");
            else
            {
                var status = NewStatusTask();
                task.Status = status;
                Console.WriteLine("\nStatus of task changed.");

                if (status == StatusTask.Completed)
                    IsProjectCompleted(task.Project, projectsAndTasks);
            }
        }


        static void IsProjectCompleted(Project project, Dictionary<Project, List<Task>> projectsAndTasks)
        {
            var projectIsCompleted = true;
            foreach (var task in projectsAndTasks[project])
            {
                if (task.Status != StatusTask.Completed)
                    projectIsCompleted = false;
            }
            if (projectIsCompleted)
            {
                project.Status = StatusProject.Completed;
                Console.WriteLine($"Status of project {project.Name} is now completed.");
            }
        }

        static bool ProjectExists(string name, Dictionary<Project, List<Task>> projectsAndTasks)
        {
            foreach (var project in projectsAndTasks.Keys)
            {
                if (project.Name.ToUpper() == name.ToUpper()) return true;
            }
            return false;
        }
        static Project FindProject(string name, Dictionary<Project, List<Task>> projectsAndTasks)
        {
            foreach (var project in projectsAndTasks.Keys)
            {
                if (project.Name.ToUpper() == name.ToUpper())
                    return project;
            }
            return null;
        }
        static Project ChooseProject(Dictionary<Project, List<Task>> projectsAndTasks)
        {
            var name = NewString("\nEnter project name: ");
            while (!ProjectExists(name, projectsAndTasks))
            {
                name = NewString("There is no project with that name. Enter new project name: ");
            }

            return FindProject(name, projectsAndTasks);
        }
        static bool TaskExists(string name, Project project, Dictionary<Project, List<Task>> projectsAndTasks)
        {
            foreach (var task in projectsAndTasks[project])
            {
                if (task.Name.ToUpper() == name.ToUpper()) return true;
            }
            return false;
        }
        static Task FindTask(string name, List<Task> listOfTaskstasks)
        {
            foreach (var task in listOfTaskstasks)
            {
                if (task.Name.ToUpper() == name.ToUpper())
                    return task;
            }
            return null;
        }
        static Task ChooseTask(Dictionary<Project, List<Task>> projectsAndTasks)
        {
            do
            {
                if (!ChooseOptionText("\nDo you know the name of the task you want? "))
                {
                    Console.Clear();
                    foreach (var project in projectsAndTasks.Keys)
                        PrintNamesOfTasksInsideList(projectsAndTasks[project]);
                }
                var taskName = NewString("\nEnter task name: ");

                if (ChooseOptionText("\nDo you know the name of the project of your task? "))
                {
                    Console.Clear();
                    var project = ChooseProject(projectsAndTasks);
                    var task = FindTask(taskName, projectsAndTasks[project]);
                    if (task != null)
                        return task;
                    else
                        Console.WriteLine($"\nThere is no task with name {taskName} in that project.");
                }
                Console.Clear();
                foreach (var project in projectsAndTasks.Keys)
                {
                    foreach (var task in projectsAndTasks[project])
                    {
                        if (task.Name == taskName)
                        {
                            PrintTask(task);
                            if (ChooseOptionText("\nDo you want this task? "))
                                return task;
                        }
                    }
                }
            } while (true);
        }


        static StatusProject StatusOfNewProject()
        {
            if (ChooseBetweenTwoOptions("Project status:\n1 - Active\n2 - On hold\n"))
                return StatusProject.Active;
            else
                return StatusProject.OnHold;
        }
        static StatusProject NewStatusProject()
        {
            Console.Write("Project status:\n1 - Active\n2 - On hold\n3 - Completed\n");
            switch (ChooseOption(new List<int>() { 1,2,3}))
            {
                case 1:
                    return StatusProject.Active;
                case 2:
                    return StatusProject.OnHold;
                default:
                    return StatusProject.Completed;
            }
        }
        static StatusTask NewStatusTask()
        {
            Console.Write("\nTask status:\n1 - Active\n2 - Postponed\n3 - Completed\n");

            var choosedOption = ChooseOption(new List<int>() { 1, 2, 3 });
            if (choosedOption == 1)
                return StatusTask.Active;
            else if (choosedOption == 2)
                return StatusTask.Postponed;
            else
                return StatusTask.Completed;
        }



        static void PrintProject(Project project)
        {
            Console.Write($"Project name: {project.Name}\nDescription: {project.Description}\nStart date: {project.StartDate}\nEnd date: {project.EndDate}\nStatus: {project.Status}\n\n");
        }
        static void PrintNamesOfAllProjects(Dictionary<Project, List<Task>> projectsAndTasks)
        {
            Console.WriteLine("Project names:");

            foreach (var project in projectsAndTasks.Keys)
                Console.WriteLine("\t" + project.Name);
        }
        static void PrintNamesOfTasksInsideList(List<Task> listOfTasks, string sign = "")
        {
            foreach (var task in listOfTasks)
                Console.WriteLine(sign + task.Name);
        }
        static void PrintTask(Task task)
        {
            Console.Write($"Task name: {task.Name}\nDescription: {task.Description}\nDeadline: {task.Deadline}\nStatus: {task.Status}\nExpected duration: {task.ExpectedDuration}\nProject name: {task.Project.Name}\n\n");
        }



        static string NewString(string message)
        {
            var tryInt = 0;
            var tryDate = new DateTime();

            Console.Write(message);
            var myString = Console.ReadLine();

            while (int.TryParse(myString, out tryInt) || DateTime.TryParse(myString, out tryDate) || myString=="")
            {
                Console.Write("Not allowed to enter number/date or nothing. " + message);
                myString = Console.ReadLine();
            }
            return myString;
        }
        static int NewNumber(string message, int upperLimit = int.MaxValue)
        {
            var myOption = 0;
            do
            {
                Console.Write(message);
                if (!int.TryParse(Console.ReadLine(), out myOption))
                    Console.Write("You didn't enter number/integer. ");

                else if (myOption <= 0)
                    Console.Write($"Please enter positive number. ");

                else if (upperLimit != int.MaxValue && myOption > upperLimit)
                    Console.Write($"Please enter number lower than {upperLimit}. ");

            } while (myOption <= 0 || myOption > upperLimit);

            return myOption;
        }
        static int NewNumberWithLowerLimit(string message, int lowerLimit = 0, int upperLimit = int.MaxValue)
        {
            var myOption = 0;
            do
            {
                Console.Write(message);
                if (!int.TryParse(Console.ReadLine(), out myOption))
                    Console.Write("You didn't enter number/integer. ");

                else if (myOption < lowerLimit)
                    Console.Write($"Please enter number higher than {lowerLimit}. ");

                else if (upperLimit != int.MaxValue && myOption > upperLimit)
                    Console.Write($"Please enter number lower than {upperLimit}. ");

            } while (myOption < lowerLimit || myOption > upperLimit || myOption == 0);

            return myOption;
        }
        static DateTime NewFutureDate(string message)
        {
            var date = new DateTime();
            var dateIsNotValid = true;
            do
            {
                var year = NewNumberWithLowerLimit($"Enter the year of {message}: ", DateTime.Now.Year);
                var month = NewNumber($"Enter the month of {message}: ", 12);
                var day = NewNumber($"Enter the day of {message}: ", 31);

                var dateString = year.ToString() + "-" + month.ToString() + "-" + day.ToString();

                if (!DateTime.TryParse(dateString, out date))
                    Console.Write("Choosen date doesn't exist. ");
                else if (date < DateTime.Now)
                    Console.Write("You cannot create projects with an old date. ");
                else
                    dateIsNotValid = false;

            } while (dateIsNotValid);

            return date; 
        }
        static int ChooseOption(List<int> options)
        {
            do
            {
                var myOption = NewNumber("Choose number: ");
                foreach (var item in options)
                {
                    if (item == myOption)
                        return myOption;
                }
                Console.Write("Choosen number is not an option. ");
            } while (true);
        }
        static bool ChooseBetweenTwoOptions(string message)
        {
            Console.Write(message);
            if (ChooseOption(new List<int>() { 1, 2 }) == 1)
                return true;
            else
                return false;
        }
        static bool ChooseOptionText(string message = "")
        {
            do
            {
                var myOption = NewString(message + "Write y or n: ");
                if (myOption == "y") return true;
                else if (myOption == "n") return false;
                else
                {
                    Console.Write("Choosen input wasn't correct. ");
                }
            } while (true);
        }
    }
}
