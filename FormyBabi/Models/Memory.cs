namespace FormyBabi.Models;

public class Memory
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public string? ImagePath { get; set; }
}
