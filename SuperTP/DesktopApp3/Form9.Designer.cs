namespace DesktopApp3
{
    partial class Form9
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
            this.ltsBox = new System.Windows.Forms.CheckedListBox();
            this.bt = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ltsBox
            // 
            this.ltsBox.FormattingEnabled = true;
            this.ltsBox.Location = new System.Drawing.Point(12, 79);
            this.ltsBox.Name = "ltsBox";
            this.ltsBox.Size = new System.Drawing.Size(162, 199);
            this.ltsBox.TabIndex = 0;
            this.ltsBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // bt
            // 
            this.bt.Location = new System.Drawing.Point(180, 47);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(161, 38);
            this.bt.TabIndex = 1;
            this.bt.Text = "Mostrar Seleccion";
            this.bt.UseVisualStyleBackColor = true;
            this.bt.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(194, 118);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(147, 160);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 329);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bt);
            this.Controls.Add(this.ltsBox);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ltsBox;
        private System.Windows.Forms.Button bt;
        private System.Windows.Forms.ListBox listBox1;
    }
}