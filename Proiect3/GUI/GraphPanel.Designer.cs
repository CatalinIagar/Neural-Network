namespace Proiect3.GUI
{
    partial class GraphPanel
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
            this.components = new System.ComponentModel.Container();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.learningValue = new System.Windows.Forms.NumericUpDown();
            this.errorValue = new System.Windows.Forms.NumericUpDown();
            this.epochValue = new System.Windows.Forms.NumericUpDown();
            this.currentErrorValue = new System.Windows.Forms.NumericUpDown();
            this.stopBtn = new Proiect3.RoundButton();
            this.startBtn = new Proiect3.RoundButton();
            this.progressBar = new Proiect3.Classes.CustomProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.learningValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epochValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentErrorValue)).BeginInit();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(17, 0);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(1090, 462);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Learning Rate: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 585);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of epochs: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 615);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Current error:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 555);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Error target:";
            // 
            // learningValue
            // 
            this.learningValue.DecimalPlaces = 4;
            this.learningValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.learningValue.Location = new System.Drawing.Point(178, 525);
            this.learningValue.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.learningValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.learningValue.Name = "learningValue";
            this.learningValue.Size = new System.Drawing.Size(120, 20);
            this.learningValue.TabIndex = 6;
            this.learningValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            // 
            // errorValue
            // 
            this.errorValue.DecimalPlaces = 2;
            this.errorValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.errorValue.Location = new System.Drawing.Point(178, 555);
            this.errorValue.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.errorValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.errorValue.Name = "errorValue";
            this.errorValue.Size = new System.Drawing.Size(120, 20);
            this.errorValue.TabIndex = 7;
            this.errorValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // epochValue
            // 
            this.epochValue.Location = new System.Drawing.Point(178, 585);
            this.epochValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.epochValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.epochValue.Name = "epochValue";
            this.epochValue.Size = new System.Drawing.Size(120, 20);
            this.epochValue.TabIndex = 8;
            this.epochValue.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // currentErrorValue
            // 
            this.currentErrorValue.DecimalPlaces = 8;
            this.currentErrorValue.Enabled = false;
            this.currentErrorValue.Location = new System.Drawing.Point(178, 615);
            this.currentErrorValue.Name = "currentErrorValue";
            this.currentErrorValue.Size = new System.Drawing.Size(120, 20);
            this.currentErrorValue.TabIndex = 9;
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.stopBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.stopBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.stopBtn.BorderRadius = 20;
            this.stopBtn.BorderSize = 0;
            this.stopBtn.FlatAppearance.BorderSize = 0;
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBtn.ForeColor = System.Drawing.Color.White;
            this.stopBtn.Location = new System.Drawing.Point(410, 585);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(150, 40);
            this.stopBtn.TabIndex = 11;
            this.stopBtn.Text = "Stop";
            this.stopBtn.TextColor = System.Drawing.Color.White;
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.startBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.startBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.startBtn.BorderRadius = 20;
            this.startBtn.BorderSize = 0;
            this.startBtn.FlatAppearance.BorderSize = 0;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.ForeColor = System.Drawing.Color.White;
            this.startBtn.Location = new System.Drawing.Point(410, 525);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(150, 40);
            this.startBtn.TabIndex = 10;
            this.startBtn.Text = "Start";
            this.startBtn.TextColor = System.Drawing.Color.White;
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // progressBar
            // 
            this.progressBar.CustomText = null;
            this.progressBar.DisplayStyle = Proiect3.Classes.ProgressBarDisplayText.Percentage;
            this.progressBar.Location = new System.Drawing.Point(17, 481);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1090, 25);
            this.progressBar.TabIndex = 12;
            // 
            // GraphPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.currentErrorValue);
            this.Controls.Add(this.epochValue);
            this.Controls.Add(this.errorValue);
            this.Controls.Add(this.learningValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zedGraphControl1);
            this.Location = new System.Drawing.Point(0, 115);
            this.Name = "GraphPanel";
            this.Size = new System.Drawing.Size(1124, 700);
            ((System.ComponentModel.ISupportInitialize)(this.learningValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epochValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentErrorValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown learningValue;
        private System.Windows.Forms.NumericUpDown errorValue;
        private System.Windows.Forms.NumericUpDown epochValue;
        private System.Windows.Forms.NumericUpDown currentErrorValue;
        private RoundButton startBtn;
        private RoundButton stopBtn;
        private Classes.CustomProgressBar progressBar;
    }
}
