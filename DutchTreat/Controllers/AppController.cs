using DutchTreat.Services;
using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DutchTreat.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;

        public AppController(IMailService mailService)
        {
           _mailService = mailService;
        }

        public IActionResult Index()
        {
            
            return View();
        }
        
        [HttpGet("contact")]
        public IActionResult Contacts()
        {
           
            return View();
        }
        [HttpPost("contact")]
        public IActionResult Contacts(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                _mailService.SendMessage("berteskalukas@gmail.com", model.Subject, $"Form:{model.Name} - {model.Email}, Message: {model.Message}, ");
                ModelState.Clear();
            }
            ViewBag.UserMessage = "Message sent";
            return View();
        }


        public IActionResult About()
        {
            ViewBag.Title = "About Us";
            return View();
        }
    }
}
