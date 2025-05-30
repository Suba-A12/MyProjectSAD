using System.ComponentModel.DataAnnotations;

namespace MyProjectSAD.Models
{
    public class Author
    {
        [Key]
        public  int AuthorId { get; set; }
        public  string Fname { get; set; }
        public string Lname { get; set; }
    }
}
