using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGames.Models
{
    public class VideoGameViewModel
    {
        public List<VideoGame> videogames;
        public SelectList publisher;
        public string videogamePublisher { get; set; }

    }
}
