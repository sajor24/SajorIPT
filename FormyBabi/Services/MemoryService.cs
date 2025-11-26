using FormyBabi.Models;

namespace FormyBabi.Services;

public class MemoryService
{
    private List<Memory> _memories = new()
    {
        new Memory { Id = 1, Title = "", Content = "", Date = DateTime.Now.AddMonths(-6), ImagePath = "/photos/photo1.jpg" },
        new Memory { Id = 2, Title = "", Content = "", Date = DateTime.Now.AddMonths(-4), ImagePath = "/photos/photo2.jpg" },
        new Memory { Id = 3, Title = "", Content = "", Date = DateTime.Now.AddMonths(-3), ImagePath = "/photos/photo3.jpg" },
        new Memory { Id = 4, Title = "", Content = "", Date = DateTime.Now.AddMonths(-2), ImagePath = "/photos/S.jpg" }
    };

    public List<Memory> GetAllMemories() => _memories.OrderByDescending(m => m.Date).ToList();

    public void AddMemory(Memory memory)
    {
        memory.Id = _memories.Any() ? _memories.Max(m => m.Id) + 1 : 1;
        _memories.Add(memory);
    }

    public void DeleteMemory(int id)
    {
        var memory = _memories.FirstOrDefault(m => m.Id == id);
        if (memory != null) _memories.Remove(memory);
    }
}
