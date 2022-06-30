
namespace Mercado
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
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btCalcular = new System.Windows.Forms.Button();
            this.tbQtd = new System.Windows.Forms.TextBox();
            this.tbValorUnitario = new System.Windows.Forms.TextBox();
            this.labelCódigo = new System.Windows.Forms.Label();
            this.labelQtd = new System.Windows.Forms.Label();
            this.labelValorUnitario = new System.Windows.Forms.Label();
            this.radioButtonAVista = new System.Windows.Forms.RadioButton();
            this.radioButtonCartao = new System.Windows.Forms.RadioButton();
            this.labelTotalaVista = new System.Windows.Forms.Label();
            this.labelTotalCartao = new System.Windows.Forms.Label();
            this.tbTotalAVista = new System.Windows.Forms.TextBox();
            this.tbTotalCartao = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(107, 31);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(93, 20);
            this.tbCodigo.TabIndex = 0;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(661, 311);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(77, 53);
            this.btLimpar.TabIndex = 1;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(179, 195);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 53);
            this.btCalcular.TabIndex = 2;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // tbQtd
            // 
            this.tbQtd.Location = new System.Drawing.Point(375, 31);
            this.tbQtd.Name = "tbQtd";
            this.tbQtd.Size = new System.Drawing.Size(74, 20);
            this.tbQtd.TabIndex = 3;
            // 
            // tbValorUnitario
            // 
            this.tbValorUnitario.Location = new System.Drawing.Point(679, 31);
            this.tbValorUnitario.Name = "tbValorUnitario";
            this.tbValorUnitario.Size = new System.Drawing.Size(90, 20);
            this.tbValorUnitario.TabIndex = 4;
            // 
            // labelCódigo
            // 
            this.labelCódigo.AutoSize = true;
            this.labelCódigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCódigo.Location = new System.Drawing.Point(28, 31);
            this.labelCódigo.Name = "labelCódigo";
            this.labelCódigo.Size = new System.Drawing.Size(59, 20);
            this.labelCódigo.TabIndex = 5;
            this.labelCódigo.Text = "Código";
            // 
            // labelQtd
            // 
            this.labelQtd.AutoSize = true;
            this.labelQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQtd.Location = new System.Drawing.Point(312, 31);
            this.labelQtd.Name = "labelQtd";
            this.labelQtd.Size = new System.Drawing.Size(35, 20);
            this.labelQtd.TabIndex = 6;
            this.labelQtd.Text = "Qtd";
            // 
            // labelValorUnitario
            // 
            this.labelValorUnitario.AutoSize = true;
            this.labelValorUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorUnitario.Location = new System.Drawing.Point(543, 31);
            this.labelValorUnitario.Name = "labelValorUnitario";
            this.labelValorUnitario.Size = new System.Drawing.Size(105, 20);
            this.labelValorUnitario.TabIndex = 7;
            this.labelValorUnitario.Text = "Valor Unitário";
            // 
            // radioButtonAVista
            // 
            this.radioButtonAVista.AutoSize = true;
            this.radioButtonAVista.Location = new System.Drawing.Point(107, 138);
            this.radioButtonAVista.Name = "radioButtonAVista";
            this.radioButtonAVista.Size = new System.Drawing.Size(57, 17);
            this.radioButtonAVista.TabIndex = 8;
            this.radioButtonAVista.TabStop = true;
            this.radioButtonAVista.Text = "À vista";
            this.radioButtonAVista.UseVisualStyleBackColor = true;
            // 
            // radioButtonCartao
            // 
            this.radioButtonCartao.AutoSize = true;
            this.radioButtonCartao.Location = new System.Drawing.Point(268, 138);
            this.radioButtonCartao.Name = "radioButtonCartao";
            this.radioButtonCartao.Size = new System.Drawing.Size(58, 17);
            this.radioButtonCartao.TabIndex = 9;
            this.radioButtonCartao.TabStop = true;
            this.radioButtonCartao.Text = "Crédito";
            this.radioButtonCartao.UseVisualStyleBackColor = true;
            // 
            // labelTotalaVista
            // 
            this.labelTotalaVista.AutoSize = true;
            this.labelTotalaVista.Location = new System.Drawing.Point(107, 351);
            this.labelTotalaVista.Name = "labelTotalaVista";
            this.labelTotalaVista.Size = new System.Drawing.Size(66, 13);
            this.labelTotalaVista.TabIndex = 10;
            this.labelTotalaVista.Text = "Total a Vista";
            // 
            // labelTotalCartao
            // 
            this.labelTotalCartao.AutoSize = true;
            this.labelTotalCartao.Location = new System.Drawing.Point(298, 351);
            this.labelTotalCartao.Name = "labelTotalCartao";
            this.labelTotalCartao.Size = new System.Drawing.Size(65, 13);
            this.labelTotalCartao.TabIndex = 11;
            this.labelTotalCartao.Text = "Total Cartão";
            // 
            // tbTotalAVista
            // 
            this.tbTotalAVista.Location = new System.Drawing.Point(179, 348);
            this.tbTotalAVista.Name = "tbTotalAVista";
            this.tbTotalAVista.Size = new System.Drawing.Size(88, 20);
            this.tbTotalAVista.TabIndex = 12;
            // 
            // tbTotalCartao
            // 
            this.tbTotalCartao.Location = new System.Drawing.Point(375, 348);
            this.tbTotalCartao.Name = "tbTotalCartao";
            this.tbTotalCartao.Size = new System.Drawing.Size(100, 20);
            this.tbTotalCartao.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(81, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 91);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formas de Pagamento";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 413);
            this.Controls.Add(this.tbTotalCartao);
            this.Controls.Add(this.tbTotalAVista);
            this.Controls.Add(this.labelTotalCartao);
            this.Controls.Add(this.labelTotalaVista);
            this.Controls.Add(this.radioButtonCartao);
            this.Controls.Add(this.radioButtonAVista);
            this.Controls.Add(this.labelValorUnitario);
            this.Controls.Add(this.labelQtd);
            this.Controls.Add(this.labelCódigo);
            this.Controls.Add(this.tbValorUnitario);
            this.Controls.Add(this.tbQtd);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.TextBox tbQtd;
        private System.Windows.Forms.TextBox tbValorUnitario;
        private System.Windows.Forms.Label labelCódigo;
        private System.Windows.Forms.Label labelQtd;
        private System.Windows.Forms.Label labelValorUnitario;
        private System.Windows.Forms.RadioButton radioButtonAVista;
        private System.Windows.Forms.RadioButton radioButtonCartao;
        private System.Windows.Forms.Label labelTotalaVista;
        private System.Windows.Forms.Label labelTotalCartao;
        private System.Windows.Forms.TextBox tbTotalAVista;
        private System.Windows.Forms.TextBox tbTotalCartao;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

