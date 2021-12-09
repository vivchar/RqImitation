namespace RqImitation
{
    partial class ImitationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.betaDescriptionLabel = new System.Windows.Forms.Label();
            this.lambdaDescriptionLabel = new System.Windows.Forms.Label();
            this.lambdaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.alphaDescriptionLabel = new System.Windows.Forms.Label();
            this.alphaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gammaDescriptionLabel = new System.Windows.Forms.Label();
            this.gammaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.stateCountDescriptionLabel = new System.Windows.Forms.Label();
            this.stateCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.mu1DescriptionLabel = new System.Windows.Forms.Label();
            this.mu2DescriptionLabel = new System.Windows.Forms.Label();
            this.mu2FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mu1FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.betaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.matrixQDataGridView = new System.Windows.Forms.DataGridView();
            this.startButton = new System.Windows.Forms.Button();
            this.logsListBox = new System.Windows.Forms.ListBox();
            this.eventsCountLabel = new System.Windows.Forms.Label();
            this.eventsCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.statisticsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.lambdaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gammaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixQDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // betaDescriptionLabel
            // 
            this.betaDescriptionLabel.AutoSize = true;
            this.betaDescriptionLabel.Location = new System.Drawing.Point(12, 82);
            this.betaDescriptionLabel.Name = "betaDescriptionLabel";
            this.betaDescriptionLabel.Size = new System.Drawing.Size(230, 13);
            this.betaDescriptionLabel.TabIndex = 1;
            this.betaDescriptionLabel.Text = "β - вероятность перехода заявки на орбиту:";
            // 
            // lambdaDescriptionLabel
            // 
            this.lambdaDescriptionLabel.AutoSize = true;
            this.lambdaDescriptionLabel.Location = new System.Drawing.Point(12, 9);
            this.lambdaDescriptionLabel.Name = "lambdaDescriptionLabel";
            this.lambdaDescriptionLabel.Size = new System.Drawing.Size(202, 13);
            this.lambdaDescriptionLabel.TabIndex = 4;
            this.lambdaDescriptionLabel.Text = "λ - интенсивносить входящего потока:";
            // 
            // lambdaNumericUpDown
            // 
            this.lambdaNumericUpDown.DecimalPlaces = 1;
            this.lambdaNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.lambdaNumericUpDown.Location = new System.Drawing.Point(255, 7);
            this.lambdaNumericUpDown.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.lambdaNumericUpDown.Name = "lambdaNumericUpDown";
            this.lambdaNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.lambdaNumericUpDown.TabIndex = 1;
            this.lambdaNumericUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            65536});
            // 
            // alphaDescriptionLabel
            // 
            this.alphaDescriptionLabel.AutoSize = true;
            this.alphaDescriptionLabel.Location = new System.Drawing.Point(12, 45);
            this.alphaDescriptionLabel.Name = "alphaDescriptionLabel";
            this.alphaDescriptionLabel.Size = new System.Drawing.Size(184, 13);
            this.alphaDescriptionLabel.TabIndex = 6;
            this.alphaDescriptionLabel.Text = "α - интенсивность внешней среды:";
            // 
            // alphaNumericUpDown
            // 
            this.alphaNumericUpDown.DecimalPlaces = 1;
            this.alphaNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.alphaNumericUpDown.Location = new System.Drawing.Point(255, 43);
            this.alphaNumericUpDown.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.alphaNumericUpDown.Name = "alphaNumericUpDown";
            this.alphaNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.alphaNumericUpDown.TabIndex = 8;
            this.alphaNumericUpDown.Value = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            // 
            // gammaDescriptionLabel
            // 
            this.gammaDescriptionLabel.AutoSize = true;
            this.gammaDescriptionLabel.Location = new System.Drawing.Point(12, 120);
            this.gammaDescriptionLabel.Name = "gammaDescriptionLabel";
            this.gammaDescriptionLabel.Size = new System.Drawing.Size(173, 13);
            this.gammaDescriptionLabel.TabIndex = 9;
            this.gammaDescriptionLabel.Text = "γ - параметр э/р задержки ИПВ:";
            // 
            // gammaNumericUpDown
            // 
            this.gammaNumericUpDown.DecimalPlaces = 1;
            this.gammaNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.gammaNumericUpDown.Location = new System.Drawing.Point(255, 118);
            this.gammaNumericUpDown.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.gammaNumericUpDown.Name = "gammaNumericUpDown";
            this.gammaNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.gammaNumericUpDown.TabIndex = 11;
            this.gammaNumericUpDown.Value = new decimal(new int[] {
            6,
            0,
            0,
            65536});
            // 
            // stateCountDescriptionLabel
            // 
            this.stateCountDescriptionLabel.AutoSize = true;
            this.stateCountDescriptionLabel.Location = new System.Drawing.Point(12, 157);
            this.stateCountDescriptionLabel.Name = "stateCountDescriptionLabel";
            this.stateCountDescriptionLabel.Size = new System.Drawing.Size(230, 13);
            this.stateCountDescriptionLabel.TabIndex = 12;
            this.stateCountDescriptionLabel.Text = "S - количество состояний случайной среды:";
            // 
            // stateCountNumericUpDown
            // 
            this.stateCountNumericUpDown.Location = new System.Drawing.Point(255, 155);
            this.stateCountNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.stateCountNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.stateCountNumericUpDown.Name = "stateCountNumericUpDown";
            this.stateCountNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.stateCountNumericUpDown.TabIndex = 14;
            this.stateCountNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.stateCountNumericUpDown.ValueChanged += new System.EventHandler(this.stateCountNumericUpDown_ValueChanged);
            // 
            // mu1DescriptionLabel
            // 
            this.mu1DescriptionLabel.AutoSize = true;
            this.mu1DescriptionLabel.Location = new System.Drawing.Point(12, 233);
            this.mu1DescriptionLabel.Name = "mu1DescriptionLabel";
            this.mu1DescriptionLabel.Size = new System.Drawing.Size(305, 13);
            this.mu1DescriptionLabel.TabIndex = 15;
            this.mu1DescriptionLabel.Text = "μ1 - параметр э/р длительности обслуживания вх. заявки:";
            // 
            // mu2DescriptionLabel
            // 
            this.mu2DescriptionLabel.AutoSize = true;
            this.mu2DescriptionLabel.Location = new System.Drawing.Point(12, 273);
            this.mu2DescriptionLabel.Name = "mu2DescriptionLabel";
            this.mu2DescriptionLabel.Size = new System.Drawing.Size(314, 13);
            this.mu2DescriptionLabel.TabIndex = 16;
            this.mu2DescriptionLabel.Text = "μ2 - параметр э/р длительности обслуживания выз. заявки:";
            // 
            // mu2FlowLayoutPanel
            // 
            this.mu2FlowLayoutPanel.Location = new System.Drawing.Point(334, 268);
            this.mu2FlowLayoutPanel.Name = "mu2FlowLayoutPanel";
            this.mu2FlowLayoutPanel.Size = new System.Drawing.Size(637, 26);
            this.mu2FlowLayoutPanel.TabIndex = 17;
            this.mu2FlowLayoutPanel.WrapContents = false;
            // 
            // mu1FlowLayoutPanel
            // 
            this.mu1FlowLayoutPanel.Location = new System.Drawing.Point(334, 228);
            this.mu1FlowLayoutPanel.Name = "mu1FlowLayoutPanel";
            this.mu1FlowLayoutPanel.Size = new System.Drawing.Size(637, 26);
            this.mu1FlowLayoutPanel.TabIndex = 18;
            this.mu1FlowLayoutPanel.WrapContents = false;
            // 
            // betaNumericUpDown
            // 
            this.betaNumericUpDown.DecimalPlaces = 1;
            this.betaNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.betaNumericUpDown.Location = new System.Drawing.Point(255, 80);
            this.betaNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.betaNumericUpDown.Name = "betaNumericUpDown";
            this.betaNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.betaNumericUpDown.TabIndex = 19;
            this.betaNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Q - матрица переходов:";
            // 
            // matrixQDataGridView
            // 
            this.matrixQDataGridView.AllowUserToAddRows = false;
            this.matrixQDataGridView.AllowUserToDeleteRows = false;
            this.matrixQDataGridView.AllowUserToResizeColumns = false;
            this.matrixQDataGridView.AllowUserToResizeRows = false;
            this.matrixQDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.matrixQDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matrixQDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixQDataGridView.ColumnHeadersVisible = false;
            this.matrixQDataGridView.Location = new System.Drawing.Point(523, 7);
            this.matrixQDataGridView.Name = "matrixQDataGridView";
            this.matrixQDataGridView.RowHeadersVisible = false;
            this.matrixQDataGridView.Size = new System.Drawing.Size(454, 223);
            this.matrixQDataGridView.TabIndex = 22;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(47, 337);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(179, 38);
            this.startButton.TabIndex = 23;
            this.startButton.Text = "START SIMULATION";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // logsListBox
            // 
            this.logsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logsListBox.FormattingEnabled = true;
            this.logsListBox.Location = new System.Drawing.Point(264, 300);
            this.logsListBox.Name = "logsListBox";
            this.logsListBox.Size = new System.Drawing.Size(707, 134);
            this.logsListBox.TabIndex = 25;
            // 
            // eventsCountLabel
            // 
            this.eventsCountLabel.AutoSize = true;
            this.eventsCountLabel.Location = new System.Drawing.Point(12, 195);
            this.eventsCountLabel.Name = "eventsCountLabel";
            this.eventsCountLabel.Size = new System.Drawing.Size(115, 13);
            this.eventsCountLabel.TabIndex = 26;
            this.eventsCountLabel.Text = "Количество событий:";
            // 
            // eventsCountNumericUpDown
            // 
            this.eventsCountNumericUpDown.Location = new System.Drawing.Point(255, 193);
            this.eventsCountNumericUpDown.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.eventsCountNumericUpDown.Name = "eventsCountNumericUpDown";
            this.eventsCountNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.eventsCountNumericUpDown.TabIndex = 27;
            this.eventsCountNumericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // statisticsChart
            // 
            this.statisticsChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.statisticsChart.ChartAreas.Add(chartArea2);
            this.statisticsChart.Location = new System.Drawing.Point(15, 443);
            this.statisticsChart.Name = "statisticsChart";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series4";
            this.statisticsChart.Series.Add(series2);
            this.statisticsChart.Size = new System.Drawing.Size(956, 311);
            this.statisticsChart.TabIndex = 28;
            this.statisticsChart.Text = "Статистика";
            title2.Name = "Title1ываыва";
            this.statisticsChart.Titles.Add(title2);
            // 
            // ImitationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 766);
            this.Controls.Add(this.statisticsChart);
            this.Controls.Add(this.eventsCountNumericUpDown);
            this.Controls.Add(this.eventsCountLabel);
            this.Controls.Add(this.logsListBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.matrixQDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.betaNumericUpDown);
            this.Controls.Add(this.mu1FlowLayoutPanel);
            this.Controls.Add(this.mu2FlowLayoutPanel);
            this.Controls.Add(this.mu2DescriptionLabel);
            this.Controls.Add(this.mu1DescriptionLabel);
            this.Controls.Add(this.stateCountNumericUpDown);
            this.Controls.Add(this.stateCountDescriptionLabel);
            this.Controls.Add(this.gammaNumericUpDown);
            this.Controls.Add(this.gammaDescriptionLabel);
            this.Controls.Add(this.alphaNumericUpDown);
            this.Controls.Add(this.alphaDescriptionLabel);
            this.Controls.Add(this.lambdaNumericUpDown);
            this.Controls.Add(this.lambdaDescriptionLabel);
            this.Controls.Add(this.betaDescriptionLabel);
            this.Name = "ImitationForm";
            this.Text = "RQ System Immitation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lambdaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gammaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixQDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label betaDescriptionLabel;
        private System.Windows.Forms.Label lambdaDescriptionLabel;
        private System.Windows.Forms.NumericUpDown lambdaNumericUpDown;
        private System.Windows.Forms.Label alphaDescriptionLabel;
        private System.Windows.Forms.NumericUpDown alphaNumericUpDown;
        private System.Windows.Forms.Label gammaDescriptionLabel;
        private System.Windows.Forms.NumericUpDown gammaNumericUpDown;
        private System.Windows.Forms.Label stateCountDescriptionLabel;
        private System.Windows.Forms.NumericUpDown stateCountNumericUpDown;
        private System.Windows.Forms.Label mu1DescriptionLabel;
        private System.Windows.Forms.Label mu2DescriptionLabel;
        private System.Windows.Forms.FlowLayoutPanel mu2FlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel mu1FlowLayoutPanel;
        private System.Windows.Forms.NumericUpDown betaNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView matrixQDataGridView;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ListBox logsListBox;
        private System.Windows.Forms.Label eventsCountLabel;
        private System.Windows.Forms.NumericUpDown eventsCountNumericUpDown;
        private System.Windows.Forms.DataVisualization.Charting.Chart statisticsChart;
    }
}

