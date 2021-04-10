namespace TesteTrabEnok2
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
            this.canvas = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.procurar = new System.Windows.Forms.Button();
            this.criar = new System.Windows.Forms.Button();
            this.resetar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.canvas.Location = new System.Drawing.Point(0, 46);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(474, 404);
            this.canvas.TabIndex = 0;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.procurar);
            this.panel1.Controls.Add(this.criar);
            this.panel1.Controls.Add(this.resetar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 45);
            this.panel1.TabIndex = 1;
            // 
            // procurar
            // 
            this.procurar.Location = new System.Drawing.Point(93, 11);
            this.procurar.Name = "procurar";
            this.procurar.Size = new System.Drawing.Size(130, 23);
            this.procurar.TabIndex = 2;
            this.procurar.Text = "Busca Menor Primeiro";
            this.procurar.UseVisualStyleBackColor = true;
            this.procurar.Click += new System.EventHandler(this.procurar_Click);
            // 
            // criar
            // 
            this.criar.Location = new System.Drawing.Point(12, 12);
            this.criar.Name = "criar";
            this.criar.Size = new System.Drawing.Size(75, 23);
            this.criar.TabIndex = 1;
            this.criar.Text = "Criar Labirinto";
            this.criar.UseVisualStyleBackColor = true;
            this.criar.Click += new System.EventHandler(this.criar_Click);
            // 
            // resetar
            // 
            this.resetar.Location = new System.Drawing.Point(386, 11);
            this.resetar.Name = "resetar";
            this.resetar.Size = new System.Drawing.Size(75, 23);
            this.resetar.TabIndex = 0;
            this.resetar.Text = "Resetar";
            this.resetar.UseVisualStyleBackColor = true;
            this.resetar.Click += new System.EventHandler(this.resetar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(480, 0);
            this.txtValor.Multiline = true;
            this.txtValor.Name = "txtValor";
            this.txtValor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtValor.Size = new System.Drawing.Size(215, 450);
            this.txtValor.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Labirinto";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button resetar;
        private System.Windows.Forms.Button criar;
        private System.Windows.Forms.Button procurar;
        private System.Windows.Forms.TextBox txtValor;
    }
}

