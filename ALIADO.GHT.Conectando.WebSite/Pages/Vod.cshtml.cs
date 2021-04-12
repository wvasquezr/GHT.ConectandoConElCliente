using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALIADO.GHT.Conectando.WebSite.Models;
using ALIADO.GHT.Conectando.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ALIADO.GHT.Conectando.WebSite.Pages
{
    public class VodModel : PageModel
    {
        private readonly ILogger<VodModel> _logger;
        public JsonFileLiveService LiveService;
        public IEnumerable<Live> Live { get; private set; }

        public VodModel(
            ILogger<VodModel> logger,
            JsonFileLiveService liveService)
        {
            _logger = logger;
            LiveService = liveService;
        }

        public void OnGet()
        {
            Live = LiveService.GetLives();
        }
    }
}
