namespace klasa_proces
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
            this.fExplorer = new System.Windows.Forms.Button();
            this.fExcel = new System.Windows.Forms.Button();
            this.fWord = new System.Windows.Forms.Button();
            this.fInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fExplorer
            // 
            this.fExplorer.Location = new System.Drawing.Point(57, 47);
            this.fExplorer.Margin = new System.Windows.Forms.Padding(4);
            this.fExplorer.Name = "fExplorer";
            this.fExplorer.Size = new System.Drawing.Size(124, 28);
            this.fExplorer.TabIndex = 0;
            this.fExplorer.Text = "Internet explorer";
            this.fExplorer.UseVisualStyleBackColor = true;
            this.fExplorer.Click += new System.EventHandler(this.fExplorer_Click);
            // 
            // fExcel
            // 
            this.fExcel.Location = new System.Drawing.Point(265, 47);
            this.fExcel.Margin = new System.Windows.Forms.Padding(4);
            this.fExcel.Name = "fExcel";
            this.fExcel.Size = new System.Drawing.Size(100, 28);
            this.fExcel.TabIndex = 1;
            this.fExcel.Text = "Excel";
            this.fExcel.UseVisualStyleBackColor = true;
            this.fExcel.Click += new System.EventHandler(this.fExcel_Click);
            // 
            // fWord
            // 
            this.fWord.Location = new System.Drawing.Point(57, 144);
            this.fWord.Margin = new System.Windows.Forms.Padding(4);
            this.fWord.Name = "fWord";
            this.fWord.Size = new System.Drawing.Size(100, 28);
            this.fWord.TabIndex = 2;
            this.fWord.Text = "Word";
            this.fWord.UseVisualStyleBackColor = true;
            this.fWord.Click += new System.EventHandler(this.fWord_Click);
            // 
            // fInfo
            // 
            this.fInfo.Location = new System.Drawing.Point(265, 144);
            this.fInfo.Margin = new System.Windows.Forms.Padding(4);
            this.fInfo.Name = "fInfo";
            this.fInfo.Size = new System.Drawing.Size(100, 28);
            this.fInfo.TabIndex = 3;
            this.fInfo.Text = "Start Info";
            this.fInfo.UseVisualStyleBackColor = true;
            this.fInfo.Click += new System.EventHandler(this.fInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 293);
            this.Controls.Add(this.fInfo);
            this.Controls.Add(this.fWord);
            this.Controls.Add(this.fExcel);
            this.Controls.Add(this.fExplorer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Process start";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fExplorer;
        private System.Windows.Forms.Button fExcel;
        private System.Windows.Forms.Button fWord;
        private System.Windows.Forms.Button fInfo;
    }
}

