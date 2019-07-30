using System;
using System.Collections.Generic;
using System.Text;

namespace capstone_TaskList
{
    class Task
    {
        #region Fields
        private string teamMembers;
        private string tasks;
        #endregion

        #region Properties
        public string TeamMembers
        {
            get
            {
                return teamMembers;
            }
            set
            {
                teamMembers = value;
            }
        }

        public string Tasks
        {
            get
            {
                return tasks;
            }
            set
            {
                tasks = value;
            }
        }
        #endregion


        #region Constructors
        public Task()
        {

        }


        public Task(string _teamMembers, string _tasks)
        {
            teamMembers = _teamMembers;
            tasks = _tasks;
        }
        #endregion


        #region Methods
        public List<string> PrintMenu()
        {
            List<string> menu = new List<string>
            {
                "List tasks", "Add task", "Delete task", "Mark task complete", "Quit"
            };

            int optionNumber = 0;
            Console.WriteLine("Welcome to TaskR!\n");
            foreach (string option in menu)
            {
                Console.WriteLine($"{optionNumber + 1}: {option}");
                optionNumber++;
            }
            Console.WriteLine("\nchoose an option to get started. \t");

            return menu;
        }

        public int GetUserChoice()
        {
            int menuOption = int.Parse(Console.ReadLine());
            return menuOption;
        }

        public List<string> ChoseThisOption(int userChoice)
        {
            if (userChoice == 1)
            {
                List<string> taskList = new List<string> { };

            }
        }

        public static void AddToList(List<string> list, string input)
        {
            list.Add(input);
        }

        public static void DeleteFromList(List<string> list, string input)
        {
            list.Remove(input);
        }
        #endregion
    }
}
