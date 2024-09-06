using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ContractMonthlyClaimSystem
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SubmitClaimButton_Click(object sender, RoutedEventArgs e)
        {
            // Logic to open a new window for submitting a claim
            SubmitClaimWindow submitClaimWindow = new SubmitClaimWindow();
            submitClaimWindow.Show();
        }

        private void ViewClaimButton_Click(object sender, RoutedEventArgs e)
        {
            // Logic to open a new window for viewing a claim
            ViewClaimWindow viewClaimWindow = new ViewClaimWindow();
            viewClaimWindow.Show();
        }
    }
}