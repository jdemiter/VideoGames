using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGames.Models
{
    public class VideoGame
    {
        [Key]
        public int VideoGameID { get; set;  }

        public string Title { get; set; }

        public string Rating { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public string Platform { get; set; }
        public string Publisher { get; set; }
        public string Genre { get; set; }
  
     
        
        }


    }

