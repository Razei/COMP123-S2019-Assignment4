namespace COMP123_S2019_Assignment4
{
    partial class CalculatorForm
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
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.BMICalculatorTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BMICalculateButton = new System.Windows.Forms.Button();
            this.UnitGroupBox = new System.Windows.Forms.GroupBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.BMICalculatorTableLayoutPanel.SuspendLayout();
            this.UnitGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightLabel.BackColor = System.Drawing.Color.Transparent;
            this.BMICalculatorTableLayoutPanel.SetColumnSpan(this.HeightLabel, 2);
            this.HeightLabel.Location = new System.Drawing.Point(3, 165);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(273, 41);
            this.HeightLabel.TabIndex = 0;
            this.HeightLabel.Text = "My Height";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.AllowDrop = true;
            this.WeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightTextBox.BackColor = System.Drawing.Color.White;
            this.BMICalculatorTableLayoutPanel.SetColumnSpan(this.WeightTextBox, 2);
            this.WeightTextBox.Location = new System.Drawing.Point(3, 291);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.ReadOnly = true;
            this.WeightTextBox.Size = new System.Drawing.Size(273, 38);
            this.WeightTextBox.TabIndex = 1;
            this.WeightTextBox.Text = "0";
            this.WeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.WeightTextBox.Click += new System.EventHandler(this.TextBoxWeight_Click);
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightLabel.BackColor = System.Drawing.Color.Transparent;
            this.BMICalculatorTableLayoutPanel.SetColumnSpan(this.WeightLabel, 2);
            this.WeightLabel.Location = new System.Drawing.Point(3, 247);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(273, 41);
            this.WeightLabel.TabIndex = 0;
            this.WeightLabel.Text = "My Weight";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Location = new System.Drawing.Point(6, 60);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(106, 35);
            this.MetricRadioButton.TabIndex = 0;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            this.MetricRadioButton.CheckedChanged += new System.EventHandler(this.RadioButtonMetric_CheckedChanged);
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Checked = true;
            this.ImperialRadioButton.Location = new System.Drawing.Point(6, 19);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(128, 35);
            this.ImperialRadioButton.TabIndex = 0;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            this.ImperialRadioButton.CheckedChanged += new System.EventHandler(this.RadioButtonImperial_CheckedChanged);
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.AllowDrop = true;
            this.HeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightTextBox.BackColor = System.Drawing.Color.White;
            this.BMICalculatorTableLayoutPanel.SetColumnSpan(this.HeightTextBox, 2);
            this.HeightTextBox.Location = new System.Drawing.Point(3, 209);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.ReadOnly = true;
            this.HeightTextBox.Size = new System.Drawing.Size(273, 38);
            this.HeightTextBox.TabIndex = 1;
            this.HeightTextBox.Text = "0";
            this.HeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.HeightTextBox.Click += new System.EventHandler(this.TextBoxHeight_Click);
            // 
            // BMICalculatorTableLayoutPanel
            // 
            this.BMICalculatorTableLayoutPanel.ColumnCount = 2;
            this.BMICalculatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMICalculatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.WeightLabel, 0, 4);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.BMICalculateButton, 0, 6);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.UnitGroupBox, 0, 1);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.HeightLabel, 0, 2);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.HeightTextBox, 0, 3);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.WeightTextBox, 0, 5);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.ResultTextBox, 0, 0);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.ResetButton, 0, 7);
            this.BMICalculatorTableLayoutPanel.Location = new System.Drawing.Point(13, 13);
            this.BMICalculatorTableLayoutPanel.Name = "BMICalculatorTableLayoutPanel";
            this.BMICalculatorTableLayoutPanel.RowCount = 8;
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.BMICalculatorTableLayoutPanel.Size = new System.Drawing.Size(279, 416);
            this.BMICalculatorTableLayoutPanel.TabIndex = 2;
            // 
            // BMICalculateButton
            // 
            this.BMICalculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMICalculatorTableLayoutPanel.SetColumnSpan(this.BMICalculateButton, 2);
            this.BMICalculateButton.Location = new System.Drawing.Point(3, 332);
            this.BMICalculateButton.Name = "BMICalculateButton";
            this.BMICalculateButton.Size = new System.Drawing.Size(273, 35);
            this.BMICalculateButton.TabIndex = 4;
            this.BMICalculateButton.Text = "Calculate BMI";
            this.BMICalculateButton.UseVisualStyleBackColor = true;
            this.BMICalculateButton.Click += new System.EventHandler(this.BMICalculateButton_Click);
            // 
            // UnitGroupBox
            // 
            this.UnitGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMICalculatorTableLayoutPanel.SetColumnSpan(this.UnitGroupBox, 2);
            this.UnitGroupBox.Controls.Add(this.ImperialRadioButton);
            this.UnitGroupBox.Controls.Add(this.MetricRadioButton);
            this.UnitGroupBox.Location = new System.Drawing.Point(3, 44);
            this.UnitGroupBox.Name = "UnitGroupBox";
            this.UnitGroupBox.Size = new System.Drawing.Size(273, 118);
            this.UnitGroupBox.TabIndex = 2;
            this.UnitGroupBox.TabStop = false;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMICalculatorTableLayoutPanel.SetColumnSpan(this.ResultTextBox, 2);
            this.ResultTextBox.Location = new System.Drawing.Point(3, 3);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(273, 35);
            this.ResultTextBox.TabIndex = 3;
            this.ResultTextBox.Text = "0";
            this.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMICalculatorTableLayoutPanel.SetColumnSpan(this.ResetButton, 2);
            this.ResetButton.Location = new System.Drawing.Point(3, 373);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(273, 40);
            this.ResetButton.TabIndex = 4;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.BMICalculatorTableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.BMICalculatorTableLayoutPanel.ResumeLayout(false);
            this.BMICalculatorTableLayoutPanel.PerformLayout();
            this.UnitGroupBox.ResumeLayout(false);
            this.UnitGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TableLayoutPanel BMICalculatorTableLayoutPanel;
        private System.Windows.Forms.GroupBox UnitGroupBox;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button BMICalculateButton;
        private System.Windows.Forms.Button ResetButton;
    }
}

