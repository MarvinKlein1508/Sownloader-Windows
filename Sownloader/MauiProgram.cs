using Microsoft.Extensions.Logging;
using Sownloader.Core.Services;
using Sownloader.Data;
using System.Net;

namespace Sownloader;

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
			});

		builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<WeatherForecastService>();
		builder.Services.AddScoped<ApiService>();
		builder.Services.AddScoped<PerformanceService>();
		builder.Services.AddHttpClient<PerformanceService>(client =>
		{
            //client.BaseAddress = 
            client.DefaultRequestHeaders.Add("Accept", "application/json");
			client.DefaultRequestHeaders.Add("Referer", "https://www.google.com");
			client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Linux; Android 7.1.2; Redmi 5A) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/86.0.4240.99 Mobile Safari/537.36");
		});

		return builder.Build();
	}
}
