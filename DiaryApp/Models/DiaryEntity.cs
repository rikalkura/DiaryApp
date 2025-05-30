using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models;

public class DiaryEntity : BaseEntity
{
    public string Title { get; set; }
    [StringLength(150, MinimumLength = 3, ErrorMessage = "Description must be between 3 and 150 characters")]
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }

    public DiaryEntity()
    {
        Title = string.Empty;
        Description = string.Empty;
        CreatedAt = DateTime.Now;
    }
}
