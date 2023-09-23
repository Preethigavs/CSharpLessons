using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MvcAppDemo.Models
{
    public class Author
    {
        [Key] //square brackets are annotations . fields are decorated they are meta data.
              //book id, cost, author are all properties of book class. for each of them adding constraints which is called validators
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int authorID { set; get; }
        
        public String AuthorName { set; get; }

        public DateTime DateofBirth { set; get; }
        public String Royalty { set; get; }
        public int BookPublished { set; get; }

    }
             
}


