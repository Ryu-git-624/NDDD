
namespace NDDD.WinForm.Views
{
    partial class LatestView
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AreaIdTextBox = new System.Windows.Forms.TextBox();
            this.MeasureDateTextBox = new System.Windows.Forms.TextBox();
            this.MeasureValueTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "エリアID";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(82, 294);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "計測日時";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "計測値";
            // 
            // AreaIdTextBox
            // 
            this.AreaIdTextBox.Location = new System.Drawing.Point(295, 79);
            this.AreaIdTextBox.Name = "AreaIdTextBox";
            this.AreaIdTextBox.ReadOnly = true;
            this.AreaIdTextBox.Size = new System.Drawing.Size(202, 25);
            this.AreaIdTextBox.TabIndex = 4;
            // 
            // MeasureDateTextBox
            // 
            this.MeasureDateTextBox.Location = new System.Drawing.Point(295, 151);
            this.MeasureDateTextBox.Name = "MeasureDateTextBox";
            this.MeasureDateTextBox.ReadOnly = true;
            this.MeasureDateTextBox.Size = new System.Drawing.Size(202, 25);
            this.MeasureDateTextBox.TabIndex = 5;
            // 
            // MeasureValueTextBox
            // 
            this.MeasureValueTextBox.Location = new System.Drawing.Point(295, 224);
            this.MeasureValueTextBox.Name = "MeasureValueTextBox";
            this.MeasureValueTextBox.ReadOnly = true;
            this.MeasureValueTextBox.Size = new System.Drawing.Size(202, 25);
            this.MeasureValueTextBox.TabIndex = 6;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(182, 283);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(339, 52);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // LatestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.MeasureValueTextBox);
            this.Controls.Add(this.MeasureDateTextBox);
            this.Controls.Add(this.AreaIdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "LatestView";
            this.Text = "LatestView";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.AreaIdTextBox, 0);
            this.Controls.SetChildIndex(this.MeasureDateTextBox, 0);
            this.Controls.SetChildIndex(this.MeasureValueTextBox, 0);
            this.Controls.SetChildIndex(this.SearchButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AreaIdTextBox;
        private System.Windows.Forms.TextBox MeasureDateTextBox;
        private System.Windows.Forms.TextBox MeasureValueTextBox;
        private System.Windows.Forms.Button SearchButton;
    }
}