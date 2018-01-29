namespace TelesarjaValija
{
    partial class TelesarjaValija
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
            this.otsustaBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.directoryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // otsustaBtn
            // 
            this.otsustaBtn.Location = new System.Drawing.Point(12, 12);
            this.otsustaBtn.Name = "otsustaBtn";
            this.otsustaBtn.Size = new System.Drawing.Size(108, 39);
            this.otsustaBtn.TabIndex = 0;
            this.otsustaBtn.Text = "Otsusta";
            this.otsustaBtn.UseVisualStyleBackColor = true;
            this.otsustaBtn.Click += new System.EventHandler(this.otsustaBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sina vaatad täna:";
            // 
            // directoryBtn
            // 
            this.directoryBtn.Location = new System.Drawing.Point(12, 57);
            this.directoryBtn.Name = "directoryBtn";
            this.directoryBtn.Size = new System.Drawing.Size(27, 22);
            this.directoryBtn.TabIndex = 2;
            this.directoryBtn.Text = "...";
            this.directoryBtn.UseVisualStyleBackColor = true;
            this.directoryBtn.Click += new System.EventHandler(this.directoryBtn_Click);
            // 
            // TelesarjaValija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 129);
            this.Controls.Add(this.directoryBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.otsustaBtn);
            this.Name = "TelesarjaValija";
            this.Text = "Telesarja Valija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button otsustaBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button directoryBtn;
    }
}

