using System.Reflection;
using System.Windows;

namespace DemoWpfApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        var version = Assembly.GetExecutingAssembly()
                               .GetName()
                               .Version;
        VersionText.Text = $"Version {version}";
    }
}
