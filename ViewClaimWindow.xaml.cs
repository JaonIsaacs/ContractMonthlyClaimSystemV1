using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ContractMonthlyClaimSystem
{
    public partial class ViewClaimWindow : Window
    {
        public ViewClaimWindow()
        {
            InitializeComponent();

            // Simulate loading claims. Replace this with actual data loading logic.
            LoadClaims();
        }

        private void LoadClaims()
        {
            // Simulated list of claims. Replace with data fetching logic.
            var claims = new string[]
            {
                "Claim 1: Damaged goods - 2024-08-01",
                "Claim 2: Late delivery - 2024-08-15",
                "Claim 3: Incorrect item - 2024-09-03"
            };

            foreach (var claim in claims)
            {
                ClaimsListBox.Items.Add(claim);
            }
        }

        private void ApproveButton_Click(object sender, RoutedEventArgs e)
        {
            if (ClaimsListBox.SelectedItem != null)
            {
                string selectedClaim = ClaimsListBox.SelectedItem.ToString();
                MessageBox.Show($"Approved: {selectedClaim}", "Claim Approved", MessageBoxButton.OK, MessageBoxImage.Information);
                // Add logic here to handle claim approval (e.g., updating a database, changing status)
            }
            else
            {
                MessageBox.Show("Please select a claim to approve.", "No Claim Selected", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void DeclineButton_Click(object sender, RoutedEventArgs e)
        {
            if (ClaimsListBox.SelectedItem != null)
            {
                string selectedClaim = ClaimsListBox.SelectedItem.ToString();
                MessageBox.Show($"Declined: {selectedClaim}", "Claim Declined", MessageBoxButton.OK, MessageBoxImage.Information);
                // Add logic here to handle claim declination (e.g., updating a database, changing status)
            }
            else
            {
                MessageBox.Show("Please select a claim to decline.", "No Claim Selected", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
