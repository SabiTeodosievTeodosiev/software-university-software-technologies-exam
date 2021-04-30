using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace AnimeList.Models
{
    public class Anime
    {
        //TODO: Implement me ...

        [Key] //id
        public int Id { get; set; }

        [Required] //attribute (non null/empty)
        public int Rating { get; set; }

        [Required] //attribute (non null/empty)
        [AllowHtml] //prevents <script>alert
        public string Name { get; set; }

        [Required] //attribute (non null/empty)
        [AllowHtml] //prevents <script>alert
        public string Description { get; set; }

        [Required] //attribute (non null/empty)
        [AllowHtml] //prevents <script>alert
        public string Watched { get; set; }

        //TODO: Implement me ... END
    }
}