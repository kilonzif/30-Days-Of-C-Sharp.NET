using System;
using System.Collections.Generic;

namespace TaskManagementSystem
{
    // Abstract base class
    public abstract class Task
    {
        // Properties of the Task
        public int Id { get; set; }  // Unique identifier for the task
        public string Title { get; set; }  // Title of the task
        public string Description { get; set; }  // Description of the task
        public DateTime DueDate { get; set; }  // Due date of the task

        // Abstract method to be overridden in derived classes
        public abstract void Display();  // Display task details
    }
}
