namespace DesktopApp3
{
    partial class Form3
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
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.IDProducto = new System.Windows.Forms.TextBox();
            this.NombreP = new System.Windows.Forms.TextBox();
            this.IDprove = new System.Windows.Forms.TextBox();
            this.IDCategoria = new System.Windows.Forms.TextBox();
            this.CantXuni = new System.Windows.Forms.TextBox();
            this.PrecioUni = new System.Windows.Forms.TextBox();
            this.UnidadesEx = new System.Windows.Forms.TextBox();
            this.UnidadesEnPe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // Grilla
            // 
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.Location = new System.Drawing.Point(29, 12);
            this.Grilla.Name = "Grilla";
            this.Grilla.Size = new System.Drawing.Size(731, 270);
            this.Grilla.TabIndex = 0;
            this.Grilla.CellBorderStyleChanged += new System.EventHandler(this.Grilla_CellBorderStyleChanged);
            this.Grilla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grilla_CellClick);
            this.Grilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grilla_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IDProducto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "IDProveedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "IDCategoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cantidad Por Unidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(496, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Precio Unidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(496, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Unidades en existencia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(496, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Unidades en pedido";
            // 
            // IDProducto
            // 
            this.IDProducto.Location = new System.Drawing.Point(138, 314);
            this.IDProducto.Name = "IDProducto";
            this.IDProducto.Size = new System.Drawing.Size(100, 20);
            this.IDProducto.TabIndex = 9;
            // 
            // NombreP
            // 
            this.NombreP.Location = new System.Drawing.Point(138, 342);
            this.NombreP.Name = "NombreP";
            this.NombreP.Size = new System.Drawing.Size(100, 20);
            this.NombreP.TabIndex = 10;
            // 
            // IDprove
            // 
            this.IDprove.Location = new System.Drawing.Point(138, 384);
            this.IDprove.Name = "IDprove";
            this.IDprove.Size = new System.Drawing.Size(100, 20);
            this.IDprove.TabIndex = 11;
            // 
            // IDCategoria
            // 
            this.IDCategoria.Location = new System.Drawing.Point(138, 421);
            this.IDCategoria.Name = "IDCategoria";
            this.IDCategoria.Size = new System.Drawing.Size(100, 20);
            this.IDCategoria.TabIndex = 12;
            // 
            // CantXuni
            // 
            this.CantXuni.Location = new System.Drawing.Point(660, 314);
            this.CantXuni.Name = "CantXuni";
            this.CantXuni.Size = new System.Drawing.Size(100, 20);
            this.CantXuni.TabIndex = 13;
            // 
            // PrecioUni
            // 
            this.PrecioUni.Location = new System.Drawing.Point(660, 342);
            this.PrecioUni.Name = "PrecioUni";
            this.PrecioUni.Size = new System.Drawing.Size(100, 20);
            this.PrecioUni.TabIndex = 14;
            // 
            // UnidadesEx
            // 
            this.UnidadesEx.Location = new System.Drawing.Point(660, 384);
            this.UnidadesEx.Name = "UnidadesEx";
            this.UnidadesEx.Size = new System.Drawing.Size(100, 20);
            this.UnidadesEx.TabIndex = 15;
            // 
            // UnidadesEnPe
            // 
            this.UnidadesEnPe.Location = new System.Drawing.Point(660, 421);
            this.UnidadesEnPe.Name = "UnidadesEnPe";
            this.UnidadesEnPe.Size = new System.Drawing.Size(100, 20);
            this.UnidadesEnPe.TabIndex = 16;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UnidadesEnPe);
            this.Controls.Add(this.UnidadesEx);
            this.Controls.Add(this.PrecioUni);
            this.Controls.Add(this.CantXuni);
            this.Controls.Add(this.IDCategoria);
            this.Controls.Add(this.IDprove);
            this.Controls.Add(this.NombreP);
            this.Controls.Add(this.IDProducto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Grilla);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox IDProducto;
        private System.Windows.Forms.TextBox NombreP;
        private System.Windows.Forms.TextBox IDprove;
        private System.Windows.Forms.TextBox IDCategoria;
        private System.Windows.Forms.TextBox CantXuni;
        private System.Windows.Forms.TextBox PrecioUni;
        private System.Windows.Forms.TextBox UnidadesEx;
        private System.Windows.Forms.TextBox UnidadesEnPe;
    }
}