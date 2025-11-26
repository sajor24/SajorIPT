using FormyBabi.Models;

namespace FormyBabi.Services;

public class LoveLetterService
{
    private List<LoveLetter> _letters = new()
    {
        new LoveLetter 
        { 
            Id = 1, 
            Title = "To My Love Mami",
            Content = @"My Dearest Mami,

Every moment I spend talking to you feels like a dream I never want to wake up from. Kahit online lang tayo nagkakausap, you still manage to brighten my darkest days. Your smile in photos, your laugh sa calls, and the way you tell stories — they've become my favorite parts of every day.

I love how you get excited about the simplest things, how you share your thoughts with me, and how you make everything feel lighter just by being there, kahit sa screen lang.

Thank you for being you, for being mine, and for making every day an adventure.

Forever yours,
Your Dadi",
            DateWritten = DateTime.Now.AddDays(-30)
        }
    };

    public List<LoveLetter> GetAllLetters() => _letters.OrderByDescending(l => l.DateWritten).ToList();

    public LoveLetter? GetLetter(int id) => _letters.FirstOrDefault(l => l.Id == id);

    public void AddLetter(LoveLetter letter)
    {
        letter.Id = _letters.Any() ? _letters.Max(l => l.Id) + 1 : 1;
        letter.DateWritten = DateTime.Now;
        _letters.Add(letter);
    }
}
