using EspacioCentralita;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_WinForms
{
    public partial class Form1 : Form
    {
        private Central centralTelefonica;

        
        public Form1()
        {
            InitializeComponent();
            centralTelefonica = new Central("Telefonica S.A.");
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            Hide();
            FrmLlamador frmLlamador = new FrmLlamador(centralTelefonica);
            DialogResult resultado = frmLlamador.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                centralTelefonica = frmLlamador.Centralita;
                Show();
            }
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            Hide();
            FrmMostrar frmMostrar = new FrmMostrar(centralTelefonica);
            frmMostrar.TipoLlamada = ETipoLlamada.Total;
            DialogResult resultado = frmMostrar.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Show();
            }
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            Hide();
            FrmMostrar frmMostrar = new FrmMostrar(centralTelefonica);
            frmMostrar.TipoLlamada = ETipoLlamada.Local;
            DialogResult resultado = frmMostrar.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Show();
            }
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            Hide();
            FrmMostrar frmMostrar = new FrmMostrar(centralTelefonica);
            frmMostrar.TipoLlamada = ETipoLlamada.Provincial;
            DialogResult resultado = frmMostrar.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Show();
            }
        }



    }
}
