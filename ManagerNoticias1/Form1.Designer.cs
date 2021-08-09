
namespace ManagerNoticias1
{
    partial class Clave
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
            this.Usuario = new System.Windows.Forms.TextBox();
            this.clavetxt = new System.Windows.Forms.TextBox();
            this.Ingresar = new System.Windows.Forms.Button();
            this.Mensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave";
            // 
            // Usuario
            // 
            this.Usuario.Location = new System.Drawing.Point(134, 33);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(127, 20);
            this.Usuario.TabIndex = 2;
            // 
            // clavetxt
            // 
            this.clavetxt.Location = new System.Drawing.Point(134, 72);
            this.clavetxt.Name = "clavetxt";
            this.clavetxt.Size = new System.Drawing.Size(127, 20);
            this.clavetxt.TabIndex = 3;
            // 
            // Ingresar
            // 
            this.Ingresar.Location = new System.Drawing.Point(134, 133);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(75, 23);
            this.Ingresar.TabIndex = 4;
            this.Ingresar.Text = "Ingresar";
            this.Ingresar.UseVisualStyleBackColor = true;
            this.Ingresar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // Mensaje
            // 
            this.Mensaje.AutoSize = true;
            this.Mensaje.Location = new System.Drawing.Point(134, 99);
            this.Mensaje.Name = "Mensaje";
            this.Mensaje.Size = new System.Drawing.Size(0, 13);
            this.Mensaje.TabIndex = 5;
            // 
            // Clave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 314);
            this.Controls.Add(this.Mensaje);
            this.Controls.Add(this.Ingresar);
            this.Controls.Add(this.clavetxt);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Clave";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.TextBox clavetxt;
        private System.Windows.Forms.Button Ingresar;
        private System.Windows.Forms.Label Mensaje;
    }
}

