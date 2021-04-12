using ALIADO.GHT.Conectando.WebSite.Models;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ALIADO.GHT.Conectando.WebSite.Services
{
    public class JsonFileLiveService
    {
        public IWebHostEnvironment WebHostEnvironment { get; }

        public JsonFileLiveService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "live.json"); }
        }

        public IEnumerable<Live> GetLives()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Live[]>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            }
        }

        public Live GetLive()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Live>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            }
        }

        public void AddLiveVideo(Live newLiveVideo)
        {            
            // new video
            StringBuilder sb = new StringBuilder();
            sb.Append(newLiveVideo.Upload);
            sb.Append("_");
            sb.Append(newLiveVideo.Title);
                      
            var liveVideo = new Live
            {
                Id = sb.ToString(),
                Title = newLiveVideo.Title,
                Description = newLiveVideo.Description,
                Maker = newLiveVideo.Maker,
                PosterImg = newLiveVideo.PosterImg,
                Upload = newLiveVideo.Upload,
                Src = newLiveVideo.Src
            };
            //copy the actual and create new record in videos.json before update
            var newOldVideo = GetLives().First();

            if (newOldVideo == null)
            {
                newOldVideo = liveVideo;
            }
            else
            {
                var newVideo = new Video 
                {
                    Id = newOldVideo.Id,
                    Title = newOldVideo.Title,
                    Description = newOldVideo.Description,
                    Maker = newOldVideo.Maker,
                    PosterImg = newOldVideo.PosterImg,
                    Upload = newOldVideo.Upload,
                    Src = newOldVideo.Src
                };

                //llamar a servicio de videos viejos y adjuntar el nuevo registro
                JsonFileVideoService addOldVideo = new JsonFileVideoService(WebHostEnvironment);
                addOldVideo.AddVideo(newVideo);
            }

            using(var outputStream = File.OpenWrite(JsonFileName))
            {
                JsonSerializer.Serialize<Live>(
                    new Utf8JsonWriter(outputStream, new JsonWriterOptions
                    {
                        SkipValidation = true,
                        Indented = true
                    }
                    ), 
                    liveVideo
                    );
            }
        }

       
    }
}
