using System;
using System.ComponentModel.DataAnnotations;

namespace TaskHub.Models
{
    public class Task
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Title must be at least 3 characters long.")]
        public string? Title { get; set; }

        public bool IsCompleted { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DueDate { get; set; }

    }
}
