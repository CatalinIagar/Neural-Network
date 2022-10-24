namespace Proiect3
{
    partial class GenerateNetwork
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
            this.layersLbl = new System.Windows.Forms.Label();
            this.layersInput = new System.Windows.Forms.NumericUpDown();
            this.hidden2NeuronsInput = new System.Windows.Forms.NumericUpDown();
            this.hidden2Lbl = new System.Windows.Forms.Label();
            this.hidden1NeuronsInput = new System.Windows.Forms.NumericUpDown();
            this.hidden1Lbl = new System.Windows.Forms.Label();
            this.hidden3NeuronsInput = new System.Windows.Forms.NumericUpDown();
            this.hidden3Lbl = new System.Windows.Forms.Label();
            this.generateBtn = new Proiect3.RoundButton();
            this.btnCancel = new Proiect3.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.layersInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidden2NeuronsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidden1NeuronsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidden3NeuronsInput)).BeginInit();
            this.SuspendLayout();
            // 
            // layersLbl
            // 
            this.layersLbl.AutoSize = true;
            this.layersLbl.Location = new System.Drawing.Point(12, 15);
            this.layersLbl.Name = "layersLbl";
            this.layersLbl.Size = new System.Drawing.Size(172, 13);
            this.layersLbl.TabIndex = 0;
            this.layersLbl.Text = "Insert the number of hidden layers: ";
            // 
            // layersInput
            // 
            this.layersInput.Location = new System.Drawing.Point(250, 10);
            this.layersInput.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.layersInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.layersInput.Name = "layersInput";
            this.layersInput.Size = new System.Drawing.Size(60, 20);
            this.layersInput.TabIndex = 0;
            this.layersInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.layersInput.ValueChanged += new System.EventHandler(this.LayersInput_ValueChanged);
            // 
            // hidden2NeuronsInput
            // 
            this.hidden2NeuronsInput.Location = new System.Drawing.Point(249, 100);
            this.hidden2NeuronsInput.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.hidden2NeuronsInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hidden2NeuronsInput.Name = "hidden2NeuronsInput";
            this.hidden2NeuronsInput.Size = new System.Drawing.Size(60, 20);
            this.hidden2NeuronsInput.TabIndex = 4;
            this.hidden2NeuronsInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hidden2NeuronsInput.Visible = false;
            // 
            // hidden2Lbl
            // 
            this.hidden2Lbl.AutoSize = true;
            this.hidden2Lbl.Location = new System.Drawing.Point(11, 105);
            this.hidden2Lbl.Name = "hidden2Lbl";
            this.hidden2Lbl.Size = new System.Drawing.Size(223, 13);
            this.hidden2Lbl.TabIndex = 8;
            this.hidden2Lbl.Text = "Insert the number of neurons on the H2 layer: ";
            this.hidden2Lbl.Visible = false;
            // 
            // hidden1NeuronsInput
            // 
            this.hidden1NeuronsInput.Location = new System.Drawing.Point(250, 70);
            this.hidden1NeuronsInput.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.hidden1NeuronsInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hidden1NeuronsInput.Name = "hidden1NeuronsInput";
            this.hidden1NeuronsInput.Size = new System.Drawing.Size(60, 20);
            this.hidden1NeuronsInput.TabIndex = 3;
            this.hidden1NeuronsInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // hidden1Lbl
            // 
            this.hidden1Lbl.AutoSize = true;
            this.hidden1Lbl.Location = new System.Drawing.Point(12, 75);
            this.hidden1Lbl.Name = "hidden1Lbl";
            this.hidden1Lbl.Size = new System.Drawing.Size(223, 13);
            this.hidden1Lbl.TabIndex = 10;
            this.hidden1Lbl.Text = "Insert the number of neurons on the H1 layer: ";
            // 
            // hidden3NeuronsInput
            // 
            this.hidden3NeuronsInput.Location = new System.Drawing.Point(250, 130);
            this.hidden3NeuronsInput.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.hidden3NeuronsInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hidden3NeuronsInput.Name = "hidden3NeuronsInput";
            this.hidden3NeuronsInput.Size = new System.Drawing.Size(60, 20);
            this.hidden3NeuronsInput.TabIndex = 5;
            this.hidden3NeuronsInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hidden3NeuronsInput.Visible = false;
            // 
            // hidden3Lbl
            // 
            this.hidden3Lbl.AutoSize = true;
            this.hidden3Lbl.Location = new System.Drawing.Point(12, 135);
            this.hidden3Lbl.Name = "hidden3Lbl";
            this.hidden3Lbl.Size = new System.Drawing.Size(223, 13);
            this.hidden3Lbl.TabIndex = 12;
            this.hidden3Lbl.Text = "Insert the number of neurons on the H3 layer: ";
            this.hidden3Lbl.Visible = false;
            // 
            // generateBtn
            // 
            this.generateBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.generateBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.generateBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.generateBtn.BorderRadius = 10;
            this.generateBtn.BorderSize = 0;
            this.generateBtn.FlatAppearance.BorderSize = 0;
            this.generateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateBtn.ForeColor = System.Drawing.Color.White;
            this.generateBtn.Location = new System.Drawing.Point(84, 216);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(150, 40);
            this.generateBtn.TabIndex = 14;
            this.generateBtn.Text = "Generate";
            this.generateBtn.TextColor = System.Drawing.Color.White;
            this.generateBtn.UseVisualStyleBackColor = false;
            this.generateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancel.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(110, 262);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // GenerateNetwork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(319, 363);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.hidden1NeuronsInput);
            this.Controls.Add(this.hidden1Lbl);
            this.Controls.Add(this.hidden2NeuronsInput);
            this.Controls.Add(this.hidden2Lbl);
            this.Controls.Add(this.hidden3NeuronsInput);
            this.Controls.Add(this.hidden3Lbl);
            this.Controls.Add(this.layersInput);
            this.Controls.Add(this.layersLbl);
            this.Name = "GenerateNetwork";
            this.Text = "GenerateNetwork";
            ((System.ComponentModel.ISupportInitialize)(this.layersInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidden2NeuronsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidden1NeuronsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidden3NeuronsInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label layersLbl;
        private System.Windows.Forms.NumericUpDown layersInput;
        private System.Windows.Forms.NumericUpDown hidden2NeuronsInput;
        private System.Windows.Forms.Label hidden2Lbl;
        private System.Windows.Forms.NumericUpDown hidden1NeuronsInput;
        private System.Windows.Forms.Label hidden1Lbl;
        private System.Windows.Forms.NumericUpDown hidden3NeuronsInput;
        private System.Windows.Forms.Label hidden3Lbl;
        private RoundButton generateBtn;
        private RoundButton btnCancel;
    }
}