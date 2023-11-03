using iMean.Tool.DailyNrjExpenditure.Bootstrap.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows;

namespace iMean.Tool.DailyNrjExpenditure.Wpf;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    private IHost _host;

    public App()
    {
        _host = CreateHostBuilder().Build();
        ServiceProvider = _host.Services;
    }

    public IServiceProvider ServiceProvider { get; }

    private void OnStartup(object sender, StartupEventArgs e)
    {
        var mainWindow = ServiceProvider.GetService<MainWindow>();
        mainWindow.Show();
    }

    private IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
        {
            services.AddDailyEnergyExpenditure();
            services.AddSingleton<MainWindow>();
        });
    }
}
