using System.Collections.Generic;

namespace TaskTracker.Models 
{
    public static class Repository 
    {
        private static List<Task> tasks = new List<Task>();

        public static IEnumerable<Task> Tasks 
        {
            get 
            {
                return tasks;
            }
        }

        public static void AddTask(Task task) 
        {
            tasks.Add(task);
        }
    }
}
