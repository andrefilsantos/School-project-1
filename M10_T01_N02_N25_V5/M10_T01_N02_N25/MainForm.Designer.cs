namespace M10_T01_N02_N25
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lbMembros = new System.Windows.Forms.ListBox();
            this.grpMorada = new System.Windows.Forms.GroupBox();
            this.lbl_codpost = new System.Windows.Forms.Label();
            this.lblLocalidade = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.clubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFstReg = new System.Windows.Forms.Button();
            this.btnPrevReg = new System.Windows.Forms.Button();
            this.btnNxtReg = new System.Windows.Forms.Button();
            this.btnLatReg = new System.Windows.Forms.Button();
            this.tbpgDadosPessoais = new System.Windows.Forms.TabPage();
            this.lblPeso = new System.Windows.Forms.Label();
            this.btnRemReg = new System.Windows.Forms.Button();
            this.picFotoPerfil = new System.Windows.Forms.PictureBox();
            this.tcDadosPessoais = new System.Windows.Forms.TabControl();
            this.btnRemAll = new System.Windows.Forms.Button();
            this.btnSobreClube = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblVazio = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.grpMorada.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tbpgDadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoPerfil)).BeginInit();
            this.tcDadosPessoais.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMembros
            // 
            this.lbMembros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMembros.FormattingEnabled = true;
            this.lbMembros.ItemHeight = 15;
            this.lbMembros.Location = new System.Drawing.Point(734, 64);
            this.lbMembros.Name = "lbMembros";
            this.lbMembros.Size = new System.Drawing.Size(149, 394);
            this.lbMembros.TabIndex = 0;
            this.lbMembros.SelectedIndexChanged += new System.EventHandler(this.lbMembros_SelectedIndexChanged);
            this.lbMembros.DoubleClick += new System.EventHandler(this.lbMembros_DoubleClick);
            // 
            // grpMorada
            // 
            this.grpMorada.Controls.Add(this.lbl_codpost);
            this.grpMorada.Controls.Add(this.lblLocalidade);
            this.grpMorada.Controls.Add(this.lblRua);
            this.grpMorada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMorada.Location = new System.Drawing.Point(134, 85);
            this.grpMorada.Name = "grpMorada";
            this.grpMorada.Size = new System.Drawing.Size(554, 79);
            this.grpMorada.TabIndex = 2;
            this.grpMorada.TabStop = false;
            this.grpMorada.Text = "Morada: ";
            // 
            // lbl_codpost
            // 
            this.lbl_codpost.AutoSize = true;
            this.lbl_codpost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codpost.Location = new System.Drawing.Point(17, 54);
            this.lbl_codpost.Name = "lbl_codpost";
            this.lbl_codpost.Size = new System.Drawing.Size(89, 15);
            this.lbl_codpost.TabIndex = 2;
            this.lbl_codpost.Text = "Codigo Postal: ";
            // 
            // lblLocalidade
            // 
            this.lblLocalidade.AutoSize = true;
            this.lblLocalidade.Location = new System.Drawing.Point(17, 37);
            this.lblLocalidade.Name = "lblLocalidade";
            this.lblLocalidade.Size = new System.Drawing.Size(74, 15);
            this.lblLocalidade.TabIndex = 1;
            this.lblLocalidade.Text = "Localidade: ";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.Location = new System.Drawing.Point(17, 20);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(36, 15);
            this.lblRua.TabIndex = 0;
            this.lblRua.Text = "Rua: ";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.Location = new System.Drawing.Point(131, 44);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(44, 15);
            this.lblIdade.TabIndex = 1;
            this.lblIdade.Text = "Idade: ";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(131, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome: ";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(458, 321);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(112, 35);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(367, 424);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(112, 35);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.tsmSobre,
            this.pesquisaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(895, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.autoSaveToolStripMenuItem});
            this.optionsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // autoSaveToolStripMenuItem
            // 
            this.autoSaveToolStripMenuItem.Name = "autoSaveToolStripMenuItem";
            this.autoSaveToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.autoSaveToolStripMenuItem.Text = "Auto Save";
            this.autoSaveToolStripMenuItem.Click += new System.EventHandler(this.autoSaveToolStripMenuItem_Click);
            // 
            // tsmSobre
            // 
            this.tsmSobre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clubeToolStripMenuItem,
            this.programaToolStripMenuItem});
            this.tsmSobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmSobre.Name = "tsmSobre";
            this.tsmSobre.Size = new System.Drawing.Size(52, 20);
            this.tsmSobre.Text = "Sobre";
            this.tsmSobre.Click += new System.EventHandler(this.tsmSobre_Click);
            // 
            // clubeToolStripMenuItem
            // 
            this.clubeToolStripMenuItem.Name = "clubeToolStripMenuItem";
            this.clubeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.clubeToolStripMenuItem.Text = "Clube";
            this.clubeToolStripMenuItem.Click += new System.EventHandler(this.clubeToolStripMenuItem_Click);
            // 
            // programaToolStripMenuItem
            // 
            this.programaToolStripMenuItem.Name = "programaToolStripMenuItem";
            this.programaToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.programaToolStripMenuItem.Text = "Programa";
            this.programaToolStripMenuItem.Click += new System.EventHandler(this.programaToolStripMenuItem_Click);
            // 
            // pesquisaToolStripMenuItem
            // 
            this.pesquisaToolStripMenuItem.Name = "pesquisaToolStripMenuItem";
            this.pesquisaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pesquisaToolStripMenuItem.Text = "Pesquisa";
            this.pesquisaToolStripMenuItem.Click += new System.EventHandler(this.pesquisaToolStripMenuItem_Click);
            // 
            // btnFstReg
            // 
            this.btnFstReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFstReg.Image = ((System.Drawing.Image)(resources.GetObject("btnFstReg.Image")));
            this.btnFstReg.Location = new System.Drawing.Point(739, 30);
            this.btnFstReg.Name = "btnFstReg";
            this.btnFstReg.Size = new System.Drawing.Size(30, 30);
            this.btnFstReg.TabIndex = 5;
            this.btnFstReg.UseVisualStyleBackColor = true;
            this.btnFstReg.Click += new System.EventHandler(this.btnFstReg_Click);
            // 
            // btnPrevReg
            // 
            this.btnPrevReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevReg.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevReg.Image")));
            this.btnPrevReg.Location = new System.Drawing.Point(775, 30);
            this.btnPrevReg.Name = "btnPrevReg";
            this.btnPrevReg.Size = new System.Drawing.Size(30, 30);
            this.btnPrevReg.TabIndex = 6;
            this.btnPrevReg.UseVisualStyleBackColor = true;
            this.btnPrevReg.Click += new System.EventHandler(this.btnPrevReg_Click);
            // 
            // btnNxtReg
            // 
            this.btnNxtReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNxtReg.Image = ((System.Drawing.Image)(resources.GetObject("btnNxtReg.Image")));
            this.btnNxtReg.Location = new System.Drawing.Point(811, 30);
            this.btnNxtReg.Name = "btnNxtReg";
            this.btnNxtReg.Size = new System.Drawing.Size(30, 30);
            this.btnNxtReg.TabIndex = 7;
            this.btnNxtReg.UseVisualStyleBackColor = true;
            this.btnNxtReg.Click += new System.EventHandler(this.btnNxtReg_Click);
            // 
            // btnLatReg
            // 
            this.btnLatReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLatReg.Image = ((System.Drawing.Image)(resources.GetObject("btnLatReg.Image")));
            this.btnLatReg.Location = new System.Drawing.Point(847, 30);
            this.btnLatReg.Name = "btnLatReg";
            this.btnLatReg.Size = new System.Drawing.Size(30, 30);
            this.btnLatReg.TabIndex = 8;
            this.btnLatReg.UseVisualStyleBackColor = true;
            this.btnLatReg.Click += new System.EventHandler(this.btnLatReg_Click);
            // 
            // tbpgDadosPessoais
            // 
            this.tbpgDadosPessoais.Controls.Add(this.lblPeso);
            this.tbpgDadosPessoais.Controls.Add(this.btnRemReg);
            this.tbpgDadosPessoais.Controls.Add(this.grpMorada);
            this.tbpgDadosPessoais.Controls.Add(this.lblIdade);
            this.tbpgDadosPessoais.Controls.Add(this.picFotoPerfil);
            this.tbpgDadosPessoais.Controls.Add(this.lblNome);
            this.tbpgDadosPessoais.Controls.Add(this.btnEditar);
            this.tbpgDadosPessoais.Location = new System.Drawing.Point(4, 22);
            this.tbpgDadosPessoais.Name = "tbpgDadosPessoais";
            this.tbpgDadosPessoais.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgDadosPessoais.Size = new System.Drawing.Size(694, 364);
            this.tbpgDadosPessoais.TabIndex = 0;
            this.tbpgDadosPessoais.Text = "Dados Pessoais";
            this.tbpgDadosPessoais.UseVisualStyleBackColor = true;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(131, 67);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(38, 15);
            this.lblPeso.TabIndex = 5;
            this.lblPeso.Text = "Peso:";
            // 
            // btnRemReg
            // 
            this.btnRemReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemReg.Image = ((System.Drawing.Image)(resources.GetObject("btnRemReg.Image")));
            this.btnRemReg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemReg.Location = new System.Drawing.Point(576, 321);
            this.btnRemReg.Name = "btnRemReg";
            this.btnRemReg.Size = new System.Drawing.Size(112, 35);
            this.btnRemReg.TabIndex = 4;
            this.btnRemReg.Text = "Eliminar";
            this.btnRemReg.UseVisualStyleBackColor = true;
            this.btnRemReg.Click += new System.EventHandler(this.btnRemReg_Click);
            // 
            // picFotoPerfil
            // 
            this.picFotoPerfil.Location = new System.Drawing.Point(12, 15);
            this.picFotoPerfil.Name = "picFotoPerfil";
            this.picFotoPerfil.Size = new System.Drawing.Size(109, 149);
            this.picFotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotoPerfil.TabIndex = 0;
            this.picFotoPerfil.TabStop = false;
            // 
            // tcDadosPessoais
            // 
            this.tcDadosPessoais.Controls.Add(this.tbpgDadosPessoais);
            this.tcDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcDadosPessoais.Location = new System.Drawing.Point(13, 28);
            this.tcDadosPessoais.Name = "tcDadosPessoais";
            this.tcDadosPessoais.SelectedIndex = 0;
            this.tcDadosPessoais.Size = new System.Drawing.Size(702, 390);
            this.tcDadosPessoais.TabIndex = 9;
            // 
            // btnRemAll
            // 
            this.btnRemAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemAll.Image = ((System.Drawing.Image)(resources.GetObject("btnRemAll.Image")));
            this.btnRemAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemAll.Location = new System.Drawing.Point(485, 424);
            this.btnRemAll.Name = "btnRemAll";
            this.btnRemAll.Size = new System.Drawing.Size(112, 35);
            this.btnRemAll.TabIndex = 10;
            this.btnRemAll.Text = "Eliminar Tudo";
            this.btnRemAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemAll.UseVisualStyleBackColor = true;
            this.btnRemAll.Click += new System.EventHandler(this.btnRemAll_Click);
            // 
            // btnSobreClube
            // 
            this.btnSobreClube.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobreClube.Image = ((System.Drawing.Image)(resources.GetObject("btnSobreClube.Image")));
            this.btnSobreClube.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSobreClube.Location = new System.Drawing.Point(246, 424);
            this.btnSobreClube.Name = "btnSobreClube";
            this.btnSobreClube.Size = new System.Drawing.Size(115, 35);
            this.btnSobreClube.TabIndex = 12;
            this.btnSobreClube.Text = "Sobre o Clube";
            this.btnSobreClube.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSobreClube.UseVisualStyleBackColor = true;
            this.btnSobreClube.Click += new System.EventHandler(this.btnPresidente_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(603, 424);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(112, 35);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblVazio
            // 
            this.lblVazio.AutoSize = true;
            this.lblVazio.BackColor = System.Drawing.Color.White;
            this.lblVazio.Location = new System.Drawing.Point(745, 79);
            this.lblVazio.Name = "lblVazio";
            this.lblVazio.Size = new System.Drawing.Size(126, 13);
            this.lblVazio.TabIndex = 15;
            this.lblVazio.Text = "Não há membros na lista.";
            this.lblVazio.Visible = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::M10_T01_N02_N25.Properties.Resources.search;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(127, 424);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(115, 35);
            this.btnPesquisar.TabIndex = 16;
            this.btnPesquisar.Text = "Pesquisa";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 473);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblVazio);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSobreClube);
            this.Controls.Add(this.btnRemAll);
            this.Controls.Add(this.tcDadosPessoais);
            this.Controls.Add(this.btnLatReg);
            this.Controls.Add(this.btnNxtReg);
            this.Controls.Add(this.btnPrevReg);
            this.Controls.Add(this.btnFstReg);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lbMembros);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ahiru Club";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpMorada.ResumeLayout(false);
            this.grpMorada.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tbpgDadosPessoais.ResumeLayout(false);
            this.tbpgDadosPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoPerfil)).EndInit();
            this.tcDadosPessoais.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMembros;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.GroupBox grpMorada;
        private System.Windows.Forms.Label lbl_codpost;
        private System.Windows.Forms.Label lblLocalidade;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Button btnFstReg;
        private System.Windows.Forms.Button btnPrevReg;
        private System.Windows.Forms.Button btnNxtReg;
        private System.Windows.Forms.Button btnLatReg;
        private System.Windows.Forms.ToolStripMenuItem tsmSobre;
        private System.Windows.Forms.TabPage tbpgDadosPessoais;
        public  System.Windows.Forms.PictureBox picFotoPerfil;
        private System.Windows.Forms.TabControl tcDadosPessoais;
        private System.Windows.Forms.Button btnRemReg;
        private System.Windows.Forms.Button btnRemAll;
        private System.Windows.Forms.Button btnSobreClube;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.Label lblVazio;
        private System.Windows.Forms.ToolStripMenuItem clubeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisaToolStripMenuItem;
        private System.Windows.Forms.Button btnPesquisar;
    }
}

