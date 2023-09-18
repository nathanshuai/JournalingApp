using JournalingApp.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;

namespace JournalingApp.Models
{
    public class Blogs
    {
        [Key]
        public int BlogId { get; set; }
        public string Title { get; set; }

        public string UserId { get; set; }
        public JournalingAppUser User { get; set; }
        public List<Journals> Journals { get; set; } = new List<Journals>();
    }
}
