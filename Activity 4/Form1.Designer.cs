namespace Activity_4
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
            this.PromptLBL = new System.Windows.Forms.Label();
            this.InputTB = new System.Windows.Forms.TextBox();
            this.ConvertBT = new System.Windows.Forms.Button();
            this.TypeLBL = new System.Windows.Forms.Label();
            this.NumLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PromptLBL
            // 
            this.PromptLBL.AutoSize = true;
            this.PromptLBL.Location = new System.Drawing.Point(12, 17);
            this.PromptLBL.Name = "PromptLBL";
            this.PromptLBL.Size = new System.Drawing.Size(110, 13);
            this.PromptLBL.TabIndex = 0;
            this.PromptLBL.Text = "Enter time in Seconds";
            // 
            // InputTB
            // 
            this.InputTB.Location = new System.Drawing.Point(128, 14);
            this.InputTB.Name = "InputTB";
            this.InputTB.Size = new System.Drawing.Size(100, 20);
            this.InputTB.TabIndex = 1;
            // 
            // ConvertBT
            // 
            this.ConvertBT.Location = new System.Drawing.Point(234, 12);
            this.ConvertBT.Name = "ConvertBT";
            this.ConvertBT.Size = new System.Drawing.Size(75, 23);
            this.ConvertBT.TabIndex = 2;
            this.ConvertBT.Text = "Convert";
            this.ConvertBT.UseVisualStyleBackColor = true;
            this.ConvertBT.Click += new System.EventHandler(this.ConvertBT_Click);
            // 
            // TypeLBL
            // 
            this.TypeLBL.AutoSize = true;
            this.TypeLBL.Location = new System.Drawing.Point(128, 41);
            this.TypeLBL.Name = "TypeLBL";
            this.TypeLBL.Size = new System.Drawing.Size(0, 13);
            this.TypeLBL.TabIndex = 3;
            // 
            // NumLBL
            // 
            this.NumLBL.AutoSize = true;
            this.NumLBL.Location = new System.Drawing.Point(15, 41);
            this.NumLBL.Name = "NumLBL";
            this.NumLBL.Size = new System.Drawing.Size(0, 13);
            this.NumLBL.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 109);
            this.Controls.Add(this.NumLBL);
            this.Controls.Add(this.TypeLBL);
            this.Controls.Add(this.ConvertBT);
            this.Controls.Add(this.InputTB);
            this.Controls.Add(this.PromptLBL);
            this.Name = "Form1";
            this.Text = "Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PromptLBL;
        private System.Windows.Forms.TextBox InputTB;
        private System.Windows.Forms.Button ConvertBT;
        private System.Windows.Forms.Label TypeLBL;
        private System.Windows.Forms.Label NumLBL;
    }
}

