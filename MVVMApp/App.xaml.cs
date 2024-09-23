using MVVMApp.Views;
using System;
using System.IO;
using System.Reflection;
using System.Windows;

namespace MVVMApp
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "MVVMApp。Views。MainWindow。xaml";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                //if (stream == null)
                //{
                //    throw new IOException($"Resource '{resourceName}' not found.");
                //}
                // Resource found, proceed with application startup
                var mainWindow = new MainWindow();
                mainWindow.Show();
            }
        }
    }
}
