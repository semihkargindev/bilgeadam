namespace WFA_KararYapilari.IfElse
{
    partial class Form2
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
            this.txtGelenDeger1 = new System.Windows.Forms.TextBox();
            this.txtGelenDeger2 = new System.Windows.Forms.TextBox();
            this.btnDeger1 = new System.Windows.Forms.Button();
            this.btnDeger2 = new System.Windows.Forms.Button();
            this.btnDeger3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGelenDeger1
            // 
            this.txtGelenDeger1.Location = new System.Drawing.Point(18, 18);
            this.txtGelenDeger1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGelenDeger1.Name = "txtGelenDeger1";
            this.txtGelenDeger1.Size = new System.Drawing.Size(247, 26);
            this.txtGelenDeger1.TabIndex = 0;
            // 
            // txtGelenDeger2
            // 
            this.txtGelenDeger2.Location = new System.Drawing.Point(18, 58);
            this.txtGelenDeger2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGelenDeger2.Name = "txtGelenDeger2";
            this.txtGelenDeger2.Size = new System.Drawing.Size(247, 26);
            this.txtGelenDeger2.TabIndex = 1;
            // 
            // btnDeger1
            // 
            this.btnDeger1.Location = new System.Drawing.Point(18, 98);
            this.btnDeger1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeger1.Name = "btnDeger1";
            this.btnDeger1.Size = new System.Drawing.Size(249, 48);
            this.btnDeger1.TabIndex = 2;
            this.btnDeger1.Text = "Deger 1";
            this.btnDeger1.UseVisualStyleBackColor = true;
            this.btnDeger1.Click += new System.EventHandler(this.btnDeger1_Click);
            // 
            // btnDeger2
            // 
            this.btnDeger2.Location = new System.Drawing.Point(16, 154);
            this.btnDeger2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeger2.Name = "btnDeger2";
            this.btnDeger2.Size = new System.Drawing.Size(249, 48);
            this.btnDeger2.TabIndex = 3;
            this.btnDeger2.Text = "Deger 2";
            this.btnDeger2.UseVisualStyleBackColor = true;
            this.btnDeger2.Click += new System.EventHandler(this.btnDeger2_Click);
            // 
            // btnDeger3
            // 
            this.btnDeger3.Location = new System.Drawing.Point(18, 212);
            this.btnDeger3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeger3.Name = "btnDeger3";
            this.btnDeger3.Size = new System.Drawing.Size(249, 48);
            this.btnDeger3.TabIndex = 4;
            this.btnDeger3.Text = "Deger 3";
            this.btnDeger3.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 292);
            this.Controls.Add(this.btnDeger3);
            this.Controls.Add(this.btnDeger2);
            this.Controls.Add(this.btnDeger1);
            this.Controls.Add(this.txtGelenDeger2);
            this.Controls.Add(this.txtGelenDeger1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGelenDeger1;
        private System.Windows.Forms.TextBox txtGelenDeger2;
        private System.Windows.Forms.Button btnDeger1;
        private System.Windows.Forms.Button btnDeger2;
        private System.Windows.Forms.Button btnDeger3;
    }
}