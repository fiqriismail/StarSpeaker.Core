// -----------------------------------------------------------------------------------------------
// Copyright (C) Fiqri Ismail 
// Created just for fun for learning purposes of "The Standard" 
// The Standard: https://github.com/hassanhabib/The-Standard
// -----------------------------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;

namespace StarSpeaker.Core.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get() =>
            Ok("Talk is cheap. Show me the code. ~ Linus Torvalds");
    }
}
