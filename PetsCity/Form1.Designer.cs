namespace PetsCity
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
            lblQuantidadeBanhosMensais = new Label();
            lblNomePet = new Label();
            txtNomePet = new TextBox();
            txtPrecoServico = new TextBox();
            llblPrecoServico = new Label();
            txtBanhosMensais = new TextBox();
            txtIdadeAnimal = new TextBox();
            lblIdadeAnimal = new Label();
            lblNome = new Label();
            lblIdade = new Label();
            lblDescontoFidelidade = new Label();
            lblValorParcela = new Label();
            btnCalcular = new Button();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // lblQuantidadeBanhosMensais
            // 
            lblQuantidadeBanhosMensais.AutoSize = true;
            lblQuantidadeBanhosMensais.Location = new Point(293, 171);
            lblQuantidadeBanhosMensais.Name = "lblQuantidadeBanhosMensais";
            lblQuantidadeBanhosMensais.Size = new Size(92, 15);
            lblQuantidadeBanhosMensais.TabIndex = 0;
            lblQuantidadeBanhosMensais.Text = "Banhos Mensais";
            // 
            // lblNomePet
            // 
            lblNomePet.AutoSize = true;
            lblNomePet.Location = new Point(293, 37);
            lblNomePet.Name = "lblNomePet";
            lblNomePet.Size = new Size(57, 15);
            lblNomePet.TabIndex = 1;
            lblNomePet.Text = "NomePet";
            // 
            // txtNomePet
            // 
            txtNomePet.Location = new Point(387, 37);
            txtNomePet.Name = "txtNomePet";
            txtNomePet.Size = new Size(100, 23);
            txtNomePet.TabIndex = 2;
            // 
            // txtPrecoServico
            // 
            txtPrecoServico.Location = new Point(387, 107);
            txtPrecoServico.Name = "txtPrecoServico";
            txtPrecoServico.Size = new Size(100, 23);
            txtPrecoServico.TabIndex = 4;
            // 
            // llblPrecoServico
            // 
            llblPrecoServico.AutoSize = true;
            llblPrecoServico.Location = new Point(293, 107);
            llblPrecoServico.Name = "llblPrecoServico";
            llblPrecoServico.Size = new Size(78, 15);
            llblPrecoServico.TabIndex = 3;
            llblPrecoServico.Text = "Preço Serviço";
            // 
            // txtBanhosMensais
            // 
            txtBanhosMensais.Location = new Point(391, 171);
            txtBanhosMensais.Name = "txtBanhosMensais";
            txtBanhosMensais.Size = new Size(100, 23);
            txtBanhosMensais.TabIndex = 6;
            // 
            // txtIdadeAnimal
            // 
            txtIdadeAnimal.Location = new Point(387, 244);
            txtIdadeAnimal.Name = "txtIdadeAnimal";
            txtIdadeAnimal.Size = new Size(100, 23);
            txtIdadeAnimal.TabIndex = 8;
            // 
            // lblIdadeAnimal
            // 
            lblIdadeAnimal.AutoSize = true;
            lblIdadeAnimal.Location = new Point(294, 247);
            lblIdadeAnimal.Name = "lblIdadeAnimal";
            lblIdadeAnimal.Size = new Size(77, 15);
            lblIdadeAnimal.TabIndex = 7;
            lblIdadeAnimal.Text = "Idade Animal";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(342, 310);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 9;
            lblNome.Text = "Nome";
            lblNome.Click += label6_Click;
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Location = new Point(342, 348);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(36, 15);
            lblIdade.TabIndex = 10;
            lblIdade.Text = "Idade";
            // 
            // lblDescontoFidelidade
            // 
            lblDescontoFidelidade.AutoSize = true;
            lblDescontoFidelidade.Location = new Point(342, 391);
            lblDescontoFidelidade.Name = "lblDescontoFidelidade";
            lblDescontoFidelidade.Size = new Size(60, 15);
            lblDescontoFidelidade.TabIndex = 11;
            lblDescontoFidelidade.Text = "Desconto ";
            lblDescontoFidelidade.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblValorParcela
            // 
            lblValorParcela.AutoSize = true;
            lblValorParcela.Location = new Point(342, 431);
            lblValorParcela.Name = "lblValorParcela";
            lblValorParcela.Size = new Size(45, 15);
            lblValorParcela.TabIndex = 12;
            lblValorParcela.Text = "Parcela";
            lblValorParcela.Click += label9_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(329, 503);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(73, 27);
            btnCalcular.TabIndex = 14;
            btnCalcular.Text = "button2";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(347, 466);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 15;
            lblStatus.Text = "Status";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 615);
            Controls.Add(lblStatus);
            Controls.Add(btnCalcular);
            Controls.Add(lblValorParcela);
            Controls.Add(lblDescontoFidelidade);
            Controls.Add(lblIdade);
            Controls.Add(lblNome);
            Controls.Add(txtIdadeAnimal);
            Controls.Add(lblIdadeAnimal);
            Controls.Add(txtBanhosMensais);
            Controls.Add(txtPrecoServico);
            Controls.Add(llblPrecoServico);
            Controls.Add(txtNomePet);
            Controls.Add(lblNomePet);
            Controls.Add(lblQuantidadeBanhosMensais);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuantidadeBanhosMensais;
        private Label lblNomePet;
        private TextBox txtNomePet;
        private TextBox txtPrecoServico;
        private Label llblPrecoServico;
        private TextBox txtBanhosMensais;
        private TextBox txtIdadeAnimal;
        private Label lblIdadeAnimal;
        private Label lblNome;
        private Label lblIdade;
        private Label lblDescontoFidelidade;
        private Label lblValorParcela;
        private Button button1;
        private Button btnCalcular;
        private Label lblStatus;
    }
}
