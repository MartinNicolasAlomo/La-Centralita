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
    public partial class FrmMostrar : Form
    {
        private Central centralita;
        private ETipoLlamada tipoLlamada;

        public FrmMostrar(Central centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
        }

        public ETipoLlamada TipoLlamada
        {
            set { tipoLlamada = value; }
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            rtb_MostrarDatos.Text = $"Estado de cuenta:{Environment.NewLine}{Environment.NewLine}";
            if (tipoLlamada == ETipoLlamada.Local)
            {
                Text = "Facturación por llamadas locales:";
                rtb_MostrarDatos.AppendText($"{centralita.GananciasPorLocal:c2}");
            }
            else if (tipoLlamada == ETipoLlamada.Provincial)
            {
                Text = "Facturación por llamadas provinciales:";
                rtb_MostrarDatos.AppendText($"{centralita.GananciasPorProvincial:c2}");
            }
            else
            {
                Text = "Facturación total:";
                rtb_MostrarDatos.AppendText($"{centralita.GananciasPorTotal:c2}");
            }
        }

        private void FrmMostrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }



    }
}
