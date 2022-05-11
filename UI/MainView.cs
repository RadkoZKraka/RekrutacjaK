using System;
using System.Windows.Forms;
using RekrutacjaK.Controller;
using RekrutacjaK.Data;

namespace RekrutacjaK
{
    public partial class MainView : UserControl
    {
        public MainPanelController _mainPanelController;
        
        public MainView()
        {
            InitializeComponent();
            DataWrapper dataWrapper = new DataWrapper(this);
            _mainPanelController = new MainPanelController(dataWrapper);
            
            // 
        }

        public void productTable_Navigate(object sender, NavigateEventArgs ne)
        {
            
        }

        public void simulateButton_Click(object sender, EventArgs e)
        {
            int number = 0;
            try
            {
                number = Convert.ToInt32(numberOfProducts.Text);
            }
            catch (Exception ex)
            {
                
            }
            var lastThreeDays = this.lastThreeDays.Checked;
            var startDate = this.startDate.Value;
            var endDate = this.endDate.Value;
            
            if ((endDate - startDate).Days < 0)
            {
                MessageBox.Show("Data startu nie może być większa od zakończenia! Zmień daty.");
                
                return;
            }
            _mainPanelController.SimulateData(number, lastThreeDays, startDate, endDate);
            
            

        }
        
        public void lastThreeDays_CheckedChanged(object sender, EventArgs e)
        {
           
            if (lastThreeDays.Checked)
            {
                startDate.Enabled = false;
                endDate.Enabled = false;
            }
            else
            {
                startDate.Enabled = true;
                endDate.Enabled = false;
            }

        }

        public void startDate_ValueChanged(object sender, EventArgs e)
        {

        }

        public void productGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void clearTable_Click(object sender, EventArgs e)
        {
            productGridView.Rows.Clear();
        }

        private void endDate_ValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}