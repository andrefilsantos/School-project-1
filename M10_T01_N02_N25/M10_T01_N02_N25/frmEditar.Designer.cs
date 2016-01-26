namespace M10_T01_N02_N25
{
    partial class frmEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditar));
            this.lblNome = new System.Windows.Forms.Label();
            this.grpMorada = new System.Windows.Forms.GroupBox();
            this.mskCodigoPostal = new System.Windows.Forms.MaskedTextBox();
            this.lblCodigoPostal = new System.Windows.Forms.Label();
            this.txtLocalidade = new System.Windows.Forms.TextBox();
            this.lblLocalidade = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.picFotoPerfil = new System.Windows.Forms.PictureBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.btnEscolherFoto = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.mskData = new System.Windows.Forms.MaskedTextBox();
            this.grpMorada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(78, 13);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // grpMorada
            // 
            this.grpMorada.Controls.Add(this.mskCodigoPostal);
            this.grpMorada.Controls.Add(this.lblCodigoPostal);
            this.grpMorada.Controls.Add(this.txtLocalidade);
            this.grpMorada.Controls.Add(this.lblLocalidade);
            this.grpMorada.Controls.Add(this.txtRua);
            this.grpMorada.Controls.Add(this.lblRua);
            this.grpMorada.Location = new System.Drawing.Point(12, 66);
            this.grpMorada.Name = "grpMorada";
            this.grpMorada.Size = new System.Drawing.Size(366, 106);
            this.grpMorada.TabIndex = 2;
            this.grpMorada.TabStop = false;
            this.grpMorada.Text = "Morada";
            // 
            // mskCodigoPostal
            // 
            this.mskCodigoPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.mskCodigoPostal.Location = new System.Drawing.Point(111, 78);
            this.mskCodigoPostal.Margin = new System.Windows.Forms.Padding(4);
            this.mskCodigoPostal.Mask = "0000-000";
            this.mskCodigoPostal.Name = "mskCodigoPostal";
            this.mskCodigoPostal.Size = new System.Drawing.Size(241, 21);
            this.mskCodigoPostal.TabIndex = 5;
            this.mskCodigoPostal.ValidatingType = typeof(System.DateTime);
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Location = new System.Drawing.Point(30, 81);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(75, 13);
            this.lblCodigoPostal.TabIndex = 9;
            this.lblCodigoPostal.Text = "Código Postal:";
            // 
            // txtLocalidade
            // 
            this.txtLocalidade.Location = new System.Drawing.Point(111, 49);
            this.txtLocalidade.Name = "txtLocalidade";
            this.txtLocalidade.Size = new System.Drawing.Size(241, 20);
            this.txtLocalidade.TabIndex = 4;
            // 
            // lblLocalidade
            // 
            this.lblLocalidade.AutoSize = true;
            this.lblLocalidade.Location = new System.Drawing.Point(43, 53);
            this.lblLocalidade.Name = "lblLocalidade";
            this.lblLocalidade.Size = new System.Drawing.Size(62, 13);
            this.lblLocalidade.TabIndex = 7;
            this.lblLocalidade.Text = "Localidade:";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(111, 19);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(241, 20);
            this.txtRua.TabIndex = 3;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(75, 23);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(30, 13);
            this.lblRua.TabIndex = 5;
            this.lblRua.Text = "Rua:";
            // 
            // picFotoPerfil
            // 
            this.picFotoPerfil.Location = new System.Drawing.Point(384, 13);
            this.picFotoPerfil.Name = "picFotoPerfil";
            this.picFotoPerfil.Size = new System.Drawing.Size(138, 185);
            this.picFotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotoPerfil.TabIndex = 3;
            this.picFotoPerfil.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(123, 10);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(241, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(10, 46);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(107, 13);
            this.lblDataNascimento.TabIndex = 5;
            this.lblDataNascimento.Text = "Data de Nascimento:";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(123, 178);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(241, 20);
            this.txtPeso.TabIndex = 6;
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(83, 182);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(34, 13);
            this.lblPeso.TabIndex = 7;
            this.lblPeso.Text = "Peso:";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Atleta",
            "Sócio"});
            this.cboTipo.Location = new System.Drawing.Point(123, 208);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(241, 21);
            this.cboTipo.TabIndex = 7;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // btnEscolherFoto
            // 
            this.btnEscolherFoto.Image = ((System.Drawing.Image)(resources.GetObject("btnEscolherFoto.Image")));
            this.btnEscolherFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEscolherFoto.Location = new System.Drawing.Point(384, 208);
            this.btnEscolherFoto.Name = "btnEscolherFoto";
            this.btnEscolherFoto.Size = new System.Drawing.Size(138, 23);
            this.btnEscolherFoto.TabIndex = 8;
            this.btnEscolherFoto.Text = "&Escolher Foto";
            this.btnEscolherFoto.UseVisualStyleBackColor = true;
            this.btnEscolherFoto.Click += new System.EventHandler(this.btnAlterarFoto_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::M10_T01_N02_N25.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(410, 240);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 35);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Image = global::M10_T01_N02_N25.Properties.Resources.ok;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(292, 240);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(112, 35);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // mskData
            // 
            this.mskData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.mskData.Location = new System.Drawing.Point(123, 42);
            this.mskData.Margin = new System.Windows.Forms.Padding(4);
            this.mskData.Mask = "00/00/0000";
            this.mskData.Name = "mskData";
            this.mskData.Size = new System.Drawing.Size(241, 21);
            this.mskData.TabIndex = 2;
            this.mskData.ValidatingType = typeof(System.DateTime);
            // 
            // frmEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 283);
            this.Controls.Add(this.mskData);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEscolherFoto);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.picFotoPerfil);
            this.Controls.Add(this.grpMorada);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditar_FormClosing);
            this.Load += new System.EventHandler(this.frmEditar_Load);
            this.grpMorada.ResumeLayout(false);
            this.grpMorada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox grpMorada;
        private System.Windows.Forms.MaskedTextBox mskCodigoPostal;
        private System.Windows.Forms.Label lblCodigoPostal;
        private System.Windows.Forms.TextBox txtLocalidade;
        private System.Windows.Forms.Label lblLocalidade;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblRua;
        public System.Windows.Forms.PictureBox picFotoPerfil;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Button btnEscolherFoto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.MaskedTextBox mskData;
    }
}