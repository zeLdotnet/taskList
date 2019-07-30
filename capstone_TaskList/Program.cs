using System;

namespace capstone_TaskList
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = new Task();
            task.PrintMenu();
            task.GetUserChoice();

        }
    }
}
