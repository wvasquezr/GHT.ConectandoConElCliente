using ALIADO.GHT.Conectando.WebSite.Models;
using ALIADO.GHT.Conectando.WebSite.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ALIADO.GHT.Conectando.WebSite.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LiveController : ControllerBase
    {
        //private object ihostingEnvironment;
        //private object photo;

        public JsonFileLiveService LiveService { get; }
        public LiveController(JsonFileLiveService liveService)
        {
            LiveService = liveService;
        }

        [HttpGet]
        public IEnumerable<Live> Get()
        {
            return LiveService.GetLives();
        }

        //[HttpPut] 
        [HttpPost]
        public IActionResult ChangeVideo(Live newVideo, IFormFile video)
        {
            if (video == null || video.Length == 0)
            {
                return Content("Hubo un error en la carga del video");

            }
            else
            {
                //var path = Path.Combine(this.ihostingEnvironment.WebRootPath, "images", video.FileName);
                //var stream = new FileStream(path, FileMode.Create);
                //video.CopyToAsync(stream);
                //newVideo.Src = video.FileName;
            }
            LiveService.AddLiveVideo(newVideo);
            return Ok();
        }
       
    }
}
