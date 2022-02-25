
namespace AvaliaçãoBarigui
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtb_ValorEntrada = new System.Windows.Forms.TextBox();
            this.gb_Opções = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb_golt2 = new System.Windows.Forms.TextBox();
            this.txtb_golt1 = new System.Windows.Forms.TextBox();
            this.btn__LimparTela = new System.Windows.Forms.Button();
            this.rb_Resultado = new System.Windows.Forms.RichTextBox();
            this.txtb_SegundoValorEntrada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.rb_AlgoritmoPortugol = new System.Windows.Forms.RadioButton();
            this.rb_JogoFutebol = new System.Windows.Forms.RadioButton();
            this.txtb_Desconto = new System.Windows.Forms.TextBox();
            this.rb_HorasTrabalho = new System.Windows.Forms.RadioButton();
            this.rb_NumeroPN = new System.Windows.Forms.RadioButton();
            this.rb_MediaAluno = new System.Windows.Forms.RadioButton();
            this.rb_Maçãs = new System.Windows.Forms.RadioButton();
            this.gb_Opções.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtb_ValorEntrada
            // 
            this.txtb_ValorEntrada.Location = new System.Drawing.Point(187, 22);
            this.txtb_ValorEntrada.Name = "txtb_ValorEntrada";
            this.txtb_ValorEntrada.Size = new System.Drawing.Size(167, 23);
            this.txtb_ValorEntrada.TabIndex = 2;
            this.txtb_ValorEntrada.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_LimparText);
            this.txtb_ValorEntrada.TextChanged += new System.EventHandler(this.txtb_ValorEntrada_TextChanged);
            this.txtb_ValorEntrada.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.btn_DClick);
            // 
            // gb_Opções
            // 
            this.gb_Opções.Controls.Add(this.label3);
            this.gb_Opções.Controls.Add(this.txtb_golt2);
            this.gb_Opções.Controls.Add(this.txtb_golt1);
            this.gb_Opções.Controls.Add(this.btn__LimparTela);
            this.gb_Opções.Controls.Add(this.rb_Resultado);
            this.gb_Opções.Controls.Add(this.txtb_SegundoValorEntrada);
            this.gb_Opções.Controls.Add(this.label2);
            this.gb_Opções.Controls.Add(this.btn_Calcular);
            this.gb_Opções.Controls.Add(this.rb_AlgoritmoPortugol);
            this.gb_Opções.Controls.Add(this.rb_JogoFutebol);
            this.gb_Opções.Controls.Add(this.txtb_Desconto);
            this.gb_Opções.Controls.Add(this.rb_HorasTrabalho);
            this.gb_Opções.Controls.Add(this.rb_NumeroPN);
            this.gb_Opções.Controls.Add(this.rb_MediaAluno);
            this.gb_Opções.Controls.Add(this.txtb_ValorEntrada);
            this.gb_Opções.Controls.Add(this.rb_Maçãs);
            this.gb_Opções.Location = new System.Drawing.Point(12, 12);
            this.gb_Opções.Name = "gb_Opções";
            this.gb_Opções.Size = new System.Drawing.Size(366, 373);
            this.gb_Opções.TabIndex = 7;
            this.gb_Opções.TabStop = false;
            this.gb_Opções.Text = "Opções";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "x";
            // 
            // txtb_golt2
            // 
            this.txtb_golt2.Location = new System.Drawing.Point(289, 96);
            this.txtb_golt2.Name = "txtb_golt2";
            this.txtb_golt2.Size = new System.Drawing.Size(65, 23);
            this.txtb_golt2.TabIndex = 21;
            this.txtb_golt2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_LimparGol2);
            this.txtb_golt2.TextChanged += new System.EventHandler(this.txtb_golt2_TextChanged);
            // 
            // txtb_golt1
            // 
            this.txtb_golt1.Location = new System.Drawing.Point(187, 96);
            this.txtb_golt1.Name = "txtb_golt1";
            this.txtb_golt1.Size = new System.Drawing.Size(65, 23);
            this.txtb_golt1.TabIndex = 20;
            this.txtb_golt1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_LimparGol1);
            this.txtb_golt1.TextChanged += new System.EventHandler(this.txtb_golt1_TextChanged);
            // 
            // btn__LimparTela
            // 
            this.btn__LimparTela.Location = new System.Drawing.Point(6, 188);
            this.btn__LimparTela.Name = "btn__LimparTela";
            this.btn__LimparTela.Size = new System.Drawing.Size(75, 23);
            this.btn__LimparTela.TabIndex = 19;
            this.btn__LimparTela.Text = "Limpar tela";
            this.btn__LimparTela.UseVisualStyleBackColor = true;
            this.btn__LimparTela.Click += new System.EventHandler(this.btn__LimparTela_Click);
            // 
            // rb_Resultado
            // 
            this.rb_Resultado.Location = new System.Drawing.Point(6, 217);
            this.rb_Resultado.Name = "rb_Resultado";
            this.rb_Resultado.Size = new System.Drawing.Size(354, 150);
            this.rb_Resultado.TabIndex = 18;
            this.rb_Resultado.Text = "";
            this.rb_Resultado.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_LimparResultado);
            // 
            // txtb_SegundoValorEntrada
            // 
            this.txtb_SegundoValorEntrada.Location = new System.Drawing.Point(187, 60);
            this.txtb_SegundoValorEntrada.Name = "txtb_SegundoValorEntrada";
            this.txtb_SegundoValorEntrada.Size = new System.Drawing.Size(167, 23);
            this.txtb_SegundoValorEntrada.TabIndex = 17;
            this.txtb_SegundoValorEntrada.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_LimparText2);
            this.txtb_SegundoValorEntrada.TextChanged += new System.EventHandler(this.txtb_SegundoValorEntrada_TextChanged);
            this.txtb_SegundoValorEntrada.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.btn_DClick2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Desconto R$:";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(187, 144);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 8;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // rb_AlgoritmoPortugol
            // 
            this.rb_AlgoritmoPortugol.AutoSize = true;
            this.rb_AlgoritmoPortugol.Location = new System.Drawing.Point(6, 151);
            this.rb_AlgoritmoPortugol.Name = "rb_AlgoritmoPortugol";
            this.rb_AlgoritmoPortugol.Size = new System.Drawing.Size(148, 19);
            this.rb_AlgoritmoPortugol.TabIndex = 12;
            this.rb_AlgoritmoPortugol.TabStop = true;
            this.rb_AlgoritmoPortugol.Text = "Algoritmo em Portugol";
            this.rb_AlgoritmoPortugol.UseVisualStyleBackColor = true;
            this.rb_AlgoritmoPortugol.CheckedChanged += new System.EventHandler(this.rb_AlgoritmoPortugol_CheckedChanged);
            // 
            // rb_JogoFutebol
            // 
            this.rb_JogoFutebol.AutoSize = true;
            this.rb_JogoFutebol.Location = new System.Drawing.Point(6, 126);
            this.rb_JogoFutebol.Name = "rb_JogoFutebol";
            this.rb_JogoFutebol.Size = new System.Drawing.Size(109, 19);
            this.rb_JogoFutebol.TabIndex = 11;
            this.rb_JogoFutebol.TabStop = true;
            this.rb_JogoFutebol.Text = "Jogo de Futebol";
            this.rb_JogoFutebol.UseVisualStyleBackColor = true;
            this.rb_JogoFutebol.CheckedChanged += new System.EventHandler(this.rb_JogoFutebol_CheckedChanged);
            // 
            // txtb_Desconto
            // 
            this.txtb_Desconto.Location = new System.Drawing.Point(187, 188);
            this.txtb_Desconto.Name = "txtb_Desconto";
            this.txtb_Desconto.Size = new System.Drawing.Size(85, 23);
            this.txtb_Desconto.TabIndex = 14;
            this.txtb_Desconto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_LimparDesconto);
            this.txtb_Desconto.TextChanged += new System.EventHandler(this.txtb_Desconto_TextChanged);
            // 
            // rb_HorasTrabalho
            // 
            this.rb_HorasTrabalho.AutoSize = true;
            this.rb_HorasTrabalho.Location = new System.Drawing.Point(6, 101);
            this.rb_HorasTrabalho.Name = "rb_HorasTrabalho";
            this.rb_HorasTrabalho.Size = new System.Drawing.Size(104, 19);
            this.rb_HorasTrabalho.TabIndex = 10;
            this.rb_HorasTrabalho.TabStop = true;
            this.rb_HorasTrabalho.Text = "Horas Trabalho";
            this.rb_HorasTrabalho.UseVisualStyleBackColor = true;
            this.rb_HorasTrabalho.CheckedChanged += new System.EventHandler(this.rb_HorasTrabalho_CheckedChanged);
            // 
            // rb_NumeroPN
            // 
            this.rb_NumeroPN.AutoSize = true;
            this.rb_NumeroPN.Location = new System.Drawing.Point(6, 76);
            this.rb_NumeroPN.Name = "rb_NumeroPN";
            this.rb_NumeroPN.Size = new System.Drawing.Size(96, 19);
            this.rb_NumeroPN.TabIndex = 9;
            this.rb_NumeroPN.TabStop = true;
            this.rb_NumeroPN.Text = "Número + / -";
            this.rb_NumeroPN.UseVisualStyleBackColor = true;
            this.rb_NumeroPN.CheckedChanged += new System.EventHandler(this.rb_NumeroPN_CheckedChanged);
            // 
            // rb_MediaAluno
            // 
            this.rb_MediaAluno.AutoSize = true;
            this.rb_MediaAluno.Location = new System.Drawing.Point(6, 51);
            this.rb_MediaAluno.Name = "rb_MediaAluno";
            this.rb_MediaAluno.Size = new System.Drawing.Size(93, 19);
            this.rb_MediaAluno.TabIndex = 8;
            this.rb_MediaAluno.TabStop = true;
            this.rb_MediaAluno.Text = "Média Aluno";
            this.rb_MediaAluno.UseVisualStyleBackColor = true;
            this.rb_MediaAluno.CheckedChanged += new System.EventHandler(this.rb_MediaAluno_CheckedChanged);
            // 
            // rb_Maçãs
            // 
            this.rb_Maçãs.AutoSize = true;
            this.rb_Maçãs.Location = new System.Drawing.Point(6, 26);
            this.rb_Maçãs.Name = "rb_Maçãs";
            this.rb_Maçãs.Size = new System.Drawing.Size(82, 19);
            this.rb_Maçãs.TabIndex = 7;
            this.rb_Maçãs.TabStop = true;
            this.rb_Maçãs.Text = "Qtd Maçãs";
            this.rb_Maçãs.UseVisualStyleBackColor = true;
            this.rb_Maçãs.CheckedChanged += new System.EventHandler(this.rb_Maçãs_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 393);
            this.Controls.Add(this.gb_Opções);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Avaliação Barigui";
            this.gb_Opções.ResumeLayout(false);
            this.gb_Opções.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtb_ValorEntrada;
        private System.Windows.Forms.GroupBox gb_Opções;
        private System.Windows.Forms.RadioButton rb_AlgoritmoPortugol;
        private System.Windows.Forms.RadioButton rb_JogoFutebol;
        private System.Windows.Forms.RadioButton rb_HorasTrabalho;
        private System.Windows.Forms.RadioButton rb_NumeroPN;
        private System.Windows.Forms.RadioButton rb_MediaAluno;
        private System.Windows.Forms.RadioButton rb_Maçãs;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.TextBox txtb_Desconto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_SegundoValorEntrada;
        private System.Windows.Forms.RichTextBox rb_Resultado;
        private System.Windows.Forms.Button btn__LimparTela;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtb_golt2;
        private System.Windows.Forms.TextBox txtb_golt1;
    }
}

