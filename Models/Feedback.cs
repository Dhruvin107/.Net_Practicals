using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PRACTICAL_7.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50,ErrorMessage = "Name cannot be longer than 50 characters")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
  
        public string Email { get; set; }
        [Required(ErrorMessage = "Comments is required")]
        [StringLength(500, ErrorMessage = "Comments cannot be longer than 500 characters")]

        public string Comments { get; set; }
        [Required(ErrorMessage = "Rating is required")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
        public int Rating { get; set; }

    }
}