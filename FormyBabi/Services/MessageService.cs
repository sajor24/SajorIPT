namespace FormyBabi.Services;

public class MessageService
{
    private readonly List<string> _sweetMessages = new()
    {
        "You're the reason I smile every day 💕",
        "Just thinking about you makes my heart skip a beat 💗",
        "You're my favorite notification 📱💖",
        "I fall in love with you more every single day 🌹",
        "You're not just my girlfriend, you're my best friend 👫",
        "Your happiness is my happiness 😊💕",
        "I'm so lucky to have you in my life 🍀💗",
        "You make ordinary moments extraordinary ✨",
        "My day starts and ends with thoughts of you 🌅🌙",
        "You're the missing piece I didn't know I needed 🧩💖",
        "Every love song reminds me of you 🎵💕",
        "You're beautiful inside and out 🌸",
        "I love your cute little quirks 😊",
        "You're my favorite person to talk to 💬💗",
        "Distance means nothing when you mean everything 🌍💕",
        "You're the best thing that ever happened to me 🎁",
        "I love how you make me feel like I'm home 🏡💖",
        "Your smile is my favorite view 😍",
        "I could listen to you talk for hours 💭💕",
        "You're my today and all of my tomorrows 📅💗"
    };

    private readonly List<string> _dailyMessages = new()
    {
        "Good morning, beautiful! Hope your day is as amazing as you are! ☀️",
        "Remember to smile today - you have the most beautiful smile! 😊",
        "You're doing great! I'm so proud of you! 💪💕",
        "Don't forget to take breaks and take care of yourself today! 🌸",
        "Sending you virtual hugs and kisses! 🤗💋",
        "You're stronger than you think! Keep going! 💪✨",
        "Just a reminder: You're absolutely incredible! 🌟",
        "Hope you're having a wonderful day, my love! 💖"
    };

    public string GetRandomSurprise()
    {
        var random = new Random();
        return _sweetMessages[random.Next(_sweetMessages.Count)];
    }

    public string GetDailyMessage()
    {
        var random = new Random();
        return _dailyMessages[random.Next(_dailyMessages.Count)];
    }
}
