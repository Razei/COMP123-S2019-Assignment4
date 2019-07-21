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
            this.label1 = new System.Windows.Forms.Label();
            this.CalculatorTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RadioButtonGroupBox = new System.Windows.Forms.GroupBox();
            this.RadioButtonImperial = new System.Windows.Forms.RadioButton();
            this.RadioButtonMetric = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxHeight = new System.Windows.Forms.TextBox();
            this.TextBoxWeight = new System.Windows.Forms.TextBox();
            this.CalculatorTableLayoutPanel.SuspendLayout();
            this.RadioButtonGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CalculatorTableLayoutPanel
            // 
            this.CalculatorTableLayoutPanel.ColumnCount = 2;
            this.CalculatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.64286F));
            this.CalculatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.35714F));
            this.CalculatorTableLayoutPanel.Controls.Add(this.label2, 0, 0);
            this.CalculatorTableLayoutPanel.Controls.Add(this.label3, 0, 1);
            this.CalculatorTableLayoutPanel.Controls.Add(this.TextBoxHeight, 1, 0);
            this.CalculatorTableLayoutPanel.Controls.Add(this.TextBoxWeight, 1, 1);
            this.CalculatorTableLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculatorTableLayoutPanel.Location = new System.Drawing.Point(12, 201);
            this.CalculatorTableLayoutPanel.Name = "CalculatorTableLayoutPanel";
            this.CalculatorTableLayoutPanel.RowCount = 4;
            this.CalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayoutPanel.Size = new System.Drawing.Size(280, 228);
            this.CalculatorTableLayoutPanel.TabIndex = 1;
            // 
            // RadioButtonGroupBox
            // 
            this.RadioButtonGroupBox.Controls.Add(this.RadioButtonMetric);
            this.RadioButtonGroupBox.Controls.Add(this.RadioButtonImperial);
            this.RadioButtonGroupBox.Location = new System.Drawing.Point(12, 68);
            this.RadioButtonGroupBox.Name = "RadioButtonGroupBox";
            this.RadioButtonGroupBox.Size = new System.Drawing.Size(280, 127);
            this.RadioButtonGroupBox.TabIndex = 1;
            this.RadioButtonGroupBox.TabStop = false;
            // 
            // RadioButtonImperial
            // 
            this.RadioButtonImperial.AutoSize = true;
            this.RadioButtonImperial.Location = new System.Drawing.Point(7, 26);
            this.RadioButtonImperial.Name = "RadioButtonImperial";
            this.RadioButtonImperial.Size = new System.Drawing.Size(128, 35);
            this.RadioButtonImperial.TabIndex = 0;
            this.RadioButtonImperial.TabStop = true;
            this.RadioButtonImperial.Text = "Imperial";
            this.RadioButtonImperial.UseVisualStyleBackColor = true;
            // 
            // RadioButtonMetric
            // 
            this.RadioButtonMetric.AutoSize = true;
            this.RadioButtonMetric.Location = new System.Drawing.Point(6, 67);
            this.RadioButtonMetric.Name = "RadioButtonMetric";
            this.RadioButtonMetric.Size = new System.Drawing.Size(106, 35);
            this.RadioButtonMetric.TabIndex = 0;
            this.RadioButtonMetric.TabStop = true;
            this.RadioButtonMetric.Text = "Metric";
            this.RadioButtonMetric.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 57);
            this.label2.TabIndex = 0;
            this.label2.Text = "Height";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(3, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 57);
            this.label3.TabIndex = 0;
            this.label3.Text = "Weight";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxHeight
            // 
            this.TextBoxHeight.AllowDrop = true;
            this.TextBoxHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxHeight.Location = new System.Drawing.Point(86, 3);
            this.TextBoxHeight.Name = "TextBoxHeight";
            this.TextBoxHeight.Size = new System.Drawing.Size(191, 26);
            this.TextBoxHeight.TabIndex = 1;
            this.TextBoxHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxWeight
            // 
            this.TextBoxWeight.AllowDrop = true;
            this.TextBoxWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxWeight.Location = new System.Drawing.Point(86, 60);
            this.TextBoxWeight.Name = "TextBoxWeight";
            this.TextBoxWeight.Size = new System.Drawing.Size(191, 26);
            this.TextBoxWeight.TabIndex = 1;
            this.TextBoxWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalculatorTableLayoutPanel);
            this.Controls.Add(this.RadioButtonGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.CalculatorTableLayoutPanel.ResumeLayout(false);
            this.CalculatorTableLayoutPanel.PerformLayout();
            this.RadioButtonGroupBox.ResumeLayout(false);
            this.RadioButtonGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel CalculatorTableLayoutPanel;
        private System.Windows.Forms.GroupBox RadioButtonGroupBox;
        private System.Windows.Forms.RadioButton RadioButtonMetric;
        private System.Windows.Forms.RadioButton RadioButtonImperial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxHeight;
        private System.Windows.Forms.TextBox TextBoxWeight;
    }
}

