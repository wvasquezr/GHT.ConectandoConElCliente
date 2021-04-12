using ALIADO.GHT.Conectando.WebSite.Models;
using ALIADO.GHT.Conectando.WebSite.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALIADO.GHT.Conectando.WebSite.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VideoController : ControllerBase
    {
        public JsonFileVideoService VideoService { get; }

        public VideoController(JsonFileVideoService videoService)
        {
            VideoService = videoService;
        }

        [HttpGet]
        public IEnumerable<Video> Get()
        {
            return VideoService.GetVideos();
        }
    }
}
