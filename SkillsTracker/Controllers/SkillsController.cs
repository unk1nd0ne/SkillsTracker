using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SkillsTracker.Controllers
{
    [Route("/skills")]
    public class SkillsController : Controller
    {
        // GET: /skills
        [HttpGet]
        public IActionResult Index()
        {
            string html = 
                "<h1>Skills Tracker</h1>" +
                "<h2>Coding Skills to Learn:" +
                "<ol>" +
                    "<li>C#</li>" +
                    "<li>JavaScript</li>" +
                    "<li>Python</li>" +
                "</ol>";
            return Content(html, "text/html");
        }

        // GET: /skills/form
        [HttpGet("form")]
        public IActionResult Form()
        {
            string html =
                "<form method='post' action='/skills/form'>" +
                    "<h3>Date:</h3>" +
                    "<input type='date' name='date'/>" +
                    "<h3>C#:</h3>" +
                    "<select name='cSharp'>" +
                        "<option value='Learning basics'> Learning basics </option>" +
                        "<option value='Making Apps'> Making Apps </option>" +
                        "<option value='Master Coder'> Master Coder </option>" +
                    "</select>" +
                    "<h3>JavaScript:</h3>" +
                    "<select name='javaScript'>" +
                        "<option value='Learning basics'> Learning basics </option>" +
                        "<option value='Making Apps'> Making Apps </option>" +
                        "<option value='Master Coder'> Master Coder </option>" +
                    "</select>" +
                    "<h3>Python:</h3>" +
                    "<select name='python'>" +
                        "<option value='Learning basics'> Learning basics </option>" +
                        "<option value='Making Apps'> Making Apps </option>" +
                        "<option value='Master Coder'> Master Coder </option>" +
                    "</select> <br>" +
                    "<input type='submit' value='Submit' />" +
                "</form>";
            return Content(html, "text/html");
        }

        // POST: /skills/form
        [HttpPost("form")]
        public IActionResult FilledForm(string date, string cSharp, string javaScript, string python)
        {
            string html =
                $"<h1>{date}</h1>" +
                "<ol>" +
                    $"<li>C#: {cSharp}</li>" +
                    $"<li>JavaScript: {javaScript}</li>" +
                    $"<li>Python: {python}</li>" +
                "</ol>";
            return Content(html, "text/html");
        }
    }
}
