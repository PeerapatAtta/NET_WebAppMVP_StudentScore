using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebAppMVP.Models
{
    //Class = Table Name
    public class Student
    {
        //Property/Special Method = Column of Table
        //Data Annotation/Attribute = [...]
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please input Student Name")]
        [DisplayName("Student Name")]
        public string Name { get; set; }

        [DisplayName("Student Score")]
        [Range(0, 100, ErrorMessage = "Please input score 0-100")]
        public int Score { get; set; }
    }
}
