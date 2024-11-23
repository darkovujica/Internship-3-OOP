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
                        exitMenu = false;
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
                PrintProject(project);
                PrintAllTasksInsideList(projectsAndTasks[project]);
                if (!ChooseOptionText("Do you want the next project to be displayed? ")) break;
            }
        }
        static void AddNewProject(Dictionary<Project, List<Task>> projectsAndTasks)
        {
            var name = NewString("Enter project name: ");
            while(ProjectExists(name, projectsAndTasks))
            {
                name = NewString("There is already project with that name. Enter new project name: ");
            }
            var description = NewString("Enter description: ");
            var startDate = NewFutureDate("project start");
            var endDate = NewFutureDate("project end");
            while(startDate > endDate)
            {
                Console.Write($"Project cannot end before it starts. Start date is {startDate}\n");
                endDate = NewFutureDate("project end");
            }
            var status = StatusOfNewProject();

            var project = new Project(name,description,startDate,endDate,status);
            if (ChooseOptionText("Do you want to add tasks? "))
                projectsAndTasks[project] = AddNewTasks(project, projectsAndTasks);
            else
                projectsAndTasks[project] = new List<Task>();
        }
        static void DeleteProject(Dictionary<Project, List<Task>> projectsAndTasks)
        {
            foreach (var project_ in projectsAndTasks.Keys)
                Console.WriteLine(project_.Name);
            do
            {
                var project = ChooseProject(projectsAndTasks);
                Console.Clear();

                PrintProject(project);

                if (ChooseOptionText("Are you sure you want to delete this project? "))
                {
                    Console.Clear();
                    projectsAndTasks.Remove(project);
                    Console.WriteLine("Project is deleted.\n\n");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Project is not deleted.\n\n");
                }

                foreach (var project_ in projectsAndTasks.Keys)
                    Console.WriteLine(project_.Name);

            } while (ChooseOptionText("Do you want to delete another project? "));
        }
        static void ViewUpcomingTasksWithinSevenDays(Dictionary<Project, List<Task>> projectsAndTasks)
        {
            foreach(var project in projectsAndTasks.Keys)
            {
                foreach(Task task in projectsAndTasks[project])
                {
                    if(DateTime.Today <= task.Deadline && task.Deadline <= DateTime.Today.AddDays(7))
                        PrintTaskWithProjectName(task);
                }
            }
        }
        static void ViewAllProjectsWithChoosenStatus(Dictionary<Project, List<Task>> projectsAndTasks)
        {
            var status = NewStatusProject();
            foreach (var project in projectsAndTasks.Keys)
            {
                if (project.Status == status)
                    PrintProject(project);
            }
        }
        static void ManageProject(Dictionary<Project, List<Task>> projectsAndTasks)
        {
            var project = ChooseProject(projectsAndTasks);

            var exitMenu = false;
            do
            {
                Console.Clear();
                Console.Write("1 - View all tasks inside the project\n2 - View details of the project\n3 - Edit status of the project\n4 - Add task to the project\n5 - Delete task from the project\n6 - Expected duration of all active tasks in the project\n7 - Exit the submenu\n");

                switch (ChooseOption(new List<int>() { 1, 2, 3, 4, 5, 6, 7 }))
                {
                    case 1:
                        PrintAllTasksInsideList(projectsAndTasks[project]);
                        Console.ReadKey();
                        break;
                    case 2:
                        PrintProject(project);
                        Console.ReadKey();
                        break;
                    case 3:
                        project.Status = NewStatusProject();
                        break;
                    case 4:
                        projectsAndTasks[project].Add(AddNewTask(project, projectsAndTasks));
                        break;
                    case 5:
                        DeleteTask(project,projectsAndTasks);
                        break;
                    case 6:
                        ExpectedDurationForAllActivTasksInProject(project, projectsAndTasks);
                        Console.ReadKey();
                        break;
                    case 7:
                        exitMenu = false;
                        break;
                    default:
                        break;
                }
            } while (!exitMenu);
        }
        static List<Task> AddNewTasks(Project project, Dictionary<Project, List<Task>> projectsAndTasks)
        {
            var listOfTasks = new List<Task>();
            do
            {
                listOfTasks.Add(AddNewTask(project, projectsAndTasks));
            } while (ChooseOptionText("Task is added. Do you want to add new task to the project? "));
            return listOfTasks;
        }
        static Task AddNewTask(Project project, Dictionary<Project, List<Task>> projectsAndTasks)
        {
            var name = NewString("Enter task name: ");
            while (TaskExists(name, project, projectsAndTasks))
            {
                name = NewString("There is already task with that name in this project. Enter new task name: ");
            }
            var description = NewString("Enter description: ");
            var deadline = NewFutureDate("project start");
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
            PrintTaskWithProjectName(task);

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
                    Console.Write("1 - View details of task\n2 - Edit status of task\n3 - Choose new task\n3 - Exit submenu\n");

                    switch (ChooseOption(new List<int>() { 1, 2, 3 }))
                    {
                        case 1:
                            PrintTaskWithProjectName(task);
                            Console.ReadKey();
                            break;
                        case 2:
                            EditStatusOfTask(task, projectsAndTasks);
                            break;
                        case 3:
                            changeTask = true;
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
                Console.WriteLine("Status of completed task cannot be changed. ");
            else
            {
                var status = NewStatusTask();
                task.Status = status;
                Console.WriteLine("Status of task changed.");

                if (status == StatusTask.Completed)
                    IsProjectCompleted(task.Project, projectsAndTasks);
            }
        }
        static void IsProjectCompleted(Project project, Dictionary<Project, List<Task>> projectsAndTasks)
        {
            var projectIsCompleted = true;
            foreach(var task in projectsAndTasks[project])
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
                if (project.Name == name) return true;
            }
            return false;
        }
        static Project FindProject(string name, Dictionary<Project, List<Task>> projectsAndTasks)
        {
            foreach (var project in projectsAndTasks.Keys)
            {
                if (project.Name == name)
                    return project;
            }
            return null;
        }
        static Project ChooseProject(Dictionary<Project, List<Task>> projectsAndTasks)
        {
            var name = NewString("Enter project name: ");
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
                if (task.Name == name) return true;
            }
            return false;
        }
        static Task FindTask(string name, List<Task> listOfTaskstasks)
        {
            foreach (var task in listOfTaskstasks)
            {
                if (task.Name == name)
                    return task;
            }
            return null;
        }
        static Task ChooseTask(Dictionary<Project, List<Task>> projectsAndTasks)
        {
            do
            {
                if (!ChooseOptionText("Do you know the name of the task you want? "))
                {
                    foreach (var project in projectsAndTasks.Keys)
                        PrintAllTasksInsideList(projectsAndTasks[project]);
                }
                var taskName = NewString("\nEnter task name: ");

                if (ChooseOptionText("Do you know the name of the project of your task? "))
                {
                    var project = ChooseProject(projectsAndTasks);
                    var task = FindTask(taskName, projectsAndTasks[project]);
                    if (task != null)
                        return task;
                    else
                        Console.WriteLine($"There is no task with name {taskName} in that project.");
                }

                foreach (var project in projectsAndTasks.Keys)
                {
                    foreach (var task in projectsAndTasks[project])
                    {
                        if (task.Name == taskName)
                        {
                            PrintTaskWithProjectName(task);
                            if (ChooseOptionText("Do you want this task?"))
                                return task;
                        }
                    }
                }
            } while (true);
        }


        static StatusProject StatusOfNewProject()
        {
            if (ChooseTwoOptions("Project status:\n1 - Active\n2 - On hold\n"))
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
            Console.Write("Task status:\n1 - Active\n2 - Postponed\n3 - Completed\n");

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
            Console.Write($"\nProject name: {project.Name}\nDescription: {project.Description}\nStart date: {project.StartDate}\nEnd date: {project.EndDate}\nStatus: {project.Status}\n\n");
        }
        static void PrintAllTasksInsideList(List<Task> listOfTasks)
        {
            foreach (var task in listOfTasks)
            {
                PrintTaskWithoutProjectName(task);
            }
        }
        static void PrintTaskWithoutProjectName(Task task)
        {
            Console.Write($"Task name: {task.Name}\nDescription: {task.Description}\nDeadline: {task.Deadline}\nStatus: {task.Status}\nExpected duration: {task.ExpectedDuration}\n\n");
        }
        static void PrintTaskWithProjectName(Task task)
        {
            Console.Write($"Task name: {task.Name}\nDescription: {task.Description}\nDeadline: {task.Deadline}\nStatus: {task.Status}\nExpected duration: {task.ExpectedDuration}\nProject name: {task.Project.Name}\n\n");
        }



        static string NewString(string message)
        {
            Console.Write(message);
            var myString = Console.ReadLine();
            while (myString == "")
            {
                Console.Write(message);          //############
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

            } while (myOption <= lowerLimit || myOption > upperLimit || myOption == 0);

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
        static bool ChooseTwoOptions(string message)
        {
            Console.Write(message);
            if (ChooseOption(new List<int>() { 1, 2 }) == 1)
                return true;
            else
                return false;
        }
    }
}
