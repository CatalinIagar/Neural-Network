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
            this.testBtn = new Proiect3.RoundButton();
            this.generateBtn = new Proiect3.RoundButton();
            this.dataBtn = new Proiect3.RoundButton();
            this.inputBtn = new Proiect3.RoundButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.inputBtn);
            this.panel1.Controls.Add(this.testBtn);
            this.panel1.Controls.Add(this.generateBtn);
            this.panel1.Controls.Add(this.dataBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 100);
            this.panel1.TabIndex = 0;
            // 
            // testBtn
            // 
            this.testBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.testBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.testBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.testBtn.BorderRadius = 25;
            this.testBtn.BorderSize = 0;
            this.testBtn.FlatAppearance.BorderSize = 0;
            this.testBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testBtn.ForeColor = System.Drawing.Color.White;
            this.testBtn.Location = new System.Drawing.Point(398, 25);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(150, 50);
            this.testBtn.TabIndex = 2;
            this.testBtn.Text = "Test Network";
            this.testBtn.TextColor = System.Drawing.Color.White;
            this.testBtn.UseVisualStyleBackColor = false;
            this.testBtn.Visible = false;
            this.testBtn.Click += new System.EventHandler(this.TestBtn_Click);
            // 
            // generateBtn
            // 
            this.generateBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.generateBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.generateBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.generateBtn.BorderRadius = 25;
            this.generateBtn.BorderSize = 0;
            this.generateBtn.FlatAppearance.BorderSize = 0;
            this.generateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateBtn.ForeColor = System.Drawing.Color.White;
            this.generateBtn.Location = new System.Drawing.Point(217, 25);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(150, 50);
            this.generateBtn.TabIndex = 1;
            this.generateBtn.Text = "Neural Network";
            this.generateBtn.TextColor = System.Drawing.Color.White;
            this.generateBtn.UseVisualStyleBackColor = false;
            this.generateBtn.Visible = false;
            this.generateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
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
            // inputBtn
            // 
            this.inputBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.inputBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.inputBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.inputBtn.BorderRadius = 25;
            this.inputBtn.BorderSize = 0;
            this.inputBtn.FlatAppearance.BorderSize = 0;
            this.inputBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputBtn.ForeColor = System.Drawing.Color.White;
            this.inputBtn.Location = new System.Drawing.Point(583, 25);
            this.inputBtn.Name = "inputBtn";
            this.inputBtn.Size = new System.Drawing.Size(150, 50);
            this.inputBtn.TabIndex = 3;
            this.inputBtn.Text = "Test Input";
            this.inputBtn.TextColor = System.Drawing.Color.White;
            this.inputBtn.UseVisualStyleBackColor = false;
            this.inputBtn.Visible = false;
            this.inputBtn.Click += new System.EventHandler(this.InputBtn_Click);
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
        private RoundButton generateBtn;
        private RoundButton testBtn;
        private RoundButton inputBtn;
    }
}

