namespace DiaryApp.Models;

public class DiaryEntity : BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }

    public DiaryEntity()
    {
        Title = string.Empty;
        Description = string.Empty;
        CreatedAt = DateTime.Now;
    }
}
