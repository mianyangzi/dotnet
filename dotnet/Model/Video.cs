using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet.Model
{
    public class Video
    { 

        public Video(string _Title, DateTime _PublishDate)
        {
            Title = _Title;
            PublishDate = _PublishDate;
        }

        [Required]
        public string Id { get; set; }

        [StringLength(60,MinimumLength = 5)]
        [Required]
        public string Title { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime PublishDate { get; set; }

        [Url]
        public string Url { get; set; }
    }
}
