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
            this.TextBoxWeight = new System.Windows.Forms.TextBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.RadioButtonMetric = new System.Windows.Forms.RadioButton();
            this.RadioButtonImperial = new System.Windows.Forms.RadioButton();
            this.TextBoxHeight = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.UnitGroupBox = new System.Windows.Forms.GroupBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.UnitGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightLabel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.HeightLabel, 2);
            this.HeightLabel.Location = new System.Drawing.Point(3, 189);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(273, 45);
            this.HeightLabel.TabIndex = 0;
            this.HeightLabel.Text = "My Height";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxWeight
            // 
            this.TextBoxWeight.AllowDrop = true;
            this.TextBoxWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.TextBoxWeight, 2);
            this.TextBoxWeight.Location = new System.Drawing.Point(3, 327);
            this.TextBoxWeight.Name = "TextBoxWeight";
            this.TextBoxWeight.Size = new System.Drawing.Size(273, 38);
            this.TextBoxWeight.TabIndex = 1;
            this.TextBoxWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxWeight.Click += new System.EventHandler(this.TextBoxWeight_Click);
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightLabel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.WeightLabel, 2);
            this.WeightLabel.Location = new System.Drawing.Point(3, 279);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(273, 45);
            this.WeightLabel.TabIndex = 0;
            this.WeightLabel.Text = "My Weight";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RadioButtonMetric
            // 
            this.RadioButtonMetric.AutoSize = true;
            this.RadioButtonMetric.Location = new System.Drawing.Point(6, 60);
            this.RadioButtonMetric.Name = "RadioButtonMetric";
            this.RadioButtonMetric.Size = new System.Drawing.Size(106, 35);
            this.RadioButtonMetric.TabIndex = 0;
            this.RadioButtonMetric.Text = "Metric";
            this.RadioButtonMetric.UseVisualStyleBackColor = true;
            this.RadioButtonMetric.CheckedChanged += new System.EventHandler(this.RadioButtonMetric_CheckedChanged);
            // 
            // RadioButtonImperial
            // 
            this.RadioButtonImperial.AutoSize = true;
            this.RadioButtonImperial.Checked = true;
            this.RadioButtonImperial.Location = new System.Drawing.Point(6, 19);
            this.RadioButtonImperial.Name = "RadioButtonImperial";
            this.RadioButtonImperial.Size = new System.Drawing.Size(128, 35);
            this.RadioButtonImperial.TabIndex = 0;
            this.RadioButtonImperial.TabStop = true;
            this.RadioButtonImperial.Text = "Imperial";
            this.RadioButtonImperial.UseVisualStyleBackColor = true;
            this.RadioButtonImperial.CheckedChanged += new System.EventHandler(this.RadioButtonImperial_CheckedChanged);
            // 
            // TextBoxHeight
            // 
            this.TextBoxHeight.AllowDrop = true;
            this.TextBoxHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.TextBoxHeight, 2);
            this.TextBoxHeight.Location = new System.Drawing.Point(3, 237);
            this.TextBoxHeight.Name = "TextBoxHeight";
            this.TextBoxHeight.Size = new System.Drawing.Size(273, 38);
            this.TextBoxHeight.TabIndex = 1;
            this.TextBoxHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxHeight.Click += new System.EventHandler(this.TextBoxHeight_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.WeightLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.UnitGroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ResultTextBox, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.HeightLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxHeight, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxWeight, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.90909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.90909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.90909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.90909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.90909F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(279, 416);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // UnitGroupBox
            // 
            this.UnitGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.UnitGroupBox, 2);
            this.UnitGroupBox.Controls.Add(this.RadioButtonImperial);
            this.UnitGroupBox.Controls.Add(this.RadioButtonMetric);
            this.UnitGroupBox.Location = new System.Drawing.Point(3, 3);
            this.UnitGroupBox.Name = "UnitGroupBox";
            this.UnitGroupBox.Size = new System.Drawing.Size(273, 183);
            this.UnitGroupBox.TabIndex = 2;
            this.UnitGroupBox.TabStop = false;
            // 
            // ResultTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ResultTextBox, 2);
            this.ResultTextBox.Location = new System.Drawing.Point(3, 372);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(273, 38);
            this.ResultTextBox.TabIndex = 3;
            this.ResultTextBox.Text = "0";
            this.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.UnitGroupBox.ResumeLayout(false);
            this.UnitGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton RadioButtonMetric;
        private System.Windows.Forms.RadioButton RadioButtonImperial;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox TextBoxWeight;
        private System.Windows.Forms.TextBox TextBoxHeight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox UnitGroupBox;
        private System.Windows.Forms.TextBox ResultTextBox;
    }
}

