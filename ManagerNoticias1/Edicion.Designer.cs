
namespace ManagerNoticias1
{
    partial class Edicion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.TextBox();
            this.Articulo = new System.Windows.Forms.TextBox();
            this.CategoriaC = new System.Windows.Forms.ComboBox();
            this.PaisC = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pais";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Articulo";
            // 
            // Titulo
            // 
            this.Titulo.Location = new System.Drawing.Point(113, 40);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(143, 20);
            this.Titulo.TabIndex = 4;
            // 
            // Articulo
            // 
            this.Articulo.Location = new System.Drawing.Point(113, 125);
            this.Articulo.Multiline = true;
            this.Articulo.Name = "Articulo";
            this.Articulo.Size = new System.Drawing.Size(143, 53);
            this.Articulo.TabIndex = 5;
            // 
            // CategoriaC
            // 
            this.CategoriaC.FormattingEnabled = true;
            this.CategoriaC.Location = new System.Drawing.Point(113, 71);
            this.CategoriaC.Name = "CategoriaC";
            this.CategoriaC.Size = new System.Drawing.Size(143, 21);
            this.CategoriaC.TabIndex = 6;
            // 
            // PaisC
            // 
            this.PaisC.FormattingEnabled = true;
            this.PaisC.Location = new System.Drawing.Point(113, 98);
            this.PaisC.Name = "PaisC";
            this.PaisC.Size = new System.Drawing.Size(143, 21);
            this.PaisC.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ventana de edicion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Edicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 254);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PaisC);
            this.Controls.Add(this.CategoriaC);
            this.Controls.Add(this.Articulo);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Edicion";
            this.Text = "Edicion";
            this.Load += new System.EventHandler(this.Edicion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Titulo;
        private System.Windows.Forms.TextBox Articulo;
        private System.Windows.Forms.ComboBox CategoriaC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox PaisC;
    }
}