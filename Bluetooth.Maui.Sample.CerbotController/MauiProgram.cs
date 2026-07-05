using Bluetooth.Maui.Sample.CerbotController.Services;
using Bluetooth.Maui.Sample.CerbotController.Views;
using Bluetooth.Maui.Sample.CerbotController.ViewModels;

using Microsoft.Maui;
using Microsoft.Maui.Hosting;

//using Microsoft.Extensions.Logging;

namespace Bluetooth.Maui.Sample.CerbotController;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts => {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif
        // Register Bluetooth services
        builder.Services.AddBluetoothServices();

        // Register app services
        builder.Services.AddSingleton<INavigationService, NavigationService>();

        // Register pages and view models
        builder.Services.AddTransient<ScannerPage>();
        builder.Services.AddTransient<ScannerViewModel>();

      //  builder.Services.AddTransient<DevicePage>();
      //  builder.Services.AddTransient<DeviceViewModel>();
       // builder.Services.AddTransient<CharacteristicsPage>();
      //  builder.Services.AddTransient<CharacteristicsViewModel>();
      //  builder.Services.AddTransient<CharacteristicDetailPage>();
      //  builder.Services.AddTransient<CharacteristicDetailViewModel>();
      //  builder.Services.AddTransient<WriteListenLabPage>();
       // builder.Services.AddTransient<WriteListenLabViewModel>();
      //  builder.Services.AddTransient<ClosestDeviceScanPage>();
      //  builder.Services.AddTransient<ClosestDeviceScanViewModel>();

        return builder.Build();
    }
}
