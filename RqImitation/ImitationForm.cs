using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RqImitation
{
    public partial class ImitationForm : Form
    {
        private static ListBox logsList;
        private static List<String> logs = new List<string>();

        public ImitationForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logsList = logsListBox;
            updateStateCount();
        }

        private void stateCountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            updateStateCount();
        }

        private void updateStateCount()
        {
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
                matrixQDataGridView.Columns[i].Width = 25;
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
            nup.Value = 0.8M; //дефолтное значение для мю списка
            return nup;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            double lambda = (double)lambdaNumericUpDown.Value;
            double beta = (double)betaNumericUpDown.Value;
            double alpha = (double)alphaNumericUpDown.Value;
            double gamma = (double)gammaNumericUpDown.Value;
            int stateCount = (int)stateCountNumericUpDown.Value;

            List<double> mu1List = getMu1List();
            List<double> mu2List = getMu2List();

            List<List<int>> matrixQ = getMatrixQ();

            var imitation = new ImitationModel(lambda, beta, alpha, gamma, mu1List, mu2List, matrixQ);
            imitation.start((int)eventsCountNumericUpDown.Value);
        }

        public static void Log(string message) {
            //Debug.WriteLine(message);
            logs.Add(message);
        }

        public static void Start() {
            logsList.DataSource = null;
            logs.Clear();
            logsList.Items.Clear();
            logsList.BeginUpdate();
        }

        public static void Stop() {
            logsList.DataSource = logs;
            logsList.EndUpdate();   
            logsList.SelectedIndex = logsList.Items.Count - 1;
        }

        public List<double> getMu1List()
        {
            List<double> list = new List<double>();
            foreach (NumericUpDown c in mu1FlowLayoutPanel.Controls)
            {
                list.Add((double)c.Value);
            }

            return list;
        }

        public List<double> getMu2List()
        {
            List<double> list = new List<double>();
            foreach (NumericUpDown c in mu2FlowLayoutPanel.Controls)
            {
                list.Add((double)c.Value);
            }

            return list;
        }

        public List<List<int>> getMatrixQ() {
            List<List<int>> matrix = new List<List<int>>(); 

            int stateCount = matrixQDataGridView.RowCount;

            for (int rowIndex = 0; rowIndex < stateCount; rowIndex++)
            {
                var rowView = matrixQDataGridView.Rows[rowIndex];
             
                List<int> list = new List<int>();
                for (int columnIndex = 0; columnIndex < stateCount; columnIndex++)
                {
                    list.Add(int.Parse(rowView.Cells[columnIndex].Value.ToString()));
                }
                matrix.Add(list);
            }


            return matrix;
        }
    }
}
