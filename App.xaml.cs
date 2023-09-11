using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace StartWithParms
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        void App_Startup(object sender, StartupEventArgs e)
        {
            // Application is running
            // Process command line args

            MainWindow mainWindow;

            if (e.Args.Length > 0)
            {
                mainWindow = new MainWindow(e.Args[0].ToString());
            }

            else
            {
                mainWindow = new MainWindow();
            }

            mainWindow.Show();

            //Поиск по параметрам с возможностью выбора дальнейших условий работы или прочего
            //bool startMinimized = false;
            //for (int i = 0; i != e.Args.Length; ++i)
            //{
            //    if (e.Args[i] == "/StartMinimized")
            //    {
            //        startMinimized = true;
            //    }
            //}

            //// Create main application window, starting minimized if specified
            //MainWindow mainWindow = new MainWindow();
            //if (startMinimized)
            //{
            //    mainWindow.WindowState = WindowState.Minimized;
            //}
            //mainWindow.Show();
        }
    }
}
