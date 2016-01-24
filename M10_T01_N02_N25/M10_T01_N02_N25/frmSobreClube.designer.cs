namespace M10_T01_N02_N25
{
    partial class frmSobreClube
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSobreClube));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpgPresidente = new System.Windows.Forms.TabPage();
            this.btnEditarPresidente = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCpPresidente = new System.Windows.Forms.Label();
            this.lblLocalidadePresidente = new System.Windows.Forms.Label();
            this.lblRuaPresidente = new System.Windows.Forms.Label();
            this.picFotoPerfilPresidente = new System.Windows.Forms.PictureBox();
            this.lblNomePresidente = new System.Windows.Forms.Label();
            this.lblIdadePresidente = new System.Windows.Forms.Label();
            this.tbpgTreinador = new System.Windows.Forms.TabPage();
            this.btnEditarTreinador = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCpTreinador = new System.Windows.Forms.Label();
            this.lblLocalidadeTreinador = new System.Windows.Forms.Label();
            this.lblRuaTreinador = new System.Windows.Forms.Label();
            this.picFotoPerfilTreinador = new System.Windows.Forms.PictureBox();
            this.lblNomeTreinador = new System.Windows.Forms.Label();
            this.lblIdadeTreinador = new System.Windows.Forms.Label();
            this.picLogoClube = new System.Windows.Forms.PictureBox();
            this.lblNomeClube = new System.Windows.Forms.Label();
            this.lblDataFundacao = new System.Windows.Forms.Label();
            this.lblNsocios = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblNatletas = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbpgPresidente.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoPerfilPresidente)).BeginInit();
            this.tbpgTreinador.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoPerfilTreinador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoClube)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpgPresidente);
            this.tabControl1.Controls.Add(this.tbpgTreinador);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(539, 336);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpgPresidente
            // 
            this.tbpgPresidente.Controls.Add(this.btnEditarPresidente);
            this.tbpgPresidente.Controls.Add(this.groupBox2);
            this.tbpgPresidente.Controls.Add(this.picFotoPerfilPresidente);
            this.tbpgPresidente.Controls.Add(this.lblNomePresidente);
            this.tbpgPresidente.Controls.Add(this.lblIdadePresidente);
            this.tbpgPresidente.Location = new System.Drawing.Point(4, 22);
            this.tbpgPresidente.Name = "tbpgPresidente";
            this.tbpgPresidente.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgPresidente.Size = new System.Drawing.Size(531, 310);
            this.tbpgPresidente.TabIndex = 0;
            this.tbpgPresidente.Text = "Presidente";
            this.tbpgPresidente.UseVisualStyleBackColor = true;
            // 
            // btnEditarPresidente
            // 
            this.btnEditarPresidente.Image = global::M10_T01_N02_N25.Properties.Resources.edit;
            this.btnEditarPresidente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarPresidente.Location = new System.Drawing.Point(413, 269);
            this.btnEditarPresidente.Name = "btnEditarPresidente";
            this.btnEditarPresidente.Size = new System.Drawing.Size(112, 35);
            this.btnEditarPresidente.TabIndex = 20;
            this.btnEditarPresidente.Text = "Editar";
            this.btnEditarPresidente.UseVisualStyleBackColor = true;
            this.btnEditarPresidente.Click += new System.EventHandler(this.btnEditarPresidente_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCpPresidente);
            this.groupBox2.Controls.Add(this.lblLocalidadePresidente);
            this.groupBox2.Controls.Add(this.lblRuaPresidente);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(135, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 129);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Morada: ";
            // 
            // lblCpPresidente
            // 
            this.lblCpPresidente.AutoSize = true;
            this.lblCpPresidente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpPresidente.Location = new System.Drawing.Point(17, 64);
            this.lblCpPresidente.Name = "lblCpPresidente";
            this.lblCpPresidente.Size = new System.Drawing.Size(89, 15);
            this.lblCpPresidente.TabIndex = 2;
            this.lblCpPresidente.Text = "Codigo Postal: ";
            // 
            // lblLocalidadePresidente
            // 
            this.lblLocalidadePresidente.AutoSize = true;
            this.lblLocalidadePresidente.Location = new System.Drawing.Point(17, 43);
            this.lblLocalidadePresidente.Name = "lblLocalidadePresidente";
            this.lblLocalidadePresidente.Size = new System.Drawing.Size(74, 15);
            this.lblLocalidadePresidente.TabIndex = 1;
            this.lblLocalidadePresidente.Text = "Localidade: ";
            // 
            // lblRuaPresidente
            // 
            this.lblRuaPresidente.AutoSize = true;
            this.lblRuaPresidente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuaPresidente.Location = new System.Drawing.Point(17, 20);
            this.lblRuaPresidente.Name = "lblRuaPresidente";
            this.lblRuaPresidente.Size = new System.Drawing.Size(36, 15);
            this.lblRuaPresidente.TabIndex = 0;
            this.lblRuaPresidente.Text = "Rua: ";
            // 
            // picFotoPerfilPresidente
            // 
            this.picFotoPerfilPresidente.Location = new System.Drawing.Point(13, 13);
            this.picFotoPerfilPresidente.Name = "picFotoPerfilPresidente";
            this.picFotoPerfilPresidente.Size = new System.Drawing.Size(109, 149);
            this.picFotoPerfilPresidente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotoPerfilPresidente.TabIndex = 17;
            this.picFotoPerfilPresidente.TabStop = false;
            // 
            // lblNomePresidente
            // 
            this.lblNomePresidente.AutoSize = true;
            this.lblNomePresidente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePresidente.Location = new System.Drawing.Point(132, 13);
            this.lblNomePresidente.Name = "lblNomePresidente";
            this.lblNomePresidente.Size = new System.Drawing.Size(47, 15);
            this.lblNomePresidente.TabIndex = 18;
            this.lblNomePresidente.Text = "Nome: ";
            // 
            // lblIdadePresidente
            // 
            this.lblIdadePresidente.AutoSize = true;
            this.lblIdadePresidente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdadePresidente.Location = new System.Drawing.Point(132, 39);
            this.lblIdadePresidente.Name = "lblIdadePresidente";
            this.lblIdadePresidente.Size = new System.Drawing.Size(44, 15);
            this.lblIdadePresidente.TabIndex = 19;
            this.lblIdadePresidente.Text = "Idade: ";
            // 
            // tbpgTreinador
            // 
            this.tbpgTreinador.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tbpgTreinador.Controls.Add(this.btnEditarTreinador);
            this.tbpgTreinador.Controls.Add(this.groupBox1);
            this.tbpgTreinador.Controls.Add(this.picFotoPerfilTreinador);
            this.tbpgTreinador.Controls.Add(this.lblNomeTreinador);
            this.tbpgTreinador.Controls.Add(this.lblIdadeTreinador);
            this.tbpgTreinador.Location = new System.Drawing.Point(4, 22);
            this.tbpgTreinador.Name = "tbpgTreinador";
            this.tbpgTreinador.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgTreinador.Size = new System.Drawing.Size(531, 310);
            this.tbpgTreinador.TabIndex = 1;
            this.tbpgTreinador.Text = "Treinador";
            this.tbpgTreinador.UseVisualStyleBackColor = true;
            // 
            // btnEditarTreinador
            // 
            this.btnEditarTreinador.Image = global::M10_T01_N02_N25.Properties.Resources.edit;
            this.btnEditarTreinador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarTreinador.Location = new System.Drawing.Point(413, 269);
            this.btnEditarTreinador.Name = "btnEditarTreinador";
            this.btnEditarTreinador.Size = new System.Drawing.Size(112, 35);
            this.btnEditarTreinador.TabIndex = 21;
            this.btnEditarTreinador.Text = "Editar";
            this.btnEditarTreinador.UseVisualStyleBackColor = true;
            this.btnEditarTreinador.Click += new System.EventHandler(this.btnEditarTreinador_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCpTreinador);
            this.groupBox1.Controls.Add(this.lblLocalidadeTreinador);
            this.groupBox1.Controls.Add(this.lblRuaTreinador);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(135, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 129);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Morada: ";
            // 
            // lblCpTreinador
            // 
            this.lblCpTreinador.AutoSize = true;
            this.lblCpTreinador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpTreinador.Location = new System.Drawing.Point(17, 64);
            this.lblCpTreinador.Name = "lblCpTreinador";
            this.lblCpTreinador.Size = new System.Drawing.Size(89, 15);
            this.lblCpTreinador.TabIndex = 2;
            this.lblCpTreinador.Text = "Codigo Postal: ";
            // 
            // lblLocalidadeTreinador
            // 
            this.lblLocalidadeTreinador.AutoSize = true;
            this.lblLocalidadeTreinador.Location = new System.Drawing.Point(17, 43);
            this.lblLocalidadeTreinador.Name = "lblLocalidadeTreinador";
            this.lblLocalidadeTreinador.Size = new System.Drawing.Size(74, 15);
            this.lblLocalidadeTreinador.TabIndex = 1;
            this.lblLocalidadeTreinador.Text = "Localidade: ";
            // 
            // lblRuaTreinador
            // 
            this.lblRuaTreinador.AutoSize = true;
            this.lblRuaTreinador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuaTreinador.Location = new System.Drawing.Point(17, 20);
            this.lblRuaTreinador.Name = "lblRuaTreinador";
            this.lblRuaTreinador.Size = new System.Drawing.Size(36, 15);
            this.lblRuaTreinador.TabIndex = 0;
            this.lblRuaTreinador.Text = "Rua: ";
            // 
            // picFotoPerfilTreinador
            // 
            this.picFotoPerfilTreinador.Location = new System.Drawing.Point(13, 13);
            this.picFotoPerfilTreinador.Name = "picFotoPerfilTreinador";
            this.picFotoPerfilTreinador.Size = new System.Drawing.Size(109, 149);
            this.picFotoPerfilTreinador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotoPerfilTreinador.TabIndex = 12;
            this.picFotoPerfilTreinador.TabStop = false;
            // 
            // lblNomeTreinador
            // 
            this.lblNomeTreinador.AutoSize = true;
            this.lblNomeTreinador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTreinador.Location = new System.Drawing.Point(132, 13);
            this.lblNomeTreinador.Name = "lblNomeTreinador";
            this.lblNomeTreinador.Size = new System.Drawing.Size(47, 15);
            this.lblNomeTreinador.TabIndex = 13;
            this.lblNomeTreinador.Text = "Nome: ";
            // 
            // lblIdadeTreinador
            // 
            this.lblIdadeTreinador.AutoSize = true;
            this.lblIdadeTreinador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdadeTreinador.Location = new System.Drawing.Point(132, 39);
            this.lblIdadeTreinador.Name = "lblIdadeTreinador";
            this.lblIdadeTreinador.Size = new System.Drawing.Size(44, 15);
            this.lblIdadeTreinador.TabIndex = 14;
            this.lblIdadeTreinador.Text = "Idade: ";
            // 
            // picLogoClube
            // 
            this.picLogoClube.Location = new System.Drawing.Point(561, 35);
            this.picLogoClube.Name = "picLogoClube";
            this.picLogoClube.Size = new System.Drawing.Size(160, 185);
            this.picLogoClube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoClube.TabIndex = 1;
            this.picLogoClube.TabStop = false;
            // 
            // lblNomeClube
            // 
            this.lblNomeClube.AutoSize = true;
            this.lblNomeClube.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeClube.Location = new System.Drawing.Point(561, 226);
            this.lblNomeClube.Name = "lblNomeClube";
            this.lblNomeClube.Size = new System.Drawing.Size(93, 13);
            this.lblNomeClube.TabIndex = 2;
            this.lblNomeClube.Text = "Nome do Clube";
            // 
            // lblDataFundacao
            // 
            this.lblDataFundacao.AutoSize = true;
            this.lblDataFundacao.Location = new System.Drawing.Point(561, 247);
            this.lblDataFundacao.Name = "lblDataFundacao";
            this.lblDataFundacao.Size = new System.Drawing.Size(96, 13);
            this.lblDataFundacao.TabIndex = 3;
            this.lblDataFundacao.Text = "Data de Fundação";
            // 
            // lblNsocios
            // 
            this.lblNsocios.AutoSize = true;
            this.lblNsocios.Location = new System.Drawing.Point(561, 268);
            this.lblNsocios.Name = "lblNsocios";
            this.lblNsocios.Size = new System.Drawing.Size(94, 13);
            this.lblNsocios.TabIndex = 4;
            this.lblNsocios.Text = "Número de Sócios";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(610, 314);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(112, 35);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblNatletas
            // 
            this.lblNatletas.AutoSize = true;
            this.lblNatletas.Location = new System.Drawing.Point(561, 290);
            this.lblNatletas.Name = "lblNatletas";
            this.lblNatletas.Size = new System.Drawing.Size(97, 13);
            this.lblNatletas.TabIndex = 16;
            this.lblNatletas.Text = "Número de Atletas:";
            // 
            // frmSobreClube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.lblNatletas);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblNsocios);
            this.Controls.Add(this.lblDataFundacao);
            this.Controls.Add(this.lblNomeClube);
            this.Controls.Add(this.picLogoClube);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSobreClube";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sobre o Clube";
            this.Load += new System.EventHandler(this.frmSobreOClube_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbpgPresidente.ResumeLayout(false);
            this.tbpgPresidente.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoPerfilPresidente)).EndInit();
            this.tbpgTreinador.ResumeLayout(false);
            this.tbpgTreinador.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoPerfilTreinador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoClube)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpgPresidente;
        private System.Windows.Forms.TabPage tbpgTreinador;
        private System.Windows.Forms.PictureBox picLogoClube;
        private System.Windows.Forms.Label lblNomeClube;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCpTreinador;
        private System.Windows.Forms.Label lblLocalidadeTreinador;
        private System.Windows.Forms.Label lblRuaTreinador;
        public System.Windows.Forms.PictureBox picFotoPerfilTreinador;
        private System.Windows.Forms.Label lblNomeTreinador;
        private System.Windows.Forms.Label lblIdadeTreinador;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCpPresidente;
        private System.Windows.Forms.Label lblLocalidadePresidente;
        private System.Windows.Forms.Label lblRuaPresidente;
        public System.Windows.Forms.PictureBox picFotoPerfilPresidente;
        private System.Windows.Forms.Label lblNomePresidente;
        private System.Windows.Forms.Label lblIdadePresidente;
        private System.Windows.Forms.Button btnEditarPresidente;
        private System.Windows.Forms.Button btnEditarTreinador;
        private System.Windows.Forms.Label lblDataFundacao;
        private System.Windows.Forms.Label lblNsocios;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblNatletas;
    }
}