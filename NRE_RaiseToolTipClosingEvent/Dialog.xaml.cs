using System.Diagnostics;
using System.Windows;

namespace NRE_RaiseToolTipClosingEvent
{
    public partial class Dialog
    {
        public Dialog()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            OpenWeb("https://github.com/dotnet/wpf");
        }

        public void OpenWeb(string url)
        {
            url = url.Replace("&", "^&");
            Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") {CreateNoWindow = true});
        }
    }
}
