namespace M10_T01_N02_N25
{
    partial class frmPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisa));
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpgPesquisaSimples = new System.Windows.Forms.TabPage();
            this.tbpgPesquisaAvancada = new System.Windows.Forms.TabPage();
            this.lstResultadosAvancados = new System.Windows.Forms.ListBox();
            this.cboComoPesquisar = new System.Windows.Forms.ComboBox();
            this.txtPesquisaAvancada = new System.Windows.Forms.TextBox();
            this.cboPesquisaPor = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tbpgPesquisaSimples.SuspendLayout();
            this.tbpgPesquisaAvancada.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.3F);
            this.txtPesquisa.Location = new System.Drawing.Point(6, 6);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(756, 26);
            this.txtPesquisa.TabIndex = 0;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(675, 314);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(112, 35);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.Location = new System.Drawing.Point(6, 38);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(756, 225);
            this.lstResultados.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpgPesquisaSimples);
            this.tabControl1.Controls.Add(this.tbpgPesquisaAvancada);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 295);
            this.tabControl1.TabIndex = 17;
            // 
            // tbpgPesquisaSimples
            // 
            this.tbpgPesquisaSimples.Controls.Add(this.lstResultados);
            this.tbpgPesquisaSimples.Controls.Add(this.txtPesquisa);
            this.tbpgPesquisaSimples.Location = new System.Drawing.Point(4, 22);
            this.tbpgPesquisaSimples.Name = "tbpgPesquisaSimples";
            this.tbpgPesquisaSimples.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgPesquisaSimples.Size = new System.Drawing.Size(768, 269);
            this.tbpgPesquisaSimples.TabIndex = 0;
            this.tbpgPesquisaSimples.Text = "Pesquisa Simples";
            this.tbpgPesquisaSimples.UseVisualStyleBackColor = true;
            // 
            // tbpgPesquisaAvancada
            // 
            this.tbpgPesquisaAvancada.Controls.Add(this.lstResultadosAvancados);
            this.tbpgPesquisaAvancada.Controls.Add(this.cboComoPesquisar);
            this.tbpgPesquisaAvancada.Controls.Add(this.txtPesquisaAvancada);
            this.tbpgPesquisaAvancada.Controls.Add(this.cboPesquisaPor);
            this.tbpgPesquisaAvancada.Location = new System.Drawing.Point(4, 22);
            this.tbpgPesquisaAvancada.Name = "tbpgPesquisaAvancada";
            this.tbpgPesquisaAvancada.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgPesquisaAvancada.Size = new System.Drawing.Size(768, 269);
            this.tbpgPesquisaAvancada.TabIndex = 1;
            this.tbpgPesquisaAvancada.Text = "Pesquisa Avançada";
            this.tbpgPesquisaAvancada.UseVisualStyleBackColor = true;
            // 
            // lstResultadosAvancados
            // 
            this.lstResultadosAvancados.FormattingEnabled = true;
            this.lstResultadosAvancados.Location = new System.Drawing.Point(7, 35);
            this.lstResultadosAvancados.Name = "lstResultadosAvancados";
            this.lstResultadosAvancados.Size = new System.Drawing.Size(754, 225);
            this.lstResultadosAvancados.TabIndex = 4;
            // 
            // cboComoPesquisar
            // 
            this.cboComoPesquisar.FormattingEnabled = true;
            this.cboComoPesquisar.Items.AddRange(new object[] {
            "Igual a",
            "Superior a",
            "Inferior a"});
            this.cboComoPesquisar.Location = new System.Drawing.Point(157, 7);
            this.cboComoPesquisar.Name = "cboComoPesquisar";
            this.cboComoPesquisar.Size = new System.Drawing.Size(90, 21);
            this.cboComoPesquisar.TabIndex = 3;
            // 
            // txtPesquisaAvancada
            // 
            this.txtPesquisaAvancada.Location = new System.Drawing.Point(253, 7);
            this.txtPesquisaAvancada.Multiline = true;
            this.txtPesquisaAvancada.Name = "txtPesquisaAvancada";
            this.txtPesquisaAvancada.Size = new System.Drawing.Size(508, 21);
            this.txtPesquisaAvancada.TabIndex = 1;
            this.txtPesquisaAvancada.TextChanged += new System.EventHandler(this.txtPesquisaAvancada_TextChanged);
            this.txtPesquisaAvancada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisaAvancada_KeyPress);
            // 
            // cboPesquisaPor
            // 
            this.cboPesquisaPor.FormattingEnabled = true;
            this.cboPesquisaPor.Items.AddRange(new object[] {
            "Nome",
            "Rua",
            "Localidade",
            "Código Postal",
            "Idade",
            "Peso",
            "Número de Sócio"});
            this.cboPesquisaPor.Location = new System.Drawing.Point(7, 7);
            this.cboPesquisaPor.Name = "cboPesquisaPor";
            this.cboPesquisaPor.Size = new System.Drawing.Size(144, 21);
            this.cboPesquisaPor.TabIndex = 0;
            this.cboPesquisaPor.SelectedIndexChanged += new System.EventHandler(this.cboPesquisaPor_SelectedIndexChanged);
            // 
            // frmPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 361);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPesquisa_FormClosing);
            this.Load += new System.EventHandler(this.frmPesquisa_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbpgPesquisaSimples.ResumeLayout(false);
            this.tbpgPesquisaSimples.PerformLayout();
            this.tbpgPesquisaAvancada.ResumeLayout(false);
            this.tbpgPesquisaAvancada.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpgPesquisaSimples;
        private System.Windows.Forms.TabPage tbpgPesquisaAvancada;
        private System.Windows.Forms.TextBox txtPesquisaAvancada;
        private System.Windows.Forms.ComboBox cboPesquisaPor;
        private System.Windows.Forms.ComboBox cboComoPesquisar;
        private System.Windows.Forms.ListBox lstResultadosAvancados;
    }
}