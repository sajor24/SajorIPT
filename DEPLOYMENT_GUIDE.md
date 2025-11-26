# 🚀 Deployment Guide

## Option 1: Run Locally (Easiest)

Perfect for showing her in person or on your local network.

### Steps:
1. Open terminal in the `FormyBabi` folder
2. Run: `dotnet run`
3. Open browser to: `https://localhost:5001`

### Share on Local Network:
1. Find your computer's IP address:
   - Windows: `ipconfig` (look for IPv4)
   - Mac/Linux: `ifconfig`
2. Run with: `dotnet run --urls "http://0.0.0.0:5000"`
3. Share the link: `http://YOUR_IP:5000`
4. She can access it from her phone/computer on same WiFi

---

## Option 2: Deploy to Azure (Recommended for Online Access)

Free tier available! Perfect for 24/7 access from anywhere.

### Prerequisites:
- Azure account (free tier available)
- Visual Studio or VS Code with Azure extension

### Steps:

#### Using Visual Studio:
1. Right-click project → Publish
2. Select Azure → Azure App Service (Windows)
3. Create new or select existing App Service
4. Click Publish
5. Get your URL: `https://yourappname.azurewebsites.net`

#### Using Azure CLI:
```bash
# Login to Azure
az login

# Create resource group
az group create --name FormyBabiRG --location eastus

# Create app service plan (Free tier)
az appservice plan create --name FormyBabiPlan --resource-group FormyBabiRG --sku FREE

# Create web app
az webapp create --name YourUniqueAppName --resource-group FormyBabiRG --plan FormyBabiPlan

# Deploy
dotnet publish -c Release
cd bin/Release/net9.0/publish
az webapp deployment source config-zip --resource-group FormyBabiRG --name YourUniqueAppName --src publish.zip
```

### Cost:
- Free tier: $0/month (perfect for this app!)
- Basic tier: ~$13/month (if you need more resources)

---

## Option 3: Deploy to GitHub Pages (Static Version)

Free hosting, but requires converting to Blazor WebAssembly.

### Steps:
1. Convert project to Blazor WebAssembly:
   ```bash
   dotnet new blazorwasm -o FormyBabiWasm
   # Copy your components, services, and models
   ```

2. Update `FormyBabiWasm.csproj`:
   ```xml
   <PropertyGroup>
     <GHPages>true</GHPages>
   </PropertyGroup>
   ```

3. Build for GitHub Pages:
   ```bash
   dotnet publish -c Release
   ```

4. Deploy to GitHub:
   - Create GitHub repository
   - Push code
   - Enable GitHub Pages in settings
   - Point to `/docs` or `gh-pages` branch

---

## Option 4: Deploy to Railway/Render (Easy & Free)

### Railway.app:
1. Sign up at railway.app
2. New Project → Deploy from GitHub
3. Connect your repository
4. Railway auto-detects .NET and deploys
5. Get your URL

### Render.com:
1. Sign up at render.com
2. New Web Service
3. Connect GitHub repository
4. Build command: `dotnet publish -c Release -o out`
5. Start command: `dotnet out/FormyBabi.dll`
6. Deploy!

---

## Option 5: Docker Container

For advanced users who want full control.

### Create Dockerfile:
```dockerfile
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["FormyBabi/FormyBabi.csproj", "FormyBabi/"]
RUN dotnet restore "FormyBabi/FormyBabi.csproj"
COPY . .
WORKDIR "/src/FormyBabi"
RUN dotnet build "FormyBabi.csproj" -c Release -o /app/build
RUN dotnet publish "FormyBabi.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "FormyBabi.dll"]
```

### Build and Run:
```bash
docker build -t formybabi .
docker run -p 5000:8080 formybabi
```

---

## 🎁 Making it Special

### Custom Domain:
1. Buy a romantic domain (e.g., ourlovestory.com, [yournames].love)
2. Point it to your deployed app
3. Add SSL certificate (usually free with hosting)

### QR Code:
1. Generate QR code for your app URL
2. Print it on a card
3. Give it to her as a gift!

### Password Protection (Optional):
Add authentication to make it private:
```csharp
// In Program.cs
builder.Services.AddAuthentication();
builder.Services.AddAuthorization();
```

---

## 📱 Mobile App Version

Want a native mobile app? Convert to .NET MAUI:

1. Create new MAUI project
2. Copy your Razor components
3. Build for iOS/Android
4. Publish to App Store/Play Store

---

## 🔒 Security Tips

1. **Don't commit sensitive data** - Use environment variables
2. **Enable HTTPS** - Most hosts do this automatically
3. **Add authentication** - If you want it private
4. **Backup data** - Export memories regularly
5. **Use secrets** - For API keys (if you add features)

---

## 💾 Data Persistence

Current version stores data in memory (resets on restart).

### To Add Database:
1. Add Entity Framework Core
2. Use SQLite for simple setup
3. Or use Azure SQL for cloud

Example:
```bash
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
```

---

## 🐛 Troubleshooting Deployment

### App won't start:
- Check .NET version matches (9.0)
- Verify all dependencies are included
- Check logs in hosting platform

### CSS not loading:
- Ensure `app.css` is in `wwwroot`
- Check build output includes `wwwroot`
- Clear browser cache

### 404 errors:
- Check routing configuration
- Verify base path in `App.razor`
- Ensure all pages have `@page` directive

---

## 📊 Monitoring

### Free Monitoring Tools:
- Azure Application Insights (free tier)
- Google Analytics (add to track visits)
- UptimeRobot (monitor if site is up)

---

## 💡 Pro Tips

1. **Test locally first** - Make sure everything works
2. **Use environment variables** - For configuration
3. **Enable logging** - To debug issues
4. **Set up CI/CD** - Auto-deploy on code changes
5. **Monitor performance** - Keep it fast and responsive

---

## 🎉 You're Ready!

Choose the deployment option that works best for you:
- **Just showing her?** → Run locally
- **Want it online?** → Azure or Railway
- **Tech-savvy?** → Docker or custom server

Remember: The deployment method doesn't matter as much as the love you put into it! 💕

Good luck! 🚀
