using System;
using Microsoft.AspNetCore.Mvc;
using TaskTracker.Models;
using System.Linq;

namespace TaskTracker.Controllers 
{
    public class HomeController : Controller 
    {
        public static int identity = 0;
        public ViewResult Index() 
        {
            return View("Index");
        }

        [HttpGet]
        public ViewResult AddingTaskForm() 
        {
            return View();
        }

        public ViewResult Contact()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddingTaskForm(Task task)
        {
            if (ModelState.IsValid) 
            {
                task.TaskID = ++identity;
                task.AddingTime = DateTime.Now;
                Repository.AddTask(task);
                return View("Success", task);
            } 
            else 
            {
                // there is a validation error
                return View();
            }
        }

        public ViewResult ListTasks() 
        {
            return View(Repository.Tasks);
        }
    }
}