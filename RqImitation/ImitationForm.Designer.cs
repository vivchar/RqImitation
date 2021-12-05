namespace RqImitation
{
    partial class ImmitationForm
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
            this.betaDescriptionLabel = new System.Windows.Forms.Label();
            this.betaValueLabel = new System.Windows.Forms.Label();
            this.lambdaDescriptionLabel = new System.Windows.Forms.Label();
            this.lambdaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lambdaValueLabel = new System.Windows.Forms.Label();
            this.alphaDescriptionLabel = new System.Windows.Forms.Label();
            this.alphaValueLabel = new System.Windows.Forms.Label();
            this.alphaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gammaDescriptionLabel = new System.Windows.Forms.Label();
            this.gammaValueLabel = new System.Windows.Forms.Label();
            this.gammaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.stateCountDescriptionLabel = new System.Windows.Forms.Label();
            this.stateCountValueLabel = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.lambdaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gammaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixQDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // betaDescriptionLabel
            // 
            this.betaDescriptionLabel.AutoSize = true;
            this.betaDescriptionLabel.Location = new System.Drawing.Point(12, 49);
            this.betaDescriptionLabel.Name = "betaDescriptionLabel";
            this.betaDescriptionLabel.Size = new System.Drawing.Size(230, 13);
            this.betaDescriptionLabel.TabIndex = 1;
            this.betaDescriptionLabel.Text = "β - вероятность перехода заявки на орбиту:";
            // 
            // betaValueLabel
            // 
            this.betaValueLabel.AutoSize = true;
            this.betaValueLabel.Location = new System.Drawing.Point(248, 49);
            this.betaValueLabel.Name = "betaValueLabel";
            this.betaValueLabel.Size = new System.Drawing.Size(22, 13);
            this.betaValueLabel.TabIndex = 2;
            this.betaValueLabel.Text = "0.0";
            // 
            // lambdaDescriptionLabel
            // 
            this.lambdaDescriptionLabel.AutoSize = true;
            this.lambdaDescriptionLabel.Location = new System.Drawing.Point(12, 9);
            this.lambdaDescriptionLabel.Name = "lambdaDescriptionLabel";
            this.lambdaDescriptionLabel.Size = new System.Drawing.Size(199, 13);
            this.lambdaDescriptionLabel.TabIndex = 4;
            this.lambdaDescriptionLabel.Text = "λ - параметр пуассоновского потока: ";
            // 
            // lambdaNumericUpDown
            // 
            this.lambdaNumericUpDown.DecimalPlaces = 1;
            this.lambdaNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.lambdaNumericUpDown.Location = new System.Drawing.Point(285, 7);
            this.lambdaNumericUpDown.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.lambdaNumericUpDown.Name = "lambdaNumericUpDown";
            this.lambdaNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.lambdaNumericUpDown.TabIndex = 1;
            this.lambdaNumericUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            this.lambdaNumericUpDown.ValueChanged += new System.EventHandler(this.lambdeNumericUpDown_ValueChanged);
            // 
            // lambdaValueLabel
            // 
            this.lambdaValueLabel.AutoSize = true;
            this.lambdaValueLabel.Location = new System.Drawing.Point(248, 9);
            this.lambdaValueLabel.Name = "lambdaValueLabel";
            this.lambdaValueLabel.Size = new System.Drawing.Size(22, 13);
            this.lambdaValueLabel.TabIndex = 5;
            this.lambdaValueLabel.Text = "0.0";
            // 
            // alphaDescriptionLabel
            // 
            this.alphaDescriptionLabel.AutoSize = true;
            this.alphaDescriptionLabel.Location = new System.Drawing.Point(12, 81);
            this.alphaDescriptionLabel.Name = "alphaDescriptionLabel";
            this.alphaDescriptionLabel.Size = new System.Drawing.Size(184, 13);
            this.alphaDescriptionLabel.TabIndex = 6;
            this.alphaDescriptionLabel.Text = "α - интенсивность внешней среды:";
            // 
            // alphaValueLabel
            // 
            this.alphaValueLabel.AutoSize = true;
            this.alphaValueLabel.Location = new System.Drawing.Point(248, 81);
            this.alphaValueLabel.Name = "alphaValueLabel";
            this.alphaValueLabel.Size = new System.Drawing.Size(22, 13);
            this.alphaValueLabel.TabIndex = 7;
            this.alphaValueLabel.Text = "0.0";
            // 
            // alphaNumericUpDown
            // 
            this.alphaNumericUpDown.DecimalPlaces = 1;
            this.alphaNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.alphaNumericUpDown.Location = new System.Drawing.Point(285, 79);
            this.alphaNumericUpDown.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.alphaNumericUpDown.Name = "alphaNumericUpDown";
            this.alphaNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.alphaNumericUpDown.TabIndex = 8;
            this.alphaNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            this.alphaNumericUpDown.ValueChanged += new System.EventHandler(this.alphaNumericUpDown_ValueChanged);
            // 
            // gammaDescriptionLabel
            // 
            this.gammaDescriptionLabel.AutoSize = true;
            this.gammaDescriptionLabel.Location = new System.Drawing.Point(12, 118);
            this.gammaDescriptionLabel.Name = "gammaDescriptionLabel";
            this.gammaDescriptionLabel.Size = new System.Drawing.Size(173, 13);
            this.gammaDescriptionLabel.TabIndex = 9;
            this.gammaDescriptionLabel.Text = "γ - параметр э/р задержки ИПВ:";
            // 
            // gammaValueLabel
            // 
            this.gammaValueLabel.AutoSize = true;
            this.gammaValueLabel.Location = new System.Drawing.Point(248, 118);
            this.gammaValueLabel.Name = "gammaValueLabel";
            this.gammaValueLabel.Size = new System.Drawing.Size(22, 13);
            this.gammaValueLabel.TabIndex = 10;
            this.gammaValueLabel.Text = "0.0";
            // 
            // gammaNumericUpDown
            // 
            this.gammaNumericUpDown.DecimalPlaces = 1;
            this.gammaNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.gammaNumericUpDown.Location = new System.Drawing.Point(285, 116);
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
            this.gammaNumericUpDown.ValueChanged += new System.EventHandler(this.gammaNumericUpDown_ValueChanged);
            // 
            // stateCountDescriptionLabel
            // 
            this.stateCountDescriptionLabel.AutoSize = true;
            this.stateCountDescriptionLabel.Location = new System.Drawing.Point(12, 155);
            this.stateCountDescriptionLabel.Name = "stateCountDescriptionLabel";
            this.stateCountDescriptionLabel.Size = new System.Drawing.Size(230, 13);
            this.stateCountDescriptionLabel.TabIndex = 12;
            this.stateCountDescriptionLabel.Text = "S - количество состояний случайной среды:";
            // 
            // stateCountValueLabel
            // 
            this.stateCountValueLabel.AutoSize = true;
            this.stateCountValueLabel.Location = new System.Drawing.Point(248, 155);
            this.stateCountValueLabel.Name = "stateCountValueLabel";
            this.stateCountValueLabel.Size = new System.Drawing.Size(13, 13);
            this.stateCountValueLabel.TabIndex = 13;
            this.stateCountValueLabel.Text = "0";
            // 
            // stateCountNumericUpDown
            // 
            this.stateCountNumericUpDown.Location = new System.Drawing.Point(285, 153);
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
            this.mu1DescriptionLabel.Location = new System.Drawing.Point(12, 190);
            this.mu1DescriptionLabel.Name = "mu1DescriptionLabel";
            this.mu1DescriptionLabel.Size = new System.Drawing.Size(288, 13);
            this.mu1DescriptionLabel.TabIndex = 15;
            this.mu1DescriptionLabel.Text = "μ1 - параметр э/р длительности обслуживания заявки:";
            // 
            // mu2DescriptionLabel
            // 
            this.mu2DescriptionLabel.AutoSize = true;
            this.mu2DescriptionLabel.Location = new System.Drawing.Point(12, 230);
            this.mu2DescriptionLabel.Name = "mu2DescriptionLabel";
            this.mu2DescriptionLabel.Size = new System.Drawing.Size(288, 13);
            this.mu2DescriptionLabel.TabIndex = 16;
            this.mu2DescriptionLabel.Text = "μ2 - параметр э/р длительности обслуживания заявки:";
            // 
            // mu2FlowLayoutPanel
            // 
            this.mu2FlowLayoutPanel.Location = new System.Drawing.Point(306, 225);
            this.mu2FlowLayoutPanel.Name = "mu2FlowLayoutPanel";
            this.mu2FlowLayoutPanel.Size = new System.Drawing.Size(599, 26);
            this.mu2FlowLayoutPanel.TabIndex = 17;
            this.mu2FlowLayoutPanel.WrapContents = false;
            // 
            // mu1FlowLayoutPanel
            // 
            this.mu1FlowLayoutPanel.Location = new System.Drawing.Point(306, 185);
            this.mu1FlowLayoutPanel.Name = "mu1FlowLayoutPanel";
            this.mu1FlowLayoutPanel.Size = new System.Drawing.Size(599, 26);
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
            this.betaNumericUpDown.Location = new System.Drawing.Point(285, 47);
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
            this.betaNumericUpDown.ValueChanged += new System.EventHandler(this.betaNumericUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 266);
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
            this.matrixQDataGridView.Location = new System.Drawing.Point(306, 266);
            this.matrixQDataGridView.Name = "matrixQDataGridView";
            this.matrixQDataGridView.RowHeadersVisible = false;
            this.matrixQDataGridView.Size = new System.Drawing.Size(599, 424);
            this.matrixQDataGridView.TabIndex = 22;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(15, 303);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(103, 38);
            this.startButton.TabIndex = 23;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // logsListBox
            // 
            this.logsListBox.FormattingEnabled = true;
            this.logsListBox.Location = new System.Drawing.Point(411, 7);
            this.logsListBox.Name = "logsListBox";
            this.logsListBox.Size = new System.Drawing.Size(560, 160);
            this.logsListBox.TabIndex = 25;
            // 
            // ImmitationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 723);
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
            this.Controls.Add(this.stateCountValueLabel);
            this.Controls.Add(this.stateCountDescriptionLabel);
            this.Controls.Add(this.gammaNumericUpDown);
            this.Controls.Add(this.gammaValueLabel);
            this.Controls.Add(this.gammaDescriptionLabel);
            this.Controls.Add(this.alphaNumericUpDown);
            this.Controls.Add(this.alphaValueLabel);
            this.Controls.Add(this.alphaDescriptionLabel);
            this.Controls.Add(this.lambdaValueLabel);
            this.Controls.Add(this.lambdaNumericUpDown);
            this.Controls.Add(this.lambdaDescriptionLabel);
            this.Controls.Add(this.betaValueLabel);
            this.Controls.Add(this.betaDescriptionLabel);
            this.Name = "ImmitationForm";
            this.Text = "RQ System Immitation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lambdaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gammaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixQDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label betaDescriptionLabel;
        private System.Windows.Forms.Label betaValueLabel;
        private System.Windows.Forms.Label lambdaDescriptionLabel;
        private System.Windows.Forms.NumericUpDown lambdaNumericUpDown;
        private System.Windows.Forms.Label lambdaValueLabel;
        private System.Windows.Forms.Label alphaDescriptionLabel;
        private System.Windows.Forms.Label alphaValueLabel;
        private System.Windows.Forms.NumericUpDown alphaNumericUpDown;
        private System.Windows.Forms.Label gammaDescriptionLabel;
        private System.Windows.Forms.Label gammaValueLabel;
        private System.Windows.Forms.NumericUpDown gammaNumericUpDown;
        private System.Windows.Forms.Label stateCountDescriptionLabel;
        private System.Windows.Forms.Label stateCountValueLabel;
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
    }
}

