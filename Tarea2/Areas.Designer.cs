
namespace Tarea2
{
    partial class Areas
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
            this.label1 = new System.Windows.Forms.Label();
            this.areaCuadrado = new System.Windows.Forms.RadioButton();
            this.areaCirculo = new System.Windows.Forms.RadioButton();
            this.areaTriangulo = new System.Windows.Forms.RadioButton();
            this.areaRectangulo = new System.Windows.Forms.RadioButton();
            this.areaPentagono = new System.Windows.Forms.RadioButton();
            this.areaRombo = new System.Windows.Forms.RadioButton();
            this.areaRomboide = new System.Windows.Forms.RadioButton();
            this.areaTrapecio = new System.Windows.Forms.RadioButton();
            this.calcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.num3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "VAMOS A CALUCLAR AREAS";
            // 
            // areaCuadrado
            // 
            this.areaCuadrado.AutoSize = true;
            this.areaCuadrado.Location = new System.Drawing.Point(7, 7);
            this.areaCuadrado.Name = "areaCuadrado";
            this.areaCuadrado.Size = new System.Drawing.Size(71, 17);
            this.areaCuadrado.TabIndex = 1;
            this.areaCuadrado.TabStop = true;
            this.areaCuadrado.Text = "Cuadrado";
            this.areaCuadrado.UseVisualStyleBackColor = true;
            this.areaCuadrado.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // areaCirculo
            // 
            this.areaCirculo.AutoSize = true;
            this.areaCirculo.Location = new System.Drawing.Point(7, 30);
            this.areaCirculo.Name = "areaCirculo";
            this.areaCirculo.Size = new System.Drawing.Size(57, 17);
            this.areaCirculo.TabIndex = 2;
            this.areaCirculo.TabStop = true;
            this.areaCirculo.Text = "Circulo";
            this.areaCirculo.UseVisualStyleBackColor = true;
            this.areaCirculo.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // areaTriangulo
            // 
            this.areaTriangulo.AutoSize = true;
            this.areaTriangulo.Location = new System.Drawing.Point(7, 53);
            this.areaTriangulo.Name = "areaTriangulo";
            this.areaTriangulo.Size = new System.Drawing.Size(69, 17);
            this.areaTriangulo.TabIndex = 3;
            this.areaTriangulo.TabStop = true;
            this.areaTriangulo.Text = "Triangulo";
            this.areaTriangulo.UseVisualStyleBackColor = true;
            this.areaTriangulo.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // areaRectangulo
            // 
            this.areaRectangulo.AutoSize = true;
            this.areaRectangulo.Location = new System.Drawing.Point(7, 76);
            this.areaRectangulo.Name = "areaRectangulo";
            this.areaRectangulo.Size = new System.Drawing.Size(80, 17);
            this.areaRectangulo.TabIndex = 4;
            this.areaRectangulo.TabStop = true;
            this.areaRectangulo.Text = "Rectangulo";
            this.areaRectangulo.UseVisualStyleBackColor = true;
            this.areaRectangulo.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // areaPentagono
            // 
            this.areaPentagono.AutoSize = true;
            this.areaPentagono.Location = new System.Drawing.Point(139, 7);
            this.areaPentagono.Name = "areaPentagono";
            this.areaPentagono.Size = new System.Drawing.Size(77, 17);
            this.areaPentagono.TabIndex = 5;
            this.areaPentagono.TabStop = true;
            this.areaPentagono.Text = "Pentagono";
            this.areaPentagono.UseVisualStyleBackColor = true;
            this.areaPentagono.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // areaRombo
            // 
            this.areaRombo.AutoSize = true;
            this.areaRombo.Location = new System.Drawing.Point(139, 30);
            this.areaRombo.Name = "areaRombo";
            this.areaRombo.Size = new System.Drawing.Size(59, 17);
            this.areaRombo.TabIndex = 6;
            this.areaRombo.TabStop = true;
            this.areaRombo.Text = "Rombo";
            this.areaRombo.UseVisualStyleBackColor = true;
            this.areaRombo.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // areaRomboide
            // 
            this.areaRomboide.AutoSize = true;
            this.areaRomboide.Location = new System.Drawing.Point(139, 53);
            this.areaRomboide.Name = "areaRomboide";
            this.areaRomboide.Size = new System.Drawing.Size(73, 17);
            this.areaRomboide.TabIndex = 7;
            this.areaRomboide.TabStop = true;
            this.areaRomboide.Text = "Romboide";
            this.areaRomboide.UseVisualStyleBackColor = true;
            this.areaRomboide.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // areaTrapecio
            // 
            this.areaTrapecio.AutoSize = true;
            this.areaTrapecio.Location = new System.Drawing.Point(139, 76);
            this.areaTrapecio.Name = "areaTrapecio";
            this.areaTrapecio.Size = new System.Drawing.Size(67, 17);
            this.areaTrapecio.TabIndex = 8;
            this.areaTrapecio.TabStop = true;
            this.areaTrapecio.Text = "Trapecio";
            this.areaTrapecio.UseVisualStyleBackColor = true;
            this.areaTrapecio.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(101, 201);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(108, 25);
            this.calcular.TabIndex = 9;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Elige la figura de la que quieras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "obtener el calculo del area";
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(235, 221);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(79, 18);
            this.resultado.TabIndex = 13;
            this.resultado.Text = "Resultado:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.areaTrapecio);
            this.panel1.Controls.Add(this.areaRomboide);
            this.panel1.Controls.Add(this.areaRombo);
            this.panel1.Controls.Add(this.areaPentagono);
            this.panel1.Controls.Add(this.areaRectangulo);
            this.panel1.Controls.Add(this.areaTriangulo);
            this.panel1.Controls.Add(this.areaCirculo);
            this.panel1.Controls.Add(this.areaCuadrado);
            this.panel1.Location = new System.Drawing.Point(44, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 103);
            this.panel1.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(323, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 20);
            this.textBox1.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(323, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(54, 20);
            this.textBox2.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(323, 176);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(54, 20);
            this.textBox3.TabIndex = 24;
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.Location = new System.Drawing.Point(320, 77);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(0, 13);
            this.num1.TabIndex = 25;
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.Location = new System.Drawing.Point(320, 118);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(0, 13);
            this.num2.TabIndex = 26;
            // 
            // num3
            // 
            this.num3.AutoSize = true;
            this.num3.Location = new System.Drawing.Point(321, 160);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(0, 13);
            this.num3.TabIndex = 27;
            // 
            // Areas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(424, 253);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Areas";
            this.Text = "Areas \\\\ VIIKSEN //";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton areaCuadrado;
        private System.Windows.Forms.RadioButton areaCirculo;
        private System.Windows.Forms.RadioButton areaTriangulo;
        private System.Windows.Forms.RadioButton areaRectangulo;
        private System.Windows.Forms.RadioButton areaPentagono;
        private System.Windows.Forms.RadioButton areaRombo;
        private System.Windows.Forms.RadioButton areaRomboide;
        private System.Windows.Forms.RadioButton areaTrapecio;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.Label num3;
    }
}

