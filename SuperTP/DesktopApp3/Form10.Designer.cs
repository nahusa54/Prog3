namespace DesktopApp3
{
    partial class Form10
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
            this.Lt1 = new System.Windows.Forms.CheckedListBox();
            this.Fem = new System.Windows.Forms.CheckBox();
            this.Mas = new System.Windows.Forms.CheckBox();
            this.Cas = new System.Windows.Forms.CheckBox();
            this.Sol = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lt1
            // 
            this.Lt1.FormattingEnabled = true;
            this.Lt1.Location = new System.Drawing.Point(62, 81);
            this.Lt1.Name = "Lt1";
            this.Lt1.Size = new System.Drawing.Size(192, 244);
            this.Lt1.TabIndex = 0;
            // 
            // Fem
            // 
            this.Fem.AutoSize = true;
            this.Fem.Location = new System.Drawing.Point(37, 25);
            this.Fem.Name = "Fem";
            this.Fem.Size = new System.Drawing.Size(72, 17);
            this.Fem.TabIndex = 1;
            this.Fem.Text = "Femenino";
            this.Fem.UseVisualStyleBackColor = true;
            // 
            // Mas
            // 
            this.Mas.AutoSize = true;
            this.Mas.Location = new System.Drawing.Point(37, 58);
            this.Mas.Name = "Mas";
            this.Mas.Size = new System.Drawing.Size(74, 17);
            this.Mas.TabIndex = 2;
            this.Mas.Text = "Masculino";
            this.Mas.UseVisualStyleBackColor = true;
            // 
            // Cas
            // 
            this.Cas.AutoSize = true;
            this.Cas.Location = new System.Drawing.Point(208, 25);
            this.Cas.Name = "Cas";
            this.Cas.Size = new System.Drawing.Size(62, 17);
            this.Cas.TabIndex = 3;
            this.Cas.Text = "Casado";
            this.Cas.UseVisualStyleBackColor = true;
            // 
            // Sol
            // 
            this.Sol.AutoSize = true;
            this.Sol.Location = new System.Drawing.Point(208, 58);
            this.Sol.Name = "Sol";
            this.Sol.Size = new System.Drawing.Size(59, 17);
            this.Sol.TabIndex = 4;
            this.Sol.Text = "Soltero";
            this.Sol.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Mostrar Seleccion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usted selecciono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 522);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Sol);
            this.Controls.Add(this.Cas);
            this.Controls.Add(this.Mas);
            this.Controls.Add(this.Fem);
            this.Controls.Add(this.Lt1);
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox Lt1;
        private System.Windows.Forms.CheckBox Fem;
        private System.Windows.Forms.CheckBox Mas;
        private System.Windows.Forms.CheckBox Cas;
        private System.Windows.Forms.CheckBox Sol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}