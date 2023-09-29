using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayName("Username")]
        [Column(TypeName = "nvarchar(255)")]
        public string UserName { get; set; }

        [Required]
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        public string PasswordHash { get; set; }
    }

    public class Tasks
    {
        [Key]
        public int TaskId { get; set; }

        [ForeignKey("UserId")]
        [DisplayName("User ID")]
        [Required]
        public int UserId { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [DisplayName("Due Date")]
        public DateTime DueDate { get; set; }

        [DisplayName("Completion Status")]
        public bool IsCompleted { get; set; } = false;
    }
}
