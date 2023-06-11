using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private static ContentResult mainPageResponse = new()
        {
            ContentType = "text/html",
            StatusCode = (int)HttpStatusCode.OK,
            Content = @"
<h1>Coming soon...</h1>
<p><a href=""https://www.linkedin.com/in/merkithuseyin/"" target=""_blank"" rel=""noopener noreferrer"">LinkedIn</a></p>
<p><a href=""https://github.com/merkithuseyin"" target=""_blank"" rel=""noopener noreferrer"">Github</a></p>
<p><a href=""mailto:merkithuseyin@gmail.com"">merkithuseyin@gmail.com</a></p>"
        };

        [HttpGet]
        [Route("/")]
        public IActionResult HomePage()
        {
            return mainPageResponse;
        }
    }
}
