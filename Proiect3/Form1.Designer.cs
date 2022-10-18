namespace Proiect3
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataBtn = new Proiect3.RoundButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.dataBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 100);
            this.panel1.TabIndex = 0;
            // 
            // dataBtn
            // 
            this.dataBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.dataBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dataBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dataBtn.BorderRadius = 25;
            this.dataBtn.BorderSize = 0;
            this.dataBtn.FlatAppearance.BorderSize = 0;
            this.dataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataBtn.ForeColor = System.Drawing.Color.White;
            this.dataBtn.Location = new System.Drawing.Point(30, 25);
            this.dataBtn.Name = "dataBtn";
            this.dataBtn.Size = new System.Drawing.Size(150, 50);
            this.dataBtn.TabIndex = 0;
            this.dataBtn.Text = "Show Data";
            this.dataBtn.TextColor = System.Drawing.Color.White;
            this.dataBtn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 761);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RoundButton dataBtn;
    }
}

