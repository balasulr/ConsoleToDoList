using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the to do list program!");

            Console.WriteLine(); // Adds new line to Console application

            List<string> taskList = new List<string>(); // String List to hold tasks in to do list

            string option = ""; // String that will contain player's choice

            // Main loop of program that continues running until player exits program with E
            while (option != "E")
            {
                // Menu options
                Console.WriteLine("What would you like to do?");
                Console.WriteLine();

                Console.WriteLine("Enter 1 to Add task to list");
                Console.WriteLine("Enter 2 to Remove task from the list");
                Console.WriteLine("Enter 3 to View the list");
                Console.WriteLine("Enter E to Exit program");
                Console.WriteLine();

                option = Console.ReadLine() ?? string.Empty; // Holds player's choice & assigns empty string if Console.ReadLine() returns null

                // If Statements for each menu option

                // Option 1: Adds task to list
                if (option == "1")
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter name of the task to add to list:");

                    string? task = Console.ReadLine(); // Reads task name from user input since it can be blank

                    // Checks if string is null or empty and if not, adds tasks to list
                    if (string.IsNullOrEmpty(task))
                    {
                        Console.WriteLine("No task entered, Please try again!");
                        Console.WriteLine();
                    }
                    else
                    {
                        taskList.Add(task);
                        Console.WriteLine();
                        Console.WriteLine("Task added successfully to the list!");
                        Console.WriteLine();
                    }
                }

                // Option 2: Removes task from list
                else if (option == "2")
                {
                    Console.WriteLine();

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
                }

                // Option 3: View the list
                else if (option == "3")
                {
                    Console.WriteLine();
                    Console.WriteLine("Current tasks in the list:");

                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(taskList[i]);
                    }

                    Console.WriteLine();
                }

                // Entering E Exits the program
                else if (option == "E")
                {
                    Console.WriteLine("Exiting program");
                }

                // Deals with incorrect input
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid option entered, Please try again");
                    Console.WriteLine();
                }
            }

            // Thank you message for player
            Console.WriteLine("Thank you for using the program! Please come again!");
        }
    }
}