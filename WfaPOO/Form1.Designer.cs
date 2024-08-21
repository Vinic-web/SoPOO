    namespace WfaPOO
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTriangulo = new System.Windows.Forms.ComboBox();
            this.cmbFormas = new System.Windows.Forms.ComboBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblAtura = new System.Windows.Forms.Label();
            this.lblRaio = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.btnCriar = new System.Windows.Forms.Button();
            this.cmbCriar = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCriar);
            this.groupBox1.Controls.Add(this.btnCriar);
            this.groupBox1.Controls.Add(this.lblPerimetro);
            this.groupBox1.Controls.Add(this.lblArea);
            this.groupBox1.Controls.Add(this.txtPerimetro);
            this.groupBox1.Controls.Add(this.txtArea);
            this.groupBox1.Controls.Add(this.txtRaio);
            this.groupBox1.Controls.Add(this.txtAltura);
            this.groupBox1.Controls.Add(this.txtBase);
            this.groupBox1.Controls.Add(this.lblRaio);
            this.groupBox1.Controls.Add(this.lblAtura);
            this.groupBox1.Controls.Add(this.lblBase);
            this.groupBox1.Controls.Add(this.cmbTriangulo);
            this.groupBox1.Controls.Add(this.cmbFormas);
            this.groupBox1.Location = new System.Drawing.Point(28, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formas Geometricas";
            // 
            // cmbTriangulo
            // 
            this.cmbTriangulo.FormattingEnabled = true;
            this.cmbTriangulo.Items.AddRange(new object[] {
            "Triângulo Isoceles",
            "Triângulo Equilatero",
            "Triângulo Reto"});
            this.cmbTriangulo.Location = new System.Drawing.Point(192, 36);
            this.cmbTriangulo.Name = "cmbTriangulo";
            this.cmbTriangulo.Size = new System.Drawing.Size(121, 21);
            this.cmbTriangulo.TabIndex = 1;
            this.cmbTriangulo.Visible = false;
            this.cmbTriangulo.SelectedIndexChanged += new System.EventHandler(this.cmbTriangulo_SelectedIndexChanged);
            // 
            // cmbFormas
            // 
            this.cmbFormas.FormattingEnabled = true;
            this.cmbFormas.Items.AddRange(new object[] {
            "Circunferência",
            "Quadrado",
            "Retângulo",
            "Triângulo",
            ""});
            this.cmbFormas.Location = new System.Drawing.Point(38, 36);
            this.cmbFormas.Name = "cmbFormas";
            this.cmbFormas.Size = new System.Drawing.Size(121, 21);
            this.cmbFormas.TabIndex = 0;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(35, 82);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(31, 13);
            this.lblBase.TabIndex = 2;
            this.lblBase.Text = "Base";
            // 
            // lblAtura
            // 
            this.lblAtura.AutoSize = true;
            this.lblAtura.Location = new System.Drawing.Point(35, 129);
            this.lblAtura.Name = "lblAtura";
            this.lblAtura.Size = new System.Drawing.Size(34, 13);
            this.lblAtura.TabIndex = 3;
            this.lblAtura.Text = "Altura";
            // 
            // lblRaio
            // 
            this.lblRaio.AutoSize = true;
            this.lblRaio.Location = new System.Drawing.Point(35, 171);
            this.lblRaio.Name = "lblRaio";
            this.lblRaio.Size = new System.Drawing.Size(29, 13);
            this.lblRaio.TabIndex = 4;
            this.lblRaio.Text = "Raio";
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(83, 79);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 20);
            this.txtBase.TabIndex = 5;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(83, 129);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 6;
            // 
            // txtRaio
            // 
            this.txtRaio.Location = new System.Drawing.Point(83, 171);
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(100, 20);
            this.txtRaio.TabIndex = 7;
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(348, 104);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 9;
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Enabled = false;
            this.txtPerimetro.Location = new System.Drawing.Point(348, 147);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.Size = new System.Drawing.Size(100, 20);
            this.txtPerimetro.TabIndex = 10;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(301, 107);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(29, 13);
            this.lblArea.TabIndex = 11;
            this.lblArea.Text = "Area";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(301, 150);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(31, 13);
            this.lblPerimetro.TabIndex = 12;
            this.lblPerimetro.Text = "Base";
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(414, 36);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(45, 21);
            this.btnCriar.TabIndex = 13;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            // 
            // cmbCriar
            // 
            this.cmbCriar.FormattingEnabled = true;
            this.cmbCriar.Location = new System.Drawing.Point(490, 36);
            this.cmbCriar.Name = "cmbCriar";
            this.cmbCriar.Size = new System.Drawing.Size(121, 21);
            this.cmbCriar.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "MB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbFormas;
        private System.Windows.Forms.ComboBox cmbTriangulo;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label lblRaio;
        private System.Windows.Forms.Label lblAtura;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.ComboBox cmbCriar;
        private System.Windows.Forms.Button btnCriar;
    }
}

