using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Stylin.Models;
using System.Security.Claims;

namespace Stylin.Controllers
{

    //Why is this here? why is it inheriting from the Controller class? And why does it have a method called answers in it.
    public class Style : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        
        //[FromBody] attribute is an update in .NET Core to get JSON Data from client
        public ActionResult Answers([FromBody] Answer answer)
        {
            //1. Who is logged in

            Subscriber subscriber = new Subscriber();

            subscriber.StyleName = answer.answer0 + ',' + answer.answer1 + ',' + answer.answer2 + ',' + answer.answer3 + ',' + answer.answer4 + ',' + answer.answer5 + ',' + answer.answer6;

            return View();
        }
    }
}
