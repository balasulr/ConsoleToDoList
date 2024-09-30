using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class ProgramEnhancements
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the To Do List Program!");

            Console.WriteLine(); // Adds new line to Console application

            string option = ""; // String that will contain player's choice

            // Main loop of program that continues running until player exits program with E
            while (option != "E")
            {
                // Menu options
                Console.WriteLine();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine();

                Console.WriteLine("Enter 1 to Add task to list");
                Console.WriteLine("Enter 2 to Remove task from the list");
                Console.WriteLine("Enter 3 to View the list");
                Console.WriteLine("Enter E to Exit program");
                Console.WriteLine();
                Console.WriteLine("Choose an option:");

                option = Console.ReadLine() ?? string.Empty; // Holds player's choice & assigns empty string if Console.ReadLine() returns null

                // Handles player choice using switch option
                switch (option)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        RemoveTask();
                        break;
                    case "3":
                        ViewTask();
                        break;
                    case "E":
                        Console.WriteLine("Exiting program");
                        Console.WriteLine("Thank you for using the program! Please come again!");
                        return; // Exits the program
                    default: // Deals with incorrect input
                        Console.WriteLine();
                        Console.WriteLine("Invalid choice entered, Please enter a number between 1 to 3 or E to Exit Program");
                        Console.WriteLine();
                        break;
                }
            }
        }

        // String List to store tasks in to-do list
        static List<string> taskList = new List<string>();

        // Option 1: Adds task to list
        static void AddTask()
        {
            Console.WriteLine();
            Console.WriteLine("Please enter name of the task to add to list:");

            string? task = Console.ReadLine(); // Reads task name from user input since it can be blank

            // Checks if string is null or empty and if not, adds tasks to list
            if (string.IsNullOrEmpty(task))
            {
                Console.WriteLine("No task entered, Please try again!");
                Console.WriteLine();
            } else
            {
                taskList.Add(task);
                Console.WriteLine();
                Console.WriteLine("Task added successfully to the list!");
                Console.WriteLine();
            }
        }

        // Option 2: Removes task from list
        static void RemoveTask()
        {
            Console.WriteLine();

            if (taskList.Count == 0)
            {
                Console.WriteLine("No tasks to remove, please try again!");
                return;
            }

            Console.WriteLine("These are all the tasks in a list:");

            // Prints all tasks in list with for loop
            for (int i = 0; i < taskList.Count; i++)
            {
                Console.WriteLine(i + " : " + taskList[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Please enter the number of task to remove from list:"); // Number of task that want to remove from list

            int taskNumber = Convert.ToInt32(Console.ReadLine()); // Retrieves the number entered from player

            taskList.RemoveAt(taskNumber); // Removes the item from list
            Console.WriteLine();
            Console.WriteLine("Task removed successfully from the list!");
            Console.WriteLine();
        }

        // Option 3: View the list
        static void ViewTask()
        {
            Console.WriteLine();
            Console.WriteLine("Current tasks in the list:");

            for (int i = 0; i < taskList.Count; i++)
            {
                Console.WriteLine(taskList[i]);
            }

            Console.WriteLine();
        }
    }
}