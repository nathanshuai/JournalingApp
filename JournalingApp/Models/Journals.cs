using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JournalingApp.Models
{
    public class Journals
    {
        [Key]
        public int JournalsId { get; set; }

        public string JournalsName { get; set; }

        [ForeignKey("BlogId")]
        public int BlogId { get; set; }
        public Blogs Blogs { get; set; }
    }
}
