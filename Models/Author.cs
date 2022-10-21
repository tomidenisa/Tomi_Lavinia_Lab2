using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Tomi_Lavinia_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        [Display(Name = "Author First Name")]
        public string   FirstName { get; set; }
        public string   LastName { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
