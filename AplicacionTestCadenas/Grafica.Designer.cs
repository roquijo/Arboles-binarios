
namespace AplicacionTestCadenas
{
    partial class Grafica
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
            this.lienzo = new System.Windows.Forms.Panel();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lienzo
            // 
            this.lienzo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lienzo.Location = new System.Drawing.Point(12, 12);
            this.lienzo.Name = "lienzo";
            this.lienzo.Size = new System.Drawing.Size(1259, 661);
            this.lienzo.TabIndex = 0;
            // 
            // btnGraficar
            // 
            this.btnGraficar.Location = new System.Drawing.Point(618, 686);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(75, 23);
            this.btnGraficar.TabIndex = 1;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // Grafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 721);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.lienzo);
            this.Name = "Grafica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graficar Arbol";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lienzo;
        private System.Windows.Forms.Button btnGraficar;
    }
}