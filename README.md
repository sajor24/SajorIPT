# 💕 FormyBabi - A Romantic Web App

A beautiful, romantic web application built with Blazor for your special someone!

## ✨ Features

- **Home Page** - Personalized greeting with daily messages and surprise button
- **Love Letters** - Write and read romantic letters
- **Memories Gallery** - Timeline of your special moments together
- **Anniversary Countdown** - Live countdown to your next anniversary with milestones
- **Daily Messages** - Sweet messages that change every day
- **Surprise Messages** - Random romantic messages at the tap of a button

## 🎨 Design

- Soft pink and peach color palette
- Smooth animations and transitions
- Responsive design for mobile and desktop
- Cute icons and rounded corners
- Heartbeat animations

## 🚀 How to Run

### Prerequisites
- .NET 9.0 SDK installed

### Steps

1. **Open the project folder in terminal/command prompt**
   ```
   cd FormyBabi
   ```

2. **Run the application**
   ```
   dotnet run
   ```

3. **Open your browser**
   - Navigate to: `https://localhost:5001` or `http://localhost:5000`
   - The app will automatically open in your default browser

4. **Build for production (optional)**
   ```
   dotnet publish -c Release
   ```

## 📝 Customization Guide

### 1. Change Your Girlfriend's Name
Edit `FormyBabi/Components/Pages/Home.razor` line 11:
```razor
<h1 class="girlfriend-name">For My Beautiful [Her Name] 💕</h1>
```

### 2. Set Your Anniversary Date
Edit `FormyBabi/Components/Pages/Countdown.razor` line 73:
```csharp
private DateTime relationshipStart = new DateTime(2024, 5, 23); // Change to your date!
```

### 3. Add Your Own Messages
Edit `FormyBabi/Services/MessageService.cs` to add more sweet messages to the lists

### 4. Add Photos
- Place photos in `FormyBabi/wwwroot/photos/` folder
- Reference them in memories as `/photos/yourphoto.jpg`

### 5. Customize Colors
Edit `FormyBabi/wwwroot/app.css` at the top:
```css
:root {
    --primary-pink: #FFB6C1;
    --soft-peach: #FFDAB9;
    --light-pink: #FFF0F5;
    --rose: #FF69B4;
}
```

## 💡 Ideas for Improvement

### Easy Additions:
1. **Background Music** - Add a music player with her favorite song
2. **Photo Upload** - Allow uploading photos directly from the app
3. **Voice Messages** - Record and play voice notes
4. **Shared Calendar** - Mark special dates and events
5. **Mood Tracker** - Track daily moods with cute emojis

### Advanced Features:
1. **Database Storage** - Save data permanently (currently in-memory)
2. **Mobile App** - Convert to MAUI for native mobile experience
3. **Push Notifications** - Send daily reminders and messages
4. **Weather Integration** - Show weather with romantic messages
5. **Spotify Integration** - Share and play songs together
6. **Video Messages** - Record and watch video messages
7. **Interactive Games** - Add couple quizzes and games
8. **Chat Feature** - Private messaging within the app

### Romantic Touches:
1. **Reasons I Love You** - Daily reasons why you love her
2. **Future Plans** - List of things you want to do together
3. **Inside Jokes** - Collection of your special moments
4. **Virtual Hugs** - Animated hug button with haptic feedback
5. **Star Map** - Show the stars from your first date
6. **Love Language Quiz** - Discover each other's love languages
7. **Bucket List** - Shared dreams and goals
8. **Time Capsule** - Messages to open in the future

## 📱 Deployment Options

### Option 1: Azure (Recommended)
- Free tier available
- Easy deployment with Visual Studio
- Custom domain support

### Option 2: GitHub Pages
- Free hosting
- Requires Blazor WebAssembly conversion

### Option 3: Local Network
- Run on your computer
- Access from any device on same WiFi

## 🎁 Making it Special

1. **Surprise Reveal** - Don't tell her about it, just send the link!
2. **Add Personal Touches** - Include inside jokes and special memories
3. **Update Regularly** - Add new letters and memories often
4. **Custom Domain** - Get a romantic domain name like "ourlovestory.com"
5. **Print QR Code** - Create a cute card with QR code to the app

## 🛠️ Tech Stack

- **Framework**: Blazor Server (.NET 9.0)
- **Language**: C#
- **Styling**: Custom CSS with animations
- **Architecture**: Clean separation with Services and Models

## 📂 Project Structure

```
FormyBabi/
├── Components/
│   ├── Pages/
│   │   ├── Home.razor          # Main landing page
│   │   ├── LoveLetters.razor   # Love letters page
│   │   ├── Memories.razor      # Memories timeline
│   │   └── Countdown.razor     # Anniversary countdown
│   └── Layout/
│       └── MainLayout.razor    # Main layout
├── Models/
│   ├── Memory.cs               # Memory data model
│   └── LoveLetter.cs          # Love letter model
├── Services/
│   ├── MemoryService.cs       # Manages memories
│   ├── MessageService.cs      # Handles messages
│   └── LoveLetterService.cs   # Manages letters
├── wwwroot/
│   ├── app.css                # All styling
│   └── photos/                # Photo storage
└── Program.cs                 # App configuration
```

## 💝 Tips for Success

1. **Be Genuine** - Add real memories and feelings
2. **Keep it Updated** - Add new content regularly
3. **Make it Interactive** - Encourage her to add memories too
4. **Backup Data** - Save important memories externally
5. **Have Fun** - This is about celebrating your love!

## 🐛 Troubleshooting

**App won't start?**
- Make sure .NET 9.0 SDK is installed
- Try `dotnet clean` then `dotnet run`

**Changes not showing?**
- Hard refresh browser (Ctrl+F5)
- Clear browser cache

**Port already in use?**
- Change port in `Properties/launchSettings.json`

## ❤️ Final Notes

This app is a labor of love! Feel free to customize it as much as you want. The most important thing is that it comes from your heart.

Remember: It's not about having the perfect app, it's about showing her you care enough to create something special just for her.

Good luck, and I hope she loves it! 💕
