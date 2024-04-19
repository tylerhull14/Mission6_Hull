using System.ComponentModel.DataAnnotations;

namespace Mission6_Hull.Models
{
    public class Form
    {
        [Key]
        [Required]
        public int FormID { get; set;  }
        // public int GetFormID { get;} // read only varriable
        [Required(ErrorMessage = "Category is required!")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Title is required!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Year is required!")]
        public int Year { get; set; }
        [Required(ErrorMessage = "Director is required!")]
        public string Director { get; set; }
        [Required(ErrorMessage = "Rating is required!")]
        public string Rating { get; set; }
        public string? Edited { get; set; }
        public string? LentTo  { get; set; }
        public string? Notes { get; set; }
}
}
