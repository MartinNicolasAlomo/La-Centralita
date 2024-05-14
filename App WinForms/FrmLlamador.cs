using Centralita;
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
using static EspacioCentralita.Provincial;

namespace App_WinForms
{
    public partial class FrmLlamador : Form
    {
        private Central centralita;
        private string numeroDestino;
        private string numeroOrigen;
        EFranjas franjas;


        public FrmLlamador(Central centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
            numeroOrigen = "40401515";
            numeroDestino = string.Empty;
            tbx_NumeroOrigen.Text = numeroOrigen;
        }


        public Central Centralita
        {
            get { return centralita; }
        }


        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            cmb_Franja.DataSource = Enum.GetValues(typeof(EFranjas));
            tbx_NumeroDestino.PlaceholderText = "Nro. de Destino";
        }

        private void FrmLlamador_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }


        private void btn_Llamar_Click(object sender, EventArgs e)
        {
            numeroDestino = tbx_NumeroDestino.Text;
            bool esProvincial;
            if (Validador.ValidarTelefonoIngresado(ref numeroDestino, 20, out esProvincial))
            {
                int duracionLlamada = Validador.CrearNumeroAleatorio(1, 50);
                if (esProvincial)
                {
                    Provincial llamadaRealizada = new Provincial(numeroOrigen, franjas, duracionLlamada, numeroDestino);
                    AgregarLlamadaCentralita(llamadaRealizada);
                }
                else
                {
                    Local llamadaRealizada = new Local(numeroOrigen, duracionLlamada, numeroDestino, Validador.CrearNumeroAleatorio());
                    AgregarLlamadaCentralita(llamadaRealizada);
                }
            }
            else
            {
                MessageBox.Show($"¡Error! No es un teléfono válido.");
            }



        }

        private void AgregarLlamadaCentralita(Llamada llamadaRealizada)
        {
            if (centralita + llamadaRealizada)
            {
                MessageBox.Show(llamadaRealizada.ToString());
            }
            else
            {
                MessageBox.Show($"¡La llamada {llamadaRealizada.NumeroDestino} ya existe en el registro!");
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            tbx_NumeroDestino.Text = string.Empty;
        }

        private void cmb_Franja_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse<EFranjas>(cmb_Franja.SelectedValue.ToString(), out franjas);
        }

        #region CLICKS - TECLAS DEL PANEL NUMERICO

        private void btn_Tecla1_Click(object sender, EventArgs e)
        {
            tbx_NumeroDestino.Text += '1';
        }

        private void buttonbtn_Tecla2_Click(object sender, EventArgs e)
        {
            tbx_NumeroDestino.Text += '2';
        }

        private void btn_Tecla3_Click(object sender, EventArgs e)
        {
            tbx_NumeroDestino.Text += '3';
        }

        private void btn_Tecla4_Click(object sender, EventArgs e)
        {
            tbx_NumeroDestino.Text += '4';
        }

        private void btn_Tecla5_Click(object sender, EventArgs e)
        {
            tbx_NumeroDestino.Text += '5';
        }

        private void btn_Tecla6_Click(object sender, EventArgs e)
        {
            tbx_NumeroDestino.Text += '6';
        }

        private void btn_Tecla7_Click(object sender, EventArgs e)
        {
            tbx_NumeroDestino.Text += '7';
        }

        private void btn_Tecla8_Click(object sender, EventArgs e)
        {
            tbx_NumeroDestino.Text += '8';
        }

        private void btn_Tecla9_Click(object sender, EventArgs e)
        {
            tbx_NumeroDestino.Text += '9';
        }

        private void btn_Tecla0_Click(object sender, EventArgs e)
        {
            tbx_NumeroDestino.Text += '0';
        }

        private void btn_TeclaAterisco_Click(object sender, EventArgs e)
        {
            tbx_NumeroDestino.Text += '*';
        }

        private void btn_TeclaNumeral_Click(object sender, EventArgs e)
        {
            tbx_NumeroDestino.Text += '#';
            HabilitarComboBox();
        }

        private void HabilitarComboBox()
        {
            //if (tbx_NumeroDestino.Text[0] == '#')
            //{
            //    cmb_Franja.Enabled = true;
            //}
            //else if (tbx_NumeroDestino.Text[0] != '#' && tbx_NumeroDestino.Text[1] != '#')
            //{
            //    cmb_Franja.Enabled = false;
            //}

            numeroDestino = tbx_NumeroDestino.Text;
            for (int i = 0; i < numeroDestino.Length && numeroDestino[i] != '\0'; i++)
            {
                if (i == 0 && numeroDestino[0] == '#')
                {
                    cmb_Franja.Enabled = true;
                }
                else if (i == 0 && numeroDestino[0] != '#')
                {
                    cmb_Franja.Enabled = false;
                }
            }
        }

        #endregion


    }
}
