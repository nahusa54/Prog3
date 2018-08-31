namespace DesktopApp3
{
    partial class Form7
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
            this.button1 = new System.Windows.Forms.Button();
            this.Lis1 = new System.Windows.Forms.ListBox();
            this.Lis2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "Mostrar Seleccion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lis1
            // 
            this.Lis1.Location = new System.Drawing.Point(33, 83);
            this.Lis1.Name = "Lis1";
            this.Lis1.Size = new System.Drawing.Size(232, 316);
            this.Lis1.TabIndex = 3;
            this.Lis1.SelectedIndexChanged += new System.EventHandler(this.Lis1_SelectedIndexChanged);
            // 
            // Lis2
            // 
            this.Lis2.FormattingEnabled = true;
            this.Lis2.Location = new System.Drawing.Point(323, 170);
            this.Lis2.Name = "Lis2";
            this.Lis2.Size = new System.Drawing.Size(191, 225);
            this.Lis2.TabIndex = 4;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.Lis2);
            this.Controls.Add(this.Lis1);
            this.Controls.Add(this.button1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox Lis1;
        private System.Windows.Forms.ListBox Lis2;
    }
}