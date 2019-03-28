namespace GesBancaire
{
    partial class FrmOperations
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.rdCredit = new System.Windows.Forms.RadioButton();
            this.rdDebit = new System.Windows.Forms.RadioButton();
            this.grd = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.lblSolde = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(12, 56);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 29);
            this.txtCode.TabIndex = 1;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Montant";
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(132, 56);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(100, 29);
            this.txtMontant.TabIndex = 1;
            this.txtMontant.TextChanged += new System.EventHandler(this.txtMontant_TextChanged);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(442, 57);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(145, 29);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // rdCredit
            // 
            this.rdCredit.AutoSize = true;
            this.rdCredit.Checked = true;
            this.rdCredit.Location = new System.Drawing.Point(44, 46);
            this.rdCredit.Name = "rdCredit";
            this.rdCredit.Size = new System.Drawing.Size(83, 28);
            this.rdCredit.TabIndex = 3;
            this.rdCredit.TabStop = true;
            this.rdCredit.Text = "Crédit";
            this.rdCredit.UseVisualStyleBackColor = true;
            this.rdCredit.CheckedChanged += new System.EventHandler(this.rdCredit_CheckedChanged);
            // 
            // rdDebit
            // 
            this.rdDebit.AutoSize = true;
            this.rdDebit.Location = new System.Drawing.Point(160, 46);
            this.rdDebit.Name = "rdDebit";
            this.rdDebit.Size = new System.Drawing.Size(76, 28);
            this.rdDebit.TabIndex = 3;
            this.rdDebit.Text = "Débit";
            this.rdDebit.UseVisualStyleBackColor = true;
            this.rdDebit.CheckedChanged += new System.EventHandler(this.rdDebit_CheckedChanged);
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Location = new System.Drawing.Point(12, 248);
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(458, 252);
            this.grd.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 221);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Historique :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.rdDebit);
            this.groupBox1.Controls.Add(this.rdCredit);
            this.groupBox1.Location = new System.Drawing.Point(12, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type d\'Operation : ";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Solde";
            // 
            // lblSolde
            // 
            this.lblSolde.AutoSize = true;
            this.lblSolde.ForeColor = System.Drawing.Color.Red;
            this.lblSolde.Location = new System.Drawing.Point(300, 59);
            this.lblSolde.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSolde.Name = "lblSolde";
            this.lblSolde.Size = new System.Drawing.Size(21, 24);
            this.lblSolde.TabIndex = 0;
            this.lblSolde.Text = "0";
            // 
            // FrmOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 598);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.lblSolde);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmOperations";
            this.Text = "FrmOperations";
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.RadioButton rdCredit;
        private System.Windows.Forms.RadioButton rdDebit;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Label lblSolde;
        private System.Windows.Forms.Label label4;
    }
}