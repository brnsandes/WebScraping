namespace WebScraping
{
    partial class Form_Principal
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
            this.txtpesquisar = new System.Windows.Forms.TextBox();
            this.lblpesquisar = new System.Windows.Forms.Label();
            this.btnscraping = new System.Windows.Forms.Button();
            this.cmbselecione = new System.Windows.Forms.ComboBox();
            this.btnsair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtpesquisar
            // 
            this.txtpesquisar.Location = new System.Drawing.Point(67, 162);
            this.txtpesquisar.Name = "txtpesquisar";
            this.txtpesquisar.Size = new System.Drawing.Size(199, 20);
            this.txtpesquisar.TabIndex = 0;
            this.txtpesquisar.TextChanged += new System.EventHandler(this.txtpesquisar_TextChanged);
            // 
            // lblpesquisar
            // 
            this.lblpesquisar.AutoSize = true;
            this.lblpesquisar.Location = new System.Drawing.Point(103, 146);
            this.lblpesquisar.Name = "lblpesquisar";
            this.lblpesquisar.Size = new System.Drawing.Size(124, 13);
            this.lblpesquisar.TabIndex = 1;
            this.lblpesquisar.Text = "O que deseja pesquisar?";
            this.lblpesquisar.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnscraping
            // 
            this.btnscraping.Location = new System.Drawing.Point(28, 232);
            this.btnscraping.Name = "btnscraping";
            this.btnscraping.Size = new System.Drawing.Size(120, 23);
            this.btnscraping.TabIndex = 2;
            this.btnscraping.Text = "Iniciar scraping";
            this.btnscraping.UseVisualStyleBackColor = true;
            this.btnscraping.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbselecione
            // 
            this.cmbselecione.FormattingEnabled = true;
            this.cmbselecione.Items.AddRange(new object[] {
            "Magazine Luiza",
            "Amazon"});
            this.cmbselecione.Location = new System.Drawing.Point(67, 87);
            this.cmbselecione.Name = "cmbselecione";
            this.cmbselecione.Size = new System.Drawing.Size(188, 21);
            this.cmbselecione.TabIndex = 3;
            this.cmbselecione.Text = "Selecione um item";
            this.cmbselecione.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(250, 232);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 4;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pesquisador de lojas";
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 277);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.cmbselecione);
            this.Controls.Add(this.btnscraping);
            this.Controls.Add(this.lblpesquisar);
            this.Controls.Add(this.txtpesquisar);
            this.Name = "Form_Principal";
            this.Text = "Pesquisador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpesquisar;
        private System.Windows.Forms.Label lblpesquisar;
        private System.Windows.Forms.Button btnscraping;
        private System.Windows.Forms.ComboBox cmbselecione;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Label label1;
    }
}

