using System;
using System.ComponentModel.DataAnnotations;

namespace Greeting_App.Models
{
    public class TodoTask
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Task description cannot be empty.")]
        [StringLength(255)]
        public string Title { get; set; } = string.Empty;

        public bool IsCompleted { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}