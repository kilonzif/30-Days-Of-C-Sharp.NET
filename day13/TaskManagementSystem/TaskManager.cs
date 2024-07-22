namespace TaskManagementSystem
{
    public class TaskManager
    {
        // Private list to store tasks
        private List<Task> tasks;

        // Constructor to initialize the task list
        public TaskManager()
        {
            tasks = new List<Task>();
        }

        // Method to add a task to the list
        public void AddTask(Task task)
        {
            tasks.Add(task);
        }

        // Method to remove a task from the list by ID
        public void RemoveTask(int taskId)
        {
            tasks.RemoveAll(t => t.Id == taskId);
        }

        // Method to get all tasks
        public IEnumerable<Task> GetTasks()
        {
            return tasks;
        }
    }
}
