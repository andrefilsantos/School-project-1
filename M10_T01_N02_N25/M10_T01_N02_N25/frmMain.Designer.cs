namespace M10_T01_N02_N25
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tbcDadosPessoais = new System.Windows.Forms.TabControl();
            this.tpDadosPessoais = new System.Windows.Forms.TabPage();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.grpFMmorada = new System.Windows.Forms.GroupBox();
            this.lblCodigoPostal = new System.Windows.Forms.Label();
            this.lblLocalidade = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblPesoSocio = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.picMFfotoPerfil = new System.Windows.Forms.PictureBox();
            this.lstPessoas = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.programaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnOClube = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.lblVazio = new System.Windows.Forms.Label();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.lblAutosaveInfo = new System.Windows.Forms.Label();
            this.tbcDadosPessoais.SuspendLayout();
            this.tpDadosPessoais.SuspendLayout();
            this.grpFMmorada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMFfotoPerfil)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcDadosPessoais
            // 
            this.tbcDadosPessoais.Controls.Add(this.tpDadosPessoais);
            this.tbcDadosPessoais.Location = new System.Drawing.Point(13, 28);
            this.tbcDadosPessoais.Name = "tbcDadosPessoais";
            this.tbcDadosPessoais.SelectedIndex = 0;
            this.tbcDadosPessoais.Size = new System.Drawing.Size(702, 390);
            this.tbcDadosPessoais.TabIndex = 0;
            // 
            // tpDadosPessoais
            // 
            this.tpDadosPessoais.Controls.Add(this.btnEditar);
            this.tpDadosPessoais.Controls.Add(this.btnEliminar);
            this.tpDadosPessoais.Controls.Add(this.grpFMmorada);
            this.tpDadosPessoais.Controls.Add(this.lblPesoSocio);
            this.tpDadosPessoais.Controls.Add(this.lblIdade);
            this.tpDadosPessoais.Controls.Add(this.lblNome);
            this.tpDadosPessoais.Controls.Add(this.picMFfotoPerfil);
            this.tpDadosPessoais.Location = new System.Drawing.Point(4, 22);
            this.tpDadosPessoais.Name = "tpDadosPessoais";
            this.tpDadosPessoais.Padding = new System.Windows.Forms.Padding(3);
            this.tpDadosPessoais.Size = new System.Drawing.Size(694, 364);
            this.tpDadosPessoais.TabIndex = 0;
            this.tpDadosPessoais.Text = "Dados Pessoais";
            this.tpDadosPessoais.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::M10_T01_N02_N25.Properties.Resources.edit;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(485, 319);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(97, 36);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::M10_T01_N02_N25.Properties.Resources.cancel;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(588, 319);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(97, 36);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "E&liminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // grpFMmorada
            // 
            this.grpFMmorada.Controls.Add(this.lblCodigoPostal);
            this.grpFMmorada.Controls.Add(this.lblLocalidade);
            this.grpFMmorada.Controls.Add(this.lblRua);
            this.grpFMmorada.Location = new System.Drawing.Point(134, 77);
            this.grpFMmorada.Name = "grpFMmorada";
            this.grpFMmorada.Size = new System.Drawing.Size(551, 130);
            this.grpFMmorada.TabIndex = 4;
            this.grpFMmorada.TabStop = false;
            this.grpFMmorada.Text = "Morada";
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Location = new System.Drawing.Point(12, 59);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(72, 13);
            this.lblCodigoPostal.TabIndex = 7;
            this.lblCodigoPostal.Text = "Código Postal";
            // 
            // lblLocalidade
            // 
            this.lblLocalidade.AutoSize = true;
            this.lblLocalidade.Location = new System.Drawing.Point(12, 41);
            this.lblLocalidade.Name = "lblLocalidade";
            this.lblLocalidade.Size = new System.Drawing.Size(59, 13);
            this.lblLocalidade.TabIndex = 6;
            this.lblLocalidade.Text = "Localidade";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(12, 22);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(27, 13);
            this.lblRua.TabIndex = 5;
            this.lblRua.Text = "Rua";
            // 
            // lblPesoSocio
            // 
            this.lblPesoSocio.AutoSize = true;
            this.lblPesoSocio.Location = new System.Drawing.Point(134, 57);
            this.lblPesoSocio.Name = "lblPesoSocio";
            this.lblPesoSocio.Size = new System.Drawing.Size(34, 13);
            this.lblPesoSocio.TabIndex = 3;
            this.lblPesoSocio.Text = "Peso:";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(134, 37);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(37, 13);
            this.lblIdade.TabIndex = 2;
            this.lblIdade.Text = "Idade:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(134, 17);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // picMFfotoPerfil
            // 
            this.picMFfotoPerfil.Location = new System.Drawing.Point(13, 14);
            this.picMFfotoPerfil.Name = "picMFfotoPerfil";
            this.picMFfotoPerfil.Size = new System.Drawing.Size(109, 149);
            this.picMFfotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMFfotoPerfil.TabIndex = 0;
            this.picMFfotoPerfil.TabStop = false;
            // 
            // lstPessoas
            // 
            this.lstPessoas.FormattingEnabled = true;
            this.lstPessoas.Location = new System.Drawing.Point(721, 91);
            this.lstPessoas.Name = "lstPessoas";
            this.lstPessoas.Size = new System.Drawing.Size(150, 368);
            this.lstPessoas.TabIndex = 1;
            this.lstPessoas.SelectedIndexChanged += new System.EventHandler(this.lstPessoas_SelectedIndexChanged);
            this.lstPessoas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstPessoas_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(878, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.AutoSaveToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::M10_T01_N02_N25.Properties.Resources.save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.saveToolStripMenuItem.Text = "Guardar";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Image = global::M10_T01_N02_N25.Properties.Resources.Refresh;
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.loadToolStripMenuItem.Text = "Carregar";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // AutoSaveToolStripMenuItem
            // 
            this.AutoSaveToolStripMenuItem.Image = global::M10_T01_N02_N25.Properties.Resources.AUto_save;
            this.AutoSaveToolStripMenuItem.Name = "AutoSaveToolStripMenuItem";
            this.AutoSaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F2)));
            this.AutoSaveToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.AutoSaveToolStripMenuItem.Text = "Auto Save";
            this.AutoSaveToolStripMenuItem.Click += new System.EventHandler(this.AutoSaveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::M10_T01_N02_N25.Properties.Resources.exit;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clubeToolStripMenuItem,
            this.toolStripSeparator2,
            this.programaToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // clubeToolStripMenuItem
            // 
            this.clubeToolStripMenuItem.Image = global::M10_T01_N02_N25.Properties.Resources.Sport_Lisboa_e_Benfica_Logo_peq;
            this.clubeToolStripMenuItem.Name = "clubeToolStripMenuItem";
            this.clubeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.clubeToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.clubeToolStripMenuItem.Text = "Clube";
            this.clubeToolStripMenuItem.Click += new System.EventHandler(this.clubeToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(155, 6);
            // 
            // programaToolStripMenuItem
            // 
            this.programaToolStripMenuItem.Image = global::M10_T01_N02_N25.Properties.Resources._5168fb83e1e34e0381bb67a80527c464_800;
            this.programaToolStripMenuItem.Name = "programaToolStripMenuItem";
            this.programaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.programaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.programaToolStripMenuItem.Text = "Programa";
            this.programaToolStripMenuItem.Click += new System.EventHandler(this.programaToolStripMenuItem_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = global::M10_T01_N02_N25.Properties.Resources.exit;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(614, 423);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(97, 36);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::M10_T01_N02_N25.Properties.Resources.save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(511, 423);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(97, 36);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "  &Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Image = global::M10_T01_N02_N25.Properties.Resources.add;
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(408, 423);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(97, 36);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "  &Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnOClube
            // 
            this.btnOClube.Image = global::M10_T01_N02_N25.Properties.Resources.Sport_Lisboa_e_Benfica_Logo_peq;
            this.btnOClube.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOClube.Location = new System.Drawing.Point(203, 423);
            this.btnOClube.Name = "btnOClube";
            this.btnOClube.Size = new System.Drawing.Size(97, 36);
            this.btnOClube.TabIndex = 6;
            this.btnOClube.Text = "O &Clube";
            this.btnOClube.UseVisualStyleBackColor = true;
            this.btnOClube.Click += new System.EventHandler(this.btnOClube_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Location = new System.Drawing.Point(721, 50);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(35, 35);
            this.btnPrimeiro.TabIndex = 7;
            this.btnPrimeiro.Text = "|<";
            this.btnPrimeiro.UseVisualStyleBackColor = true;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(761, 50);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(35, 35);
            this.btnAnterior.TabIndex = 8;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(799, 50);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(35, 35);
            this.btnProximo.TabIndex = 9;
            this.btnProximo.Text = ">";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(836, 50);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(35, 35);
            this.btnUltimo.TabIndex = 10;
            this.btnUltimo.Text = ">|";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // lblVazio
            // 
            this.lblVazio.AutoSize = true;
            this.lblVazio.BackColor = System.Drawing.Color.White;
            this.lblVazio.Location = new System.Drawing.Point(728, 107);
            this.lblVazio.Name = "lblVazio";
            this.lblVazio.Size = new System.Drawing.Size(129, 13);
            this.lblVazio.TabIndex = 11;
            this.lblVazio.Text = "Não há elementos na lista";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Image = global::M10_T01_N02_N25.Properties.Resources.search;
            this.btnPesquisa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisa.Location = new System.Drawing.Point(305, 423);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(97, 36);
            this.btnPesquisa.TabIndex = 12;
            this.btnPesquisa.Text = "&Pesquisa";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // lblAutosaveInfo
            // 
            this.lblAutosaveInfo.AutoSize = true;
            this.lblAutosaveInfo.Location = new System.Drawing.Point(769, 30);
            this.lblAutosaveInfo.Name = "lblAutosaveInfo";
            this.lblAutosaveInfo.Size = new System.Drawing.Size(103, 13);
            this.lblAutosaveInfo.TabIndex = 13;
            this.lblAutosaveInfo.Text = "Autosave: desligado";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 473);
            this.Controls.Add(this.lblAutosaveInfo);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.lblVazio);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimeiro);
            this.Controls.Add(this.btnOClube);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lstPessoas);
            this.Controls.Add(this.tbcDadosPessoais);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ahiru Club 2.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.formMain_Load);
            this.tbcDadosPessoais.ResumeLayout(false);
            this.tpDadosPessoais.ResumeLayout(false);
            this.tpDadosPessoais.PerformLayout();
            this.grpFMmorada.ResumeLayout(false);
            this.grpFMmorada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMFfotoPerfil)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbcDadosPessoais;
        private System.Windows.Forms.TabPage tpDadosPessoais;
        private System.Windows.Forms.GroupBox grpFMmorada;
        private System.Windows.Forms.Label lblCodigoPostal;
        private System.Windows.Forms.Label lblLocalidade;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblPesoSocio;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox picMFfotoPerfil;
        private System.Windows.Forms.ListBox lstPessoas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AutoSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clubeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programaToolStripMenuItem;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnOClube;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Label lblVazio;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label lblAutosaveInfo;
    }
}

