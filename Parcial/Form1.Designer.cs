
namespace Parcial
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtCantidaconomica = new System.Windows.Forms.TextBox();
            this.LblCantidadeconomica = new System.Windows.Forms.Label();
            this.txtValorapagar = new System.Windows.Forms.TextBox();
            this.LblValorapagar = new System.Windows.Forms.Label();
            this.LblImpuestos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(282, 208);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(118, 37);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtCantidaconomica
            // 
            this.txtCantidaconomica.Location = new System.Drawing.Point(300, 86);
            this.txtCantidaconomica.Name = "txtCantidaconomica";
            this.txtCantidaconomica.Size = new System.Drawing.Size(100, 20);
            this.txtCantidaconomica.TabIndex = 2;
            
            // 
            // LblCantidadeconomica
            // 
            this.LblCantidadeconomica.AutoSize = true;
            this.LblCantidadeconomica.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidadeconomica.Location = new System.Drawing.Point(121, 85);
            this.LblCantidadeconomica.Name = "LblCantidadeconomica";
            this.LblCantidadeconomica.Size = new System.Drawing.Size(168, 19);
            this.LblCantidadeconomica.TabIndex = 3;
            this.LblCantidadeconomica.Text = "Cantidad Economica";
            this.LblCantidadeconomica.Click += new System.EventHandler(this.LblCantidadeconomica_Click);
            // 
            // txtValorapagar
            // 
            this.txtValorapagar.Location = new System.Drawing.Point(300, 143);
            this.txtValorapagar.Name = "txtValorapagar";
            this.txtValorapagar.Size = new System.Drawing.Size(100, 20);
            this.txtValorapagar.TabIndex = 4;
           
            // 
            // LblValorapagar
            // 
            this.LblValorapagar.AutoSize = true;
            this.LblValorapagar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValorapagar.Location = new System.Drawing.Point(125, 142);
            this.LblValorapagar.Name = "LblValorapagar";
            this.LblValorapagar.Size = new System.Drawing.Size(110, 19);
            this.LblValorapagar.TabIndex = 5;
            this.LblValorapagar.Text = "Valor a Pagar";
            
            // 
            // LblImpuestos
            // 
            this.LblImpuestos.AutoSize = true;
            this.LblImpuestos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImpuestos.Location = new System.Drawing.Point(278, 27);
            this.LblImpuestos.Name = "LblImpuestos";
            this.LblImpuestos.Size = new System.Drawing.Size(125, 22);
            this.LblImpuestos.TabIndex = 6;
            this.LblImpuestos.Text = "IMPUESTOS";
           
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblImpuestos);
            this.Controls.Add(this.LblValorapagar);
            this.Controls.Add(this.txtValorapagar);
            this.Controls.Add(this.LblCantidadeconomica);
            this.Controls.Add(this.txtCantidaconomica);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtCantidaconomica;
        private System.Windows.Forms.Label LblCantidadeconomica;
        private System.Windows.Forms.TextBox txtValorapagar;
        private System.Windows.Forms.Label LblValorapagar;
        private System.Windows.Forms.Label LblImpuestos;
    }
}

