namespace Proiect3.GUI
{
    partial class TestPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.testBtn = new Proiect3.RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.customProgressBar1 = new Proiect3.Classes.CustomProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1089, 589);
            this.dataGridView1.TabIndex = 0;
            // 
            // testBtn
            // 
            this.testBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.testBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.testBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.testBtn.BorderRadius = 20;
            this.testBtn.BorderSize = 0;
            this.testBtn.FlatAppearance.BorderSize = 0;
            this.testBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testBtn.ForeColor = System.Drawing.Color.White;
            this.testBtn.Location = new System.Drawing.Point(15, 30);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(150, 40);
            this.testBtn.TabIndex = 1;
            this.testBtn.Text = "Test Network";
            this.testBtn.TextColor = System.Drawing.Color.White;
            this.testBtn.UseVisualStyleBackColor = false;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Precision";
            // 
            // customProgressBar1
            // 
            this.customProgressBar1.CustomText = null;
            this.customProgressBar1.DisplayStyle = Proiect3.Classes.ProgressBarDisplayText.Percentage;
            this.customProgressBar1.Location = new System.Drawing.Point(316, 37);
            this.customProgressBar1.Name = "customProgressBar1";
            this.customProgressBar1.Size = new System.Drawing.Size(212, 23);
            this.customProgressBar1.TabIndex = 3;
            // 
            // TestPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customProgressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.dataGridView1);
            this.Location = new System.Drawing.Point(0, 115);
            this.Name = "TestPanel";
            this.Size = new System.Drawing.Size(1124, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RoundButton testBtn;
        private System.Windows.Forms.Label label1;
        private Classes.CustomProgressBar customProgressBar1;
    }
}
