using System.Windows;

namespace NRE_RaiseToolTipClosingEvent
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var dialog = new Dialog();

            dialog.Owner = this;

            dialog.ShowDialog();
        }
    }
}
