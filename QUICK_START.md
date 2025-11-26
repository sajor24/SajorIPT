# 🚀 Quick Start Guide

## Step 1: Customize for Your Girlfriend

### Change Her Name (IMPORTANT!)
Open `FormyBabi/Components/Pages/Home.razor` and change line 11:
```razor
<h1 class="girlfriend-name">For My Beautiful [HER NAME HERE] 💕</h1>
```

### Set Your Anniversary Date (IMPORTANT!)
Open `FormyBabi/Components/Pages/Countdown.razor` and change line 73:
```csharp
private DateTime relationshipStart = new DateTime(2024, 5, 23); // YOUR DATE HERE!
```
Format: `new DateTime(YEAR, MONTH, DAY)`

## Step 2: Add Your Photos (Optional)

1. Copy your photos to: `FormyBabi/wwwroot/photos/`
2. Name them something simple like: `date1.jpg`, `us.jpg`, etc.
3. Reference them in memories as: `/photos/date1.jpg`

## Step 3: Run the App

Open terminal in the FormyBabi folder and run:
```
dotnet run
```

Then open your browser to: `https://localhost:5001`

## Step 4: Add Your Content

1. **Write Love Letters** - Click "Love Letters" and add your own
2. **Add Memories** - Click "Our Memories" and add special moments
3. **Customize Messages** - Edit the messages in `Services/MessageService.cs`

## 🎁 Ready to Share?

Once you're happy with it:
1. Send her the link
2. Or deploy it online (see README.md for options)
3. Or show it to her in person!

## Need Help?

Check the full README.md for detailed instructions and troubleshooting.

Enjoy! 💕
