namespace DesktopApp3
{
    partial class Form6
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
            this.Lt1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cargo = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lt1
            // 
            this.Lt1.FormattingEnabled = true;
            this.Lt1.Location = new System.Drawing.Point(23, 59);
            this.Lt1.Name = "Lt1";
            this.Lt1.Size = new System.Drawing.Size(327, 316);
            this.Lt1.TabIndex = 0;
            this.Lt1.SelectedIndexChanged += new System.EventHandler(this.Lt1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cargo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido:";
            // 
            // Cargo
            // 
            this.Cargo.Location = new System.Drawing.Point(418, 84);
            this.Cargo.Name = "Cargo";
            this.Cargo.Size = new System.Drawing.Size(188, 20);
            this.Cargo.TabIndex = 4;
            // 
            // Apellido
            // 
            this.Apellido.Location = new System.Drawing.Point(418, 277);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(188, 20);
            this.Apellido.TabIndex = 5;
            this.Apellido.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(418, 180);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(188, 20);
            this.Nombre.TabIndex = 5;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.Cargo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lt1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Cargo;
        private System.Windows.Forms.TextBox Apellido;
        private System.Windows.Forms.TextBox Nombre;
    }
}