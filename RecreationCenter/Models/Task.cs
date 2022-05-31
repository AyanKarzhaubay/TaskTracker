using System.ComponentModel.DataAnnotations;
using System;
namespace TaskTracker.Models 
{

    public class Task 
    {
        public int TaskID { get; set; }

        [Required(ErrorMessage = "Please, enter the task name:")]
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime AddingTime { get; set; }
    }
}
