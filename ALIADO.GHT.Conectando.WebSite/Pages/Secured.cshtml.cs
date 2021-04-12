using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ALIADO.GHT.Conectando.WebSite.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Azure.Management.Media.Models;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ALIADO.GHT.Conectando.WebSite.Services;


namespace ALIADO.GHT.Conectando.WebSite.Pages.Home
{
    public class SecuredModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IHostEnvironment _environment;
        public JsonFileLiveService LiveVideoService;
        public MediaAPIService _mediaAPIService;

        [BindProperty]
        public IFormFile NewVideoFile { get; set; }

        [BindProperty]
        public Live newVideo { get; set; }
       

        public SecuredModel(ILogger<IndexModel> logger, IHostEnvironment environment,
            JsonFileLiveService liveVideoService, MediaAPIService mediaAPIService)
        {
            _logger = logger;
            _environment = environment;
            LiveVideoService = liveVideoService;
            _mediaAPIService = mediaAPIService;
        }
        
        public void OnGet()
        {
           
        }

        public async Task OnPostAsync(IFormFile newVideoFile)
        {
            
            _logger.LogInformation($"Uploading {newVideoFile.FileName}.");
            string targetFileName = $"{_environment.ContentRootPath}/{newVideoFile.FileName}";

            using (var stream = new FileStream(targetFileName, FileMode.Create))
            {
                await  newVideoFile.CopyToAsync(stream);
            }

            newVideo.Upload = DateTime.Today.ToString();
            newVideo.Src = targetFileName;
           LiveVideoService.AddLiveVideo(newVideo);

            //use AzMS
            _ = MediaAPIService.StartVod(newVideoFile.FileName);
            
        }
    }
}
