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
            this.countTBox = new System.Windows.Forms.TextBox();
            this.testBtn = new Proiect3.RoundButton();
            this.trainBtn = new Proiect3.RoundButton();
            this.nrmDataBtn = new Proiect3.RoundButton();
            this.dataBtn = new Proiect3.RoundButton();
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
            this.dataGridView1.Visible = false;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_ColumnHeaderMouseClick);
            // 
            // countTBox
            // 
            this.countTBox.Enabled = false;
            this.countTBox.Location = new System.Drawing.Point(20, 460);
            this.countTBox.Name = "countTBox";
            this.countTBox.Size = new System.Drawing.Size(75, 20);
            this.countTBox.TabIndex = 8;
            this.countTBox.Visible = false;
            // 
            // testBtn
            // 
            this.testBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.testBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.testBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.testBtn.BorderRadius = 10;
            this.testBtn.BorderSize = 0;
            this.testBtn.FlatAppearance.BorderSize = 0;
            this.testBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testBtn.ForeColor = System.Drawing.Color.White;
            this.testBtn.Location = new System.Drawing.Point(20, 254);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(75, 20);
            this.testBtn.TabIndex = 7;
            this.testBtn.Text = "Test Data";
            this.testBtn.TextColor = System.Drawing.Color.White;
            this.testBtn.UseVisualStyleBackColor = false;
            this.testBtn.Visible = false;
            this.testBtn.Click += new System.EventHandler(this.TestBtn_Click);
            // 
            // trainBtn
            // 
            this.trainBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.trainBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.trainBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.trainBtn.BorderRadius = 10;
            this.trainBtn.BorderSize = 0;
            this.trainBtn.FlatAppearance.BorderSize = 0;
            this.trainBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trainBtn.ForeColor = System.Drawing.Color.White;
            this.trainBtn.Location = new System.Drawing.Point(20, 217);
            this.trainBtn.Name = "trainBtn";
            this.trainBtn.Size = new System.Drawing.Size(75, 20);
            this.trainBtn.TabIndex = 6;
            this.trainBtn.Text = "Train Data";
            this.trainBtn.TextColor = System.Drawing.Color.White;
            this.trainBtn.UseVisualStyleBackColor = false;
            this.trainBtn.Visible = false;
            this.trainBtn.Click += new System.EventHandler(this.TrainBtn_Click);
            // 
            // nrmDataBtn
            // 
            this.nrmDataBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.nrmDataBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.nrmDataBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.nrmDataBtn.BorderRadius = 10;
            this.nrmDataBtn.BorderSize = 0;
            this.nrmDataBtn.FlatAppearance.BorderSize = 0;
            this.nrmDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nrmDataBtn.ForeColor = System.Drawing.Color.White;
            this.nrmDataBtn.Location = new System.Drawing.Point(20, 180);
            this.nrmDataBtn.Name = "nrmDataBtn";
            this.nrmDataBtn.Size = new System.Drawing.Size(75, 20);
            this.nrmDataBtn.TabIndex = 5;
            this.nrmDataBtn.Text = "Norm Data";
            this.nrmDataBtn.TextColor = System.Drawing.Color.White;
            this.nrmDataBtn.UseVisualStyleBackColor = false;
            this.nrmDataBtn.Visible = false;
            this.nrmDataBtn.Click += new System.EventHandler(this.NrmDataBtn_Click);
            // 
            // dataBtn
            // 
            this.dataBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.dataBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dataBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dataBtn.BorderRadius = 10;
            this.dataBtn.BorderSize = 0;
            this.dataBtn.FlatAppearance.BorderSize = 0;
            this.dataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataBtn.ForeColor = System.Drawing.Color.White;
            this.dataBtn.Location = new System.Drawing.Point(20, 143);
            this.dataBtn.Name = "dataBtn";
            this.dataBtn.Size = new System.Drawing.Size(75, 20);
            this.dataBtn.TabIndex = 4;
            this.dataBtn.Text = "Init Data";
            this.dataBtn.TextColor = System.Drawing.Color.White;
            this.dataBtn.UseVisualStyleBackColor = false;
            this.dataBtn.Visible = false;
            this.dataBtn.Click += new System.EventHandler(this.DataBtn_Click);
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
            this.nrmBtn.Visible = false;
            this.nrmBtn.Click += new System.EventHandler(this.NrmBtn_Click);
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
            this.convertBtn.Visible = false;
            this.convertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
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
            this.loadBtn.Click += new System.EventHandler(this.RoundButton1_Click);
            // 
            // DataPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.countTBox);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.trainBtn);
            this.Controls.Add(this.nrmDataBtn);
            this.Controls.Add(this.dataBtn);
            this.Controls.Add(this.nrmBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.loadBtn);
            this.Location = new System.Drawing.Point(0, 100);
            this.Name = "DataPanel";
            this.Size = new System.Drawing.Size(1124, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton loadBtn;
        private RoundButton convertBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RoundButton nrmBtn;
        private RoundButton dataBtn;
        private RoundButton nrmDataBtn;
        private RoundButton trainBtn;
        private RoundButton testBtn;
        private System.Windows.Forms.TextBox countTBox;
    }
}
