namespace Calculadora_Basica
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rd1Som = new System.Windows.Forms.RadioButton();
            this.rd2Sub = new System.Windows.Forms.RadioButton();
            this.rd3Mult = new System.Windows.Forms.RadioButton();
            this.rd4Div = new System.Windows.Forms.RadioButton();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.lbloperacao = new System.Windows.Forms.Label();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.rd5Porcen = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rd1Som
            // 
            this.rd1Som.AutoSize = true;
            this.rd1Som.BackColor = System.Drawing.Color.Transparent;
            this.rd1Som.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd1Som.ForeColor = System.Drawing.Color.White;
            this.rd1Som.Location = new System.Drawing.Point(48, 36);
            this.rd1Som.Name = "rd1Som";
            this.rd1Som.Size = new System.Drawing.Size(40, 28);
            this.rd1Som.TabIndex = 0;
            this.rd1Som.TabStop = true;
            this.rd1Som.Text = "+";
            this.rd1Som.UseVisualStyleBackColor = false;
            this.rd1Som.CheckedChanged += new System.EventHandler(this.rd1Som_CheckedChanged);
            // 
            // rd2Sub
            // 
            this.rd2Sub.AutoSize = true;
            this.rd2Sub.BackColor = System.Drawing.Color.Transparent;
            this.rd2Sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd2Sub.ForeColor = System.Drawing.Color.White;
            this.rd2Sub.Location = new System.Drawing.Point(137, 36);
            this.rd2Sub.Name = "rd2Sub";
            this.rd2Sub.Size = new System.Drawing.Size(35, 28);
            this.rd2Sub.TabIndex = 1;
            this.rd2Sub.TabStop = true;
            this.rd2Sub.Text = "-";
            this.rd2Sub.UseVisualStyleBackColor = false;
            // 
            // rd3Mult
            // 
            this.rd3Mult.AutoSize = true;
            this.rd3Mult.BackColor = System.Drawing.Color.Transparent;
            this.rd3Mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd3Mult.ForeColor = System.Drawing.Color.White;
            this.rd3Mult.Location = new System.Drawing.Point(226, 36);
            this.rd3Mult.Name = "rd3Mult";
            this.rd3Mult.Size = new System.Drawing.Size(39, 28);
            this.rd3Mult.TabIndex = 2;
            this.rd3Mult.TabStop = true;
            this.rd3Mult.Text = "x";
            this.rd3Mult.UseVisualStyleBackColor = false;
            // 
            // rd4Div
            // 
            this.rd4Div.AutoSize = true;
            this.rd4Div.BackColor = System.Drawing.Color.Transparent;
            this.rd4Div.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd4Div.ForeColor = System.Drawing.Color.White;
            this.rd4Div.Location = new System.Drawing.Point(315, 36);
            this.rd4Div.Name = "rd4Div";
            this.rd4Div.Size = new System.Drawing.Size(34, 28);
            this.rd4Div.TabIndex = 3;
            this.rd4Div.TabStop = true;
            this.rd4Div.Text = "/";
            this.rd4Div.UseVisualStyleBackColor = false;
            // 
            // txtValor1
            // 
            this.txtValor1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtValor1.Location = new System.Drawing.Point(106, 104);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(108, 20);
            this.txtValor1.TabIndex = 4;
            this.txtValor1.Text = "Digite o primeiro valor";
            this.txtValor1.Click += new System.EventHandler(this.txtValor1_Click);
            // 
            // txtValor2
            // 
            this.txtValor2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtValor2.Location = new System.Drawing.Point(242, 104);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(114, 20);
            this.txtValor2.TabIndex = 5;
            this.txtValor2.Text = "Digite o segundo valor";
            this.txtValor2.Click += new System.EventHandler(this.txtValor2_Click);
            // 
            // lbloperacao
            // 
            this.lbloperacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbloperacao.AutoSize = true;
            this.lbloperacao.BackColor = System.Drawing.Color.Transparent;
            this.lbloperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloperacao.ForeColor = System.Drawing.Color.White;
            this.lbloperacao.Location = new System.Drawing.Point(216, 104);
            this.lbloperacao.Name = "lbloperacao";
            this.lbloperacao.Size = new System.Drawing.Size(24, 20);
            this.lbloperacao.TabIndex = 6;
            this.lbloperacao.Text = "...";
            // 
            // btnExecutar
            // 
            this.btnExecutar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExecutar.Location = new System.Drawing.Point(156, 171);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(145, 23);
            this.btnExecutar.TabIndex = 8;
            this.btnExecutar.Text = "Calcular";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click_1);
            // 
            // rd5Porcen
            // 
            this.rd5Porcen.AutoSize = true;
            this.rd5Porcen.BackColor = System.Drawing.Color.Transparent;
            this.rd5Porcen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd5Porcen.ForeColor = System.Drawing.Color.White;
            this.rd5Porcen.Location = new System.Drawing.Point(378, 36);
            this.rd5Porcen.Name = "rd5Porcen";
            this.rd5Porcen.Size = new System.Drawing.Size(44, 28);
            this.rd5Porcen.TabIndex = 9;
            this.rd5Porcen.TabStop = true;
            this.rd5Porcen.Text = "%";
            this.rd5Porcen.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(450, 263);
            this.Controls.Add(this.rd5Porcen);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.lbloperacao);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.rd4Div);
            this.Controls.Add(this.rd3Mult);
            this.Controls.Add(this.rd2Sub);
            this.Controls.Add(this.rd1Som);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Basica - v.01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rd1Som;
        private System.Windows.Forms.RadioButton rd2Sub;
        private System.Windows.Forms.RadioButton rd3Mult;
        private System.Windows.Forms.RadioButton rd4Div;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label lbloperacao;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.RadioButton rd5Porcen;
    }
}

