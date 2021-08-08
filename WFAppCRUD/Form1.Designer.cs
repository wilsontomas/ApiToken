
namespace WFAppCRUD
{
    partial class Form1
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
            this.Pais = new System.Windows.Forms.ComboBox();
            this.Categoria = new System.Windows.Forms.ComboBox();
            this.Titulo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Articulolabel = new System.Windows.Forms.Label();
            this.Articulo = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pais";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categoria";
            // 
            // Pais
            // 
            this.Pais.FormattingEnabled = true;
            this.Pais.Location = new System.Drawing.Point(96, 59);
            this.Pais.Name = "Pais";
            this.Pais.Size = new System.Drawing.Size(121, 21);
            this.Pais.TabIndex = 3;
            this.Pais.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Categoria
            // 
            this.Categoria.FormattingEnabled = true;
            this.Categoria.Location = new System.Drawing.Point(96, 91);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(121, 21);
            this.Categoria.TabIndex = 4;
            // 
            // Titulo
            // 
            this.Titulo.Location = new System.Drawing.Point(96, 23);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(169, 20);
            this.Titulo.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Gaurdar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(253, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Articulolabel
            // 
            this.Articulolabel.AutoSize = true;
            this.Articulolabel.Location = new System.Drawing.Point(31, 124);
            this.Articulolabel.Name = "Articulolabel";
            this.Articulolabel.Size = new System.Drawing.Size(42, 13);
            this.Articulolabel.TabIndex = 9;
            this.Articulolabel.Text = "Articulo";
            // 
            // Articulo
            // 
            this.Articulo.Location = new System.Drawing.Point(96, 124);
            this.Articulo.Multiline = true;
            this.Articulo.Name = "Articulo";
            this.Articulo.Size = new System.Drawing.Size(169, 65);
            this.Articulo.TabIndex = 10;
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(34, 260);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(294, 150);
            this.dataGrid.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 450);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.Articulo);
            this.Controls.Add(this.Articulolabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.Categoria);
            this.Controls.Add(this.Pais);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Pais;
        private System.Windows.Forms.ComboBox Categoria;
        private System.Windows.Forms.TextBox Titulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Articulolabel;
        private System.Windows.Forms.TextBox Articulo;
        private System.Windows.Forms.DataGridView dataGrid;
    }
}

