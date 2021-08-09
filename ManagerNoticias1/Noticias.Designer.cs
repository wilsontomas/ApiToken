
namespace ManagerNoticias1
{
    partial class Noticias
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
            this.salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.TextBox();
            this.Pais = new System.Windows.Forms.ComboBox();
            this.Categoria = new System.Windows.Forms.ComboBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.Articulo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(289, 241);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 0;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pais";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Categoria";
            // 
            // Titulo
            // 
            this.Titulo.Location = new System.Drawing.Point(122, 50);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(191, 20);
            this.Titulo.TabIndex = 4;
            // 
            // Pais
            // 
            this.Pais.FormattingEnabled = true;
            this.Pais.Location = new System.Drawing.Point(122, 86);
            this.Pais.Name = "Pais";
            this.Pais.Size = new System.Drawing.Size(191, 21);
            this.Pais.TabIndex = 5;
            // 
            // Categoria
            // 
            this.Categoria.FormattingEnabled = true;
            this.Categoria.Location = new System.Drawing.Point(122, 121);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(191, 21);
            this.Categoria.TabIndex = 6;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(12, 241);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 7;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(104, 241);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Eliminar.TabIndex = 8;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            // 
            // Editar
            // 
            this.Editar.Location = new System.Drawing.Point(198, 241);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(75, 23);
            this.Editar.TabIndex = 9;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            // 
            // DataGrid
            // 
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(16, 288);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(348, 150);
            this.DataGrid.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Articulo";
            // 
            // Articulo
            // 
            this.Articulo.Location = new System.Drawing.Point(122, 157);
            this.Articulo.Multiline = true;
            this.Articulo.Name = "Articulo";
            this.Articulo.Size = new System.Drawing.Size(191, 63);
            this.Articulo.TabIndex = 12;
            // 
            // Noticias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.Controls.Add(this.Articulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Categoria);
            this.Controls.Add(this.Pais);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salir);
            this.Name = "Noticias";
            this.Text = "Noticias";
            this.Load += new System.EventHandler(this.Noticias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Titulo;
        private System.Windows.Forms.ComboBox Pais;
        private System.Windows.Forms.ComboBox Categoria;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Articulo;
    }
}