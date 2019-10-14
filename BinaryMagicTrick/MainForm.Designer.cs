namespace Magic_Trick
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.RangeChooser = new System.Windows.Forms.NumericUpDown();
            this.SetBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RangeChooser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(21, 0, 21, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Range: 0 -";
            // 
            // RangeChooser
            // 
            this.RangeChooser.Location = new System.Drawing.Point(109, 38);
            this.RangeChooser.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.RangeChooser.Maximum = new decimal(new int[] {
            1023,
            0,
            0,
            0});
            this.RangeChooser.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RangeChooser.Name = "RangeChooser";
            this.RangeChooser.Size = new System.Drawing.Size(65, 29);
            this.RangeChooser.TabIndex = 6;
            this.RangeChooser.Value = new decimal(new int[] {
            63,
            0,
            0,
            0});
            this.RangeChooser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Range_KeyDown);
            // 
            // SetBTN
            // 
            this.SetBTN.Location = new System.Drawing.Point(16, 74);
            this.SetBTN.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.SetBTN.Name = "SetBTN";
            this.SetBTN.Size = new System.Drawing.Size(158, 33);
            this.SetBTN.TabIndex = 1;
            this.SetBTN.Text = "Set";
            this.SetBTN.UseVisualStyleBackColor = true;
            this.SetBTN.Click += new System.EventHandler(this.SetBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Choose the range:";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(187, 116);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RangeChooser);
            this.Controls.Add(this.SetBTN);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Binary Magic Trick";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RangeChooser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown RangeChooser;
        private System.Windows.Forms.Button SetBTN;
        private System.Windows.Forms.Label label2;
    }
}