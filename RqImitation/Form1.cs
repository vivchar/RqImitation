using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RqImitation
{
    public partial class ImmitationForm : Form
    {
        public ImmitationForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateBeta();
            updateLambda();
            updateAlpha();
            updateGamma();
            updateStateCount();
        }

        private void betaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            updateBeta();
        }

        private void lambdeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            updateLambda();
        }

        private void alphaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            updateAlpha();
        }

        private void gammaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            updateGamma();
        }

        private void stateCountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            updateStateCount();
        }

        private void updateBeta()
        {
            betaValueLabel.Text = betaNumericUpDown.Value.ToString();
        }

        private void updateLambda()
        {
            lambdaValueLabel.Text = lambdaNumericUpDown.Value.ToString();
        }

        private void updateAlpha()
        {
            alphaValueLabel.Text = alphaNumericUpDown.Value.ToString();
        }

        private void updateGamma()
        {
            gammaValueLabel.Text = gammaNumericUpDown.Value.ToString();
        }

        private void updateStateCount()
        {
            stateCountValueLabel.Text = stateCountNumericUpDown.Value.ToString();
            updateMu1List();
            updateMu2List();
            updateQMatrix();
        }

        private void updateMu2List()
        {
            mu2FlowLayoutPanel.Controls.Clear();
            for (int i = 0; i < stateCountNumericUpDown.Value; i++)
            {
                mu2FlowLayoutPanel.Controls.Add(createNumericUpDown());
            }
        }
        private void updateMu1List()
        {
            mu1FlowLayoutPanel.Controls.Clear();
            for (int i = 0; i < stateCountNumericUpDown.Value; i++)
            {
                mu1FlowLayoutPanel.Controls.Add(createNumericUpDown());
            }
        }

        public void updateQMatrix() 
        {
            int stateCount = (int)stateCountNumericUpDown.Value;

            matrixQDataGridView.RowCount = stateCount;
            matrixQDataGridView.ColumnCount = stateCount;
            
            for (int i = 0; i < stateCount; i++) {
                matrixQDataGridView.Columns[i].Width = 50;
                var row = matrixQDataGridView.Rows[i];
                for (int j = 0; j < stateCount; j++)
                {
                    row.Cells[j].Value = 1;
                    if ( i == j) row.Cells[j].Value = -(stateCount - 1);
                }
            }
        }

        private NumericUpDown createNumericUpDown()
        {
            NumericUpDown nup = new NumericUpDown();
            nup.Width = 50;
            nup.Increment = 0.1M;
            nup.DecimalPlaces = 1;
            nup.Value = 0.2M;
            return nup;
        }

        private void startButton_Click(object sender, EventArgs e)
        {

        }
    }
}
