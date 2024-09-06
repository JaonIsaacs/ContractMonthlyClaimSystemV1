using Microsoft.Win32;
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
    public partial class SubmitClaimWindow : Window
    {
        public SubmitClaimWindow()
        {
            InitializeComponent();
        }

        private void BrowseDocumentButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                // Handle document upload logic here
                MessageBox.Show($"Document selected: {openFileDialog.FileName}");
            }
        }

        private void SubmitClaimButton_Click(object sender, RoutedEventArgs e)
        {
            string claimDetails = ClaimDetailsTextBox.Text;

            // Handle claim submission logic here
            MessageBox.Show("Claim submitted!");

            // Clear input fields after submission
            ClaimDetailsTextBox.Clear();
        }
    }
}
