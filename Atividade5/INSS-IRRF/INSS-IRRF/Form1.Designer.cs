
namespace INSS_IRRF
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
            this.components = new System.ComponentModel.Container();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblsalariob = new System.Windows.Forms.Label();
            this.lblfilhos = new System.Windows.Forms.Label();
            this.lblaliqinss = new System.Windows.Forms.Label();
            this.lblaliqirpf = new System.Windows.Forms.Label();
            this.lblsalariof = new System.Windows.Forms.Label();
            this.lblsalariol = new System.Windows.Forms.Label();
            this.lbldescinss = new System.Windows.Forms.Label();
            this.lbldescirpf = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtsalariof = new System.Windows.Forms.TextBox();
            this.txtaliqirpf = new System.Windows.Forms.TextBox();
            this.txtaliqinss = new System.Windows.Forms.TextBox();
            this.txtsalariol = new System.Windows.Forms.TextBox();
            this.txtdescirpf = new System.Windows.Forms.TextBox();
            this.txtdescinss = new System.Windows.Forms.TextBox();
            this.mskbxsalariob = new System.Windows.Forms.MaskedTextBox();
            this.btnverificar = new System.Windows.Forms.Button();
            this.numfilhos = new System.Windows.Forms.NumericUpDown();
            this.errorNome = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSalBruto = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numfilhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSalBruto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(52, 35);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(90, 13);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "Nome funcionário";
            // 
            // lblsalariob
            // 
            this.lblsalariob.AutoSize = true;
            this.lblsalariob.Location = new System.Drawing.Point(52, 70);
            this.lblsalariob.Name = "lblsalariob";
            this.lblsalariob.Size = new System.Drawing.Size(66, 13);
            this.lblsalariob.TabIndex = 1;
            this.lblsalariob.Text = "Salário bruto";
            // 
            // lblfilhos
            // 
            this.lblfilhos.AutoSize = true;
            this.lblfilhos.Location = new System.Drawing.Point(52, 105);
            this.lblfilhos.Name = "lblfilhos";
            this.lblfilhos.Size = new System.Drawing.Size(86, 13);
            this.lblfilhos.TabIndex = 2;
            this.lblfilhos.Text = "Número de filhos";
            // 
            // lblaliqinss
            // 
            this.lblaliqinss.AutoSize = true;
            this.lblaliqinss.Location = new System.Drawing.Point(53, 208);
            this.lblaliqinss.Name = "lblaliqinss";
            this.lblaliqinss.Size = new System.Drawing.Size(75, 13);
            this.lblaliqinss.TabIndex = 3;
            this.lblaliqinss.Text = "Alíquota INSS";
            // 
            // lblaliqirpf
            // 
            this.lblaliqirpf.AutoSize = true;
            this.lblaliqirpf.Location = new System.Drawing.Point(52, 249);
            this.lblaliqirpf.Name = "lblaliqirpf";
            this.lblaliqirpf.Size = new System.Drawing.Size(74, 13);
            this.lblaliqirpf.TabIndex = 4;
            this.lblaliqirpf.Text = "Alíquota IRPF";
            // 
            // lblsalariof
            // 
            this.lblsalariof.AutoSize = true;
            this.lblsalariof.Location = new System.Drawing.Point(52, 290);
            this.lblsalariof.Name = "lblsalariof";
            this.lblsalariof.Size = new System.Drawing.Size(76, 13);
            this.lblsalariof.TabIndex = 5;
            this.lblsalariof.Text = "Salário Família";
            // 
            // lblsalariol
            // 
            this.lblsalariol.AutoSize = true;
            this.lblsalariol.Location = new System.Drawing.Point(53, 331);
            this.lblsalariol.Name = "lblsalariol";
            this.lblsalariol.Size = new System.Drawing.Size(78, 13);
            this.lblsalariol.TabIndex = 6;
            this.lblsalariol.Text = "Salário Líquido";
            // 
            // lbldescinss
            // 
            this.lbldescinss.AutoSize = true;
            this.lbldescinss.Location = new System.Drawing.Point(383, 208);
            this.lbldescinss.Name = "lbldescinss";
            this.lbldescinss.Size = new System.Drawing.Size(81, 13);
            this.lbldescinss.TabIndex = 7;
            this.lbldescinss.Text = "Desconto INSS";
            // 
            // lbldescirpf
            // 
            this.lbldescirpf.AutoSize = true;
            this.lbldescirpf.Location = new System.Drawing.Point(383, 252);
            this.lbldescirpf.Name = "lbldescirpf";
            this.lbldescirpf.Size = new System.Drawing.Size(80, 13);
            this.lbldescirpf.TabIndex = 8;
            this.lbldescirpf.Text = "Desconto IRPF";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(148, 32);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(116, 20);
            this.txtnome.TabIndex = 1;
            this.txtnome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnome_KeyPress);
            // 
            // txtsalariof
            // 
            this.txtsalariof.Enabled = false;
            this.txtsalariof.Location = new System.Drawing.Point(148, 287);
            this.txtsalariof.Name = "txtsalariof";
            this.txtsalariof.ReadOnly = true;
            this.txtsalariof.Size = new System.Drawing.Size(116, 20);
            this.txtsalariof.TabIndex = 6;
            // 
            // txtaliqirpf
            // 
            this.txtaliqirpf.Enabled = false;
            this.txtaliqirpf.Location = new System.Drawing.Point(148, 246);
            this.txtaliqirpf.Name = "txtaliqirpf";
            this.txtaliqirpf.ReadOnly = true;
            this.txtaliqirpf.Size = new System.Drawing.Size(116, 20);
            this.txtaliqirpf.TabIndex = 5;
            // 
            // txtaliqinss
            // 
            this.txtaliqinss.Enabled = false;
            this.txtaliqinss.Location = new System.Drawing.Point(148, 205);
            this.txtaliqinss.Name = "txtaliqinss";
            this.txtaliqinss.ReadOnly = true;
            this.txtaliqinss.Size = new System.Drawing.Size(116, 20);
            this.txtaliqinss.TabIndex = 4;
            // 
            // txtsalariol
            // 
            this.txtsalariol.Enabled = false;
            this.txtsalariol.Location = new System.Drawing.Point(148, 328);
            this.txtsalariol.Name = "txtsalariol";
            this.txtsalariol.ReadOnly = true;
            this.txtsalariol.Size = new System.Drawing.Size(116, 20);
            this.txtsalariol.TabIndex = 7;
            // 
            // txtdescirpf
            // 
            this.txtdescirpf.Enabled = false;
            this.txtdescirpf.Location = new System.Drawing.Point(470, 249);
            this.txtdescirpf.Name = "txtdescirpf";
            this.txtdescirpf.ReadOnly = true;
            this.txtdescirpf.Size = new System.Drawing.Size(116, 20);
            this.txtdescirpf.TabIndex = 9;
            // 
            // txtdescinss
            // 
            this.txtdescinss.Enabled = false;
            this.txtdescinss.Location = new System.Drawing.Point(470, 205);
            this.txtdescinss.Name = "txtdescinss";
            this.txtdescinss.ReadOnly = true;
            this.txtdescinss.Size = new System.Drawing.Size(116, 20);
            this.txtdescinss.TabIndex = 8;
            // 
            // mskbxsalariob
            // 
            this.mskbxsalariob.Location = new System.Drawing.Point(148, 67);
            this.mskbxsalariob.Mask = "00000.00";
            this.mskbxsalariob.Name = "mskbxsalariob";
            this.mskbxsalariob.Size = new System.Drawing.Size(116, 20);
            this.mskbxsalariob.TabIndex = 2;
            this.mskbxsalariob.Validated += new System.EventHandler(this.mskbxsalariob_Validated);
            // 
            // btnverificar
            // 
            this.btnverificar.Location = new System.Drawing.Point(258, 142);
            this.btnverificar.Name = "btnverificar";
            this.btnverificar.Size = new System.Drawing.Size(169, 43);
            this.btnverificar.TabIndex = 10;
            this.btnverificar.Text = "Verificar desconto";
            this.btnverificar.UseVisualStyleBackColor = true;
            this.btnverificar.Click += new System.EventHandler(this.btnverificar_Click);
            // 
            // numfilhos
            // 
            this.numfilhos.Location = new System.Drawing.Point(148, 103);
            this.numfilhos.Name = "numfilhos";
            this.numfilhos.Size = new System.Drawing.Size(116, 20);
            this.numfilhos.TabIndex = 3;
            // 
            // errorNome
            // 
            this.errorNome.ContainerControl = this;
            // 
            // errorSalBruto
            // 
            this.errorSalBruto.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 376);
            this.Controls.Add(this.numfilhos);
            this.Controls.Add(this.btnverificar);
            this.Controls.Add(this.mskbxsalariob);
            this.Controls.Add(this.txtdescirpf);
            this.Controls.Add(this.txtdescinss);
            this.Controls.Add(this.txtsalariol);
            this.Controls.Add(this.txtsalariof);
            this.Controls.Add(this.txtaliqirpf);
            this.Controls.Add(this.txtaliqinss);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lbldescirpf);
            this.Controls.Add(this.lbldescinss);
            this.Controls.Add(this.lblsalariol);
            this.Controls.Add(this.lblsalariof);
            this.Controls.Add(this.lblaliqirpf);
            this.Controls.Add(this.lblaliqinss);
            this.Controls.Add(this.lblfilhos);
            this.Controls.Add(this.lblsalariob);
            this.Controls.Add(this.lblnome);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numfilhos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSalBruto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblsalariob;
        private System.Windows.Forms.Label lblfilhos;
        private System.Windows.Forms.Label lblaliqinss;
        private System.Windows.Forms.Label lblaliqirpf;
        private System.Windows.Forms.Label lblsalariof;
        private System.Windows.Forms.Label lblsalariol;
        private System.Windows.Forms.Label lbldescinss;
        private System.Windows.Forms.Label lbldescirpf;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtsalariof;
        private System.Windows.Forms.TextBox txtaliqirpf;
        private System.Windows.Forms.TextBox txtaliqinss;
        private System.Windows.Forms.TextBox txtsalariol;
        private System.Windows.Forms.TextBox txtdescirpf;
        private System.Windows.Forms.TextBox txtdescinss;
        private System.Windows.Forms.MaskedTextBox mskbxsalariob;
        private System.Windows.Forms.Button btnverificar;
        private System.Windows.Forms.NumericUpDown numfilhos;
        private System.Windows.Forms.ErrorProvider errorNome;
        private System.Windows.Forms.ErrorProvider errorSalBruto;
    }
}

