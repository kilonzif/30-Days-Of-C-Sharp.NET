namespace TaskManagementSystem
{
    /* Demonstrating Polymorphism */
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of TaskManager
            TaskManager taskManager = new TaskManager();

            // Create some tasks
            WorkTask workTask = new WorkTask
            {
                Id = 1,
                Title = "Finish Report",
                Description = "Complete the quarterly report",
                DueDate = DateTime.Now.AddDays(3),
                ProjectName = "Q2 Report"
            };

            PersonalTask personalTask = new PersonalTask
            {
                Id = 2,
                Title = "Grocery Shopping",
                Description = "Buy groceries for the week",
                DueDate = DateTime.Now.AddDays(1),
                Category = "Errands"
            };

            // Add tasks to the manager
            taskManager.AddTask(workTask);
            taskManager.AddTask(personalTask);

            // Display all tasks
            foreach (Task task in taskManager.GetTasks())
            {
                task.Display();
            }

            // Remove a task by ID
            taskManager.RemoveTask(1);

            // Display remaining tasks
            Console.WriteLine("\nAfter removing task with ID 1:");
            foreach (Task task in taskManager.GetTasks())
            {
                task.Display();
            }
        }
    }
}
