using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using WPF.Lotto.Services;

namespace WPF.Lotto
{
    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;

        public App()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            _serviceProvider = serviceCollection.BuildServiceProvider();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<ITextService>(provider => new TextService("Hi WPF .NET Core 5.0"));
            services.AddSingleton<MainWindow>();
            services.AddSingleton<MainWindowViewModel>();
        }


        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var main = _serviceProvider.GetRequiredService<MainWindow>();
            main.Show();
        }
    }
}