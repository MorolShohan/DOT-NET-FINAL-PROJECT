using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required(ErrorMessage = "Student is required")]
        [ForeignKey("Student")]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Course is required")]
        [ForeignKey("Course")]
        public int CourseId { get; set; }

        [Required(ErrorMessage = "Date of buying is required")]
        [DataType(DataType.DateTime)]
        public DateTime DateOfBuying { get; set; }

        // If you want to include more details about the order, you can add additional properties here

        // Navigation properties
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}
