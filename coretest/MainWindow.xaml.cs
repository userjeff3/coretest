using System.Windows;

namespace coretest {

   public partial class MainWindow: Window {
      public MainWindow() {
         InitializeComponent();
      }

      private void close_Click(object sender, RoutedEventArgs e) {
         Application.Current.Shutdown();
      }
   }
}
