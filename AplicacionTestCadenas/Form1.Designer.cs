namespace AplicacionTestCadenas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.btnContarCarateres = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLocalizarCaracter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCaracter = new System.Windows.Forms.TextBox();
            this.btnRecorrerContando = new System.Windows.Forms.Button();
            this.btnQuitarParentesi = new System.Windows.Forms.Button();
            this.btnQuitarEspacios = new System.Windows.Forms.Button();
            this.btnEncontrarOperadorCentral = new System.Windows.Forms.Button();
            this.btnAtomica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadena : ";
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(86, 19);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(347, 20);
            this.txtCadena.TabIndex = 1;
            this.txtCadena.Text = "(1+1)*(1/0)";
            // 
            // btnContarCarateres
            // 
            this.btnContarCarateres.Location = new System.Drawing.Point(348, 69);
            this.btnContarCarateres.Name = "btnContarCarateres";
            this.btnContarCarateres.Size = new System.Drawing.Size(85, 23);
            this.btnContarCarateres.TabIndex = 2;
            this.btnContarCarateres.Text = "Contar";
            this.btnContarCarateres.UseVisualStyleBackColor = true;
            this.btnContarCarateres.Click += new System.EventHandler(this.btnContarCarateres_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(86, 93);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(160, 20);
            this.txtResultado.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resultado = ";
            // 
            // btnLocalizarCaracter
            // 
            this.btnLocalizarCaracter.Location = new System.Drawing.Point(348, 112);
            this.btnLocalizarCaracter.Name = "btnLocalizarCaracter";
            this.btnLocalizarCaracter.Size = new System.Drawing.Size(85, 25);
            this.btnLocalizarCaracter.TabIndex = 5;
            this.btnLocalizarCaracter.Text = "Localizar";
            this.btnLocalizarCaracter.UseVisualStyleBackColor = true;
            this.btnLocalizarCaracter.Click += new System.EventHandler(this.btnLocalizarCaracter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Caracter : ";
            // 
            // txtCaracter
            // 
            this.txtCaracter.Location = new System.Drawing.Point(86, 57);
            this.txtCaracter.Name = "txtCaracter";
            this.txtCaracter.Size = new System.Drawing.Size(160, 20);
            this.txtCaracter.TabIndex = 7;
            this.txtCaracter.Text = "1";
            // 
            // btnRecorrerContando
            // 
            this.btnRecorrerContando.Location = new System.Drawing.Point(348, 155);
            this.btnRecorrerContando.Name = "btnRecorrerContando";
            this.btnRecorrerContando.Size = new System.Drawing.Size(85, 23);
            this.btnRecorrerContando.TabIndex = 8;
            this.btnRecorrerContando.Text = "Recorrer cont";
            this.btnRecorrerContando.UseVisualStyleBackColor = true;
            // 
            // btnQuitarParentesi
            // 
            this.btnQuitarParentesi.Location = new System.Drawing.Point(241, 155);
            this.btnQuitarParentesi.Name = "btnQuitarParentesi";
            this.btnQuitarParentesi.Size = new System.Drawing.Size(75, 23);
            this.btnQuitarParentesi.TabIndex = 9;
            this.btnQuitarParentesi.Text = "Quitar Par";
            this.btnQuitarParentesi.UseVisualStyleBackColor = true;
            this.btnQuitarParentesi.Click += new System.EventHandler(this.btnQuitarParentesi_Click);
            // 
            // btnQuitarEspacios
            // 
            this.btnQuitarEspacios.Location = new System.Drawing.Point(16, 155);
            this.btnQuitarEspacios.Name = "btnQuitarEspacios";
            this.btnQuitarEspacios.Size = new System.Drawing.Size(75, 23);
            this.btnQuitarEspacios.TabIndex = 10;
            this.btnQuitarEspacios.Text = "Quitar Esp";
            this.btnQuitarEspacios.UseVisualStyleBackColor = true;
            this.btnQuitarEspacios.Click += new System.EventHandler(this.btnQuitarEspacios_Click);
            // 
            // btnEncontrarOperadorCentral
            // 
            this.btnEncontrarOperadorCentral.Location = new System.Drawing.Point(112, 155);
            this.btnEncontrarOperadorCentral.Name = "btnEncontrarOperadorCentral";
            this.btnEncontrarOperadorCentral.Size = new System.Drawing.Size(105, 23);
            this.btnEncontrarOperadorCentral.TabIndex = 11;
            this.btnEncontrarOperadorCentral.Text = "Encontrar Op Cen";
            this.btnEncontrarOperadorCentral.UseVisualStyleBackColor = true;
            this.btnEncontrarOperadorCentral.Click += new System.EventHandler(this.btnEncontrarOperadorCentral_Click);
            // 
            // btnAtomica
            // 
            this.btnAtomica.Location = new System.Drawing.Point(205, 214);
            this.btnAtomica.Name = "btnAtomica";
            this.btnAtomica.Size = new System.Drawing.Size(75, 23);
            this.btnAtomica.TabIndex = 12;
            this.btnAtomica.Text = "Es atomica";
            this.btnAtomica.UseVisualStyleBackColor = true;
            this.btnAtomica.Click += new System.EventHandler(this.btnAtomica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 286);
            this.Controls.Add(this.btnAtomica);
            this.Controls.Add(this.btnEncontrarOperadorCentral);
            this.Controls.Add(this.btnQuitarEspacios);
            this.Controls.Add(this.btnQuitarParentesi);
            this.Controls.Add(this.btnRecorrerContando);
            this.Controls.Add(this.txtCaracter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLocalizarCaracter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnContarCarateres);
            this.Controls.Add(this.txtCadena);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prueba con Cadenas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.Button btnContarCarateres;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLocalizarCaracter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCaracter;
        private System.Windows.Forms.Button btnRecorrerContando;
        private System.Windows.Forms.Button btnQuitarParentesi;
        private System.Windows.Forms.Button btnQuitarEspacios;
        private System.Windows.Forms.Button btnEncontrarOperadorCentral;
        private System.Windows.Forms.Button btnAtomica;
    }
}

