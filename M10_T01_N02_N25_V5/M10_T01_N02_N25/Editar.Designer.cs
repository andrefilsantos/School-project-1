namespace M10_T01_N02_N25
{
    partial class Editar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar));
            this.txbCod_postal = new System.Windows.Forms.TextBox();
            this.txbLocalidade = new System.Windows.Forms.TextBox();
            this.txbRua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskData = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_peso = new System.Windows.Forms.TextBox();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.btnAlterarFoto = new System.Windows.Forms.Button();
            this.picFotoPerfil = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // txbCod_postal
            // 
            this.txbCod_postal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txbCod_postal.Location = new System.Drawing.Point(108, 143);
            this.txbCod_postal.Margin = new System.Windows.Forms.Padding(4);
            this.txbCod_postal.MaxLength = 8;
            this.txbCod_postal.Name = "txbCod_postal";
            this.txbCod_postal.Size = new System.Drawing.Size(253, 21);
            this.txbCod_postal.TabIndex = 5;
            this.txbCod_postal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCod_postal_KeyPress);
            // 
            // txbLocalidade
            // 
            this.txbLocalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txbLocalidade.Location = new System.Drawing.Point(108, 111);
            this.txbLocalidade.Margin = new System.Windows.Forms.Padding(4);
            this.txbLocalidade.Name = "txbLocalidade";
            this.txbLocalidade.Size = new System.Drawing.Size(253, 21);
            this.txbLocalidade.TabIndex = 4;
            // 
            // txbRua
            // 
            this.txbRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txbRua.Location = new System.Drawing.Point(108, 79);
            this.txbRua.Margin = new System.Windows.Forms.Padding(4);
            this.txbRua.Name = "txbRua";
            this.txbRua.Size = new System.Drawing.Size(253, 21);
            this.txbRua.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(16, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Morada";
            // 
            // mskData
            // 
            this.mskData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.mskData.Location = new System.Drawing.Point(108, 47);
            this.mskData.Margin = new System.Windows.Forms.Padding(4);
            this.mskData.Mask = "00/00/0000";
            this.mskData.Name = "mskData";
            this.mskData.Size = new System.Drawing.Size(253, 21);
            this.mskData.TabIndex = 2;
            this.mskData.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(16, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Data Nasc";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNome.Location = new System.Drawing.Point(108, 15);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(253, 21);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome";
            // 
            // tb_peso
            // 
            this.tb_peso.Enabled = false;
            this.tb_peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tb_peso.Location = new System.Drawing.Point(108, 176);
            this.tb_peso.Margin = new System.Windows.Forms.Padding(4);
            this.tb_peso.Name = "tb_peso";
            this.tb_peso.Size = new System.Drawing.Size(253, 21);
            this.tb_peso.TabIndex = 6;
            this.tb_peso.TextChanged += new System.EventHandler(this.tb_peso_TextChanged);
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_peso.Location = new System.Drawing.Point(20, 177);
            this.lbl_peso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(38, 15);
            this.lbl_peso.TabIndex = 21;
            this.lbl_peso.Text = "Peso ";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Atleta",
            "Socio"});
            this.comboBoxTipo.Location = new System.Drawing.Point(108, 212);
            this.comboBoxTipo.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(253, 23);
            this.comboBoxTipo.TabIndex = 7;
            this.comboBoxTipo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipo_SelectedIndexChanged);
            // 
            // btnAlterarFoto
            // 
            this.btnAlterarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAlterarFoto.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarFoto.Image")));
            this.btnAlterarFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarFoto.Location = new System.Drawing.Point(385, 212);
            this.btnAlterarFoto.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterarFoto.Name = "btnAlterarFoto";
            this.btnAlterarFoto.Size = new System.Drawing.Size(138, 25);
            this.btnAlterarFoto.TabIndex = 8;
            this.btnAlterarFoto.Text = "&Escolher Foto";
            this.btnAlterarFoto.UseVisualStyleBackColor = true;
            this.btnAlterarFoto.Click += new System.EventHandler(this.btnAlterarFoto_Click);
            // 
            // picFotoPerfil
            // 
            this.picFotoPerfil.Location = new System.Drawing.Point(385, 15);
            this.picFotoPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.picFotoPerfil.Name = "picFotoPerfil";
            this.picFotoPerfil.Size = new System.Drawing.Size(138, 185);
            this.picFotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotoPerfil.TabIndex = 23;
            this.picFotoPerfil.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(409, 250);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 35);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "  &Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(289, 250);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 35);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "&Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Rua";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Localidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Código Postal";
            // 
            // Editar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(534, 298);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAlterarFoto);
            this.Controls.Add(this.picFotoPerfil);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.lbl_peso);
            this.Controls.Add(this.tb_peso);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txbCod_postal);
            this.Controls.Add(this.txbLocalidade);
            this.Controls.Add(this.txbRua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Editar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Editar_FormClosing);
            this.Load += new System.EventHandler(this.Editar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFotoPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txbCod_postal;
        private System.Windows.Forms.TextBox txbLocalidade;
        private System.Windows.Forms.TextBox txbRua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_peso;
        private System.Windows.Forms.Label lbl_peso;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.PictureBox picFotoPerfil;
        private System.Windows.Forms.Button btnAlterarFoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}