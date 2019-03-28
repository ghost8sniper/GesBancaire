using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using a = GesBancaire.DSTableAdapters;

namespace GesBancaire
{
    public partial class FrmOperations : Form
    {
        int code;
        double montant;
        double? solde;
        bool OkCode = false, OkMnt=false;
        
        a.operationTableAdapter adaOp = new a.operationTableAdapter();
        a.F f = new a.F();
        public FrmOperations()
        {
            InitializeComponent();
            AfficherBtn();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            adaOp.Insert(code, Signe() * montant);
            solde = f.Solde(code);
            lblSolde.Text = solde.ToString();
            grd.DataSource = adaOp.GetData();
        }

        void AfficherBtn()
        {
            btnValider.Enabled = OkCode && OkMnt && (rdCredit.Checked ||  (rdDebit.Checked && (solde > montant)));
        }
        int Signe()
        {
            return rdCredit.Checked ? 1 : -1;
        }
        private void txtMontant_TextChanged(object sender, EventArgs e)
        {
            if(double.TryParse(txtMontant.Text, out montant))
            {
                montant = Math.Abs(montant);
                error.SetError(txtMontant, "");
                OkCode = true;
            }
               else
            {
                error.SetError(txtMontant, "Montant invalide !");
                OkCode = false;
            }
            AfficherBtn();
        }

        private void rdCredit_CheckedChanged(object sender, EventArgs e)
        {
            AfficherBtn();
        }

        private void rdDebit_CheckedChanged(object sender, EventArgs e)
        {
            AfficherBtn();
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtCode.Text, out code))
            {
                solde = f.Solde(code);
                lblSolde.Text = solde.ToString();
                Text = "";
                OkMnt = true;
            }
            else
            {
                solde = null;
                lblSolde.Text = "?";
                Text = "Code invalide !";
                OkMnt = false;
            }
            AfficherBtn();
        }
    }
}
