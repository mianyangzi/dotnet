using dotnet.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet.Controllers
{
    public class VideosController:Controller
    {
        private ICollection<Video> _Video = new List<Video>
        {
            new Video("a",new DateTime(2016,10,5)),
            new Video("b",new DateTime(2017,10,5)),
        };
        
        public IActionResult Index()
        {
            var videos = _Video.OrderByDescending(v => v.PublishDate).ToList();
            return View(videos);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
