using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class StudentComment
    {
        public int Id { get; set; }

        [Required]
        public string Comment { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]

        public string CommentedBy { get; set; }
        [Required]
        [ForeignKey("StudentPost")]
        public int PostId { get; set; }

        public virtual StudentPost StudentPost { get; set; }

        public virtual Student Student { get; set; }


    }
}

