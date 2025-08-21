using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using roosapp.data;

namespace roosapp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif
        // DbContext
        builder.Services.AddDbContext<DataContext>(options =>
            options.UseSqlite($"Data Source={Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "dataContext.db")}"));

        // DataService registreren
        builder.Services.AddScoped<DataService>();

        return builder.Build();
    }
}
