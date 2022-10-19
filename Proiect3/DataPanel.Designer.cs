namespace Proiect3
{
    partial class DataPanel
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
            this.nrmBtn = new Proiect3.RoundButton();
            this.convertBtn = new Proiect3.RoundButton();
            this.loadBtn = new Proiect3.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(115, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1009, 700);
            this.dataGridView1.TabIndex = 2;
            // 
            // nrmBtn
            // 
            this.nrmBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.nrmBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.nrmBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.nrmBtn.BorderRadius = 10;
            this.nrmBtn.BorderSize = 0;
            this.nrmBtn.FlatAppearance.BorderSize = 0;
            this.nrmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nrmBtn.ForeColor = System.Drawing.Color.White;
            this.nrmBtn.Location = new System.Drawing.Point(20, 104);
            this.nrmBtn.Name = "nrmBtn";
            this.nrmBtn.Size = new System.Drawing.Size(75, 20);
            this.nrmBtn.TabIndex = 3;
            this.nrmBtn.Text = "Normalize";
            this.nrmBtn.TextColor = System.Drawing.Color.White;
            this.nrmBtn.UseVisualStyleBackColor = false;
            this.nrmBtn.Click += new System.EventHandler(this.nrmBtn_Click);
            // 
            // convertBtn
            // 
            this.convertBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.convertBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.convertBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.convertBtn.BorderRadius = 10;
            this.convertBtn.BorderSize = 0;
            this.convertBtn.FlatAppearance.BorderSize = 0;
            this.convertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertBtn.ForeColor = System.Drawing.Color.White;
            this.convertBtn.Location = new System.Drawing.Point(20, 65);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(75, 20);
            this.convertBtn.TabIndex = 1;
            this.convertBtn.Text = "Convert";
            this.convertBtn.TextColor = System.Drawing.Color.White;
            this.convertBtn.UseVisualStyleBackColor = false;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.loadBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.loadBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.loadBtn.BorderRadius = 10;
            this.loadBtn.BorderSize = 0;
            this.loadBtn.FlatAppearance.BorderSize = 0;
            this.loadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadBtn.ForeColor = System.Drawing.Color.White;
            this.loadBtn.Location = new System.Drawing.Point(20, 25);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(75, 20);
            this.loadBtn.TabIndex = 0;
            this.loadBtn.Text = "Load";
            this.loadBtn.TextColor = System.Drawing.Color.White;
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // DataPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.nrmBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.loadBtn);
            this.Location = new System.Drawing.Point(0, 100);
            this.Name = "DataPanel";
            this.Size = new System.Drawing.Size(1124, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundButton loadBtn;
        private RoundButton convertBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RoundButton nrmBtn;
    }
}
