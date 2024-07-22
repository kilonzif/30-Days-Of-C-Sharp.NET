namespace TaskManagementSystem
{
    // Derived class for work-related tasks
    public class WorkTask : Task
    {
        // Additional property specific to WorkTask
        public string ProjectName { get; set; }  // Name of the project associated with the task

        // Override the Display method to show work task details
        public override void Display()
        {
            Console.WriteLine($"[Work Task] ID: {Id}, Title: {Title}, Project: {ProjectName}, Due: {DueDate.ToShortDateString()}");
        }
    }

  
}
