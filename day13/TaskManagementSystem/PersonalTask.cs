namespace TaskManagementSystem
{
    // Derived class for personal tasks
    public class PersonalTask : Task
    {
        // Additional property specific to PersonalTask
        public string Category { get; set; }  // Category of the personal task

        // Override the Display method to show personal task details
        public override void Display()
        {
            Console.WriteLine($"[Personal Task] ID: {Id}, Title: {Title}, Category: {Category}, Due: {DueDate.ToShortDateString()}");
        }
    }
}