using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace FitnessClub
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            AvaloniaXamlLoader.Load(this);
            InitializeComponent();
            
        }
    }
}
