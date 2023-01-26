using LeaderBoardExample.Models;
using Microsoft.AspNetCore.Mvc;


namespace LeaderBoardExample.Controllers
{
    public class LeaderBoardController : Controller
    {
        [HttpGet]
        public IActionResult GetIndex()
        {
            return new JsonResult(
                new List<Record>
                {
                    new() {Name = "Jack", Time = 5.5f},
                    new() {Name = "Suz", Time = 3},
                    new() {Name = "Anton", Time = 20},
                }
            );
        }


        [HttpPost]
        public IActionResult PostIndex()
        {
            Console.WriteLine(Request.Form.Count);
            return Ok();
        }
    }
}