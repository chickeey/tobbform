namespace yeet
{
    partial class FrmMain
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
            this.lbl = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.txtb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(74, 68);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(88, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Your next Line is:";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(88, 127);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(180, 73);
            this.btn.TabIndex = 1;
            this.btn.Text = "Button";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(168, 65);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 20);
            this.txtb.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 316);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lbl);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox txtb;
    }
}

