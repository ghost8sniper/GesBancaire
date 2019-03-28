using GesBancaire.DSTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesBancaire
{
    public partial class Form1 : Form
    {
        compteTableAdapter adaCompte = new compteTableAdapter();
        public Form1()
        {
            InitializeComponent();
        }

     
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCode.DisplayMember = "code";
            cmbCode.ValueMember = "nom";
            cmbCode.DataSource = adaCompte.GetData();
            grd.DataSource = adaCompte.GetData(); 
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            grd.DataSource = adaCompte.GetData(); 
        }

        private void cmbCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNom.Text = cmbCode.SelectedValue.ToString();
        }
    }
}
