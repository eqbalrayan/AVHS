using System.Windows;

namespace AVMS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Window Buttons Events
            BtnMinimize.Click += BtnMinimize_Click;
            BtnMaximize.Click += BtnMaximize_Click;
            BtnClose.Click += BtnClose_Click;
        }

        // ================= MINIMIZE =================
        private void BtnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        // ================= MAXIMIZE / RESTORE =================
        private void BtnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;

                BtnMaximize.Content = "☐";
            }
            else
            {
                WindowState = WindowState.Maximized;

                BtnMaximize.Content = "❐";
            }
        }

        // ================= CLOSE =================
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}