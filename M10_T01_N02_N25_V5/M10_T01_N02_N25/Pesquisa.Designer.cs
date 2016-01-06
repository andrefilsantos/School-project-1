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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlbckResultados = new System.Windows.Forms.Panel();
            this.lblResultados = new System.Windows.Forms.Label();
            this.pnlbckResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.3F);
            this.txtPesquisa.Location = new System.Drawing.Point(13, 13);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(774, 26);
            this.txtPesquisa.TabIndex = 0;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnPesquisar.Image = global::M10_T01_N02_N25.Properties.Resources.search;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.Location = new System.Drawing.Point(677, 14);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(109, 28);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar   ";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
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
            // pnlbckResultados
            // 
            this.pnlbckResultados.BackColor = System.Drawing.Color.White;
            this.pnlbckResultados.Controls.Add(this.lblResultados);
            this.pnlbckResultados.Location = new System.Drawing.Point(13, 50);
            this.pnlbckResultados.Name = "pnlbckResultados";
            this.pnlbckResultados.Size = new System.Drawing.Size(773, 258);
            this.pnlbckResultados.TabIndex = 16;
            // 
            // lblResultados
            // 
            this.lblResultados.Location = new System.Drawing.Point(4, 4);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(766, 233);
            this.lblResultados.TabIndex = 0;
            this.lblResultados.Text = "Resultados da Pesquisa...";
            // 
            // frmPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 361);
            this.Controls.Add(this.pnlbckResultados);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pesquisa";
            this.Load += new System.EventHandler(this.frmPesquisa_Load);
            this.pnlbckResultados.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel pnlbckResultados;
        private System.Windows.Forms.Label lblResultados;
    }
}