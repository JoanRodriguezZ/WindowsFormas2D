
namespace WindowsFormas2D
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRectangulo = new System.Windows.Forms.Button();
            this.btnTriangulo = new System.Windows.Forms.Button();
            this.btnCirculo = new System.Windows.Forms.Button();
            this.listBoxFiguras2D = new System.Windows.Forms.ListBox();
            this.btnFiguraRandom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRectangulo
            // 
            this.btnRectangulo.Location = new System.Drawing.Point(40, 40);
            this.btnRectangulo.Name = "btnRectangulo";
            this.btnRectangulo.Size = new System.Drawing.Size(94, 37);
            this.btnRectangulo.TabIndex = 0;
            this.btnRectangulo.Text = "Rectangulo";
            this.btnRectangulo.UseVisualStyleBackColor = true;
            this.btnRectangulo.Click += new System.EventHandler(this.btnRectangulo_Click);
            // 
            // btnTriangulo
            // 
            this.btnTriangulo.Location = new System.Drawing.Point(40, 110);
            this.btnTriangulo.Name = "btnTriangulo";
            this.btnTriangulo.Size = new System.Drawing.Size(94, 36);
            this.btnTriangulo.TabIndex = 1;
            this.btnTriangulo.Text = "Triangulo";
            this.btnTriangulo.UseVisualStyleBackColor = true;
            this.btnTriangulo.Click += new System.EventHandler(this.btnTriangulo_Click);
            // 
            // btnCirculo
            // 
            this.btnCirculo.Location = new System.Drawing.Point(40, 186);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(94, 34);
            this.btnCirculo.TabIndex = 2;
            this.btnCirculo.Text = "Circulo";
            this.btnCirculo.UseVisualStyleBackColor = true;
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // listBoxFiguras2D
            // 
            this.listBoxFiguras2D.FormattingEnabled = true;
            this.listBoxFiguras2D.ItemHeight = 16;
            this.listBoxFiguras2D.Location = new System.Drawing.Point(178, 40);
            this.listBoxFiguras2D.Name = "listBoxFiguras2D";
            this.listBoxFiguras2D.Size = new System.Drawing.Size(401, 372);
            this.listBoxFiguras2D.TabIndex = 3;
            this.listBoxFiguras2D.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxFiguras2D_MouseClick);
            // 
            // btnFiguraRandom
            // 
            this.btnFiguraRandom.Location = new System.Drawing.Point(21, 272);
            this.btnFiguraRandom.Name = "btnFiguraRandom";
            this.btnFiguraRandom.Size = new System.Drawing.Size(133, 42);
            this.btnFiguraRandom.TabIndex = 4;
            this.btnFiguraRandom.Text = "Crear forma";
            this.btnFiguraRandom.UseVisualStyleBackColor = true;
            this.btnFiguraRandom.Click += new System.EventHandler(this.btnFiguraRandom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 462);
            this.Controls.Add(this.btnFiguraRandom);
            this.Controls.Add(this.listBoxFiguras2D);
            this.Controls.Add(this.btnCirculo);
            this.Controls.Add(this.btnTriangulo);
            this.Controls.Add(this.btnRectangulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRectangulo;
        private System.Windows.Forms.Button btnTriangulo;
        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.ListBox listBoxFiguras2D;
        private System.Windows.Forms.Button btnFiguraRandom;
    }
}

