using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Compañia;

namespace FormMain
{
    public partial class FormViaje : Form
    {
        public FormViaje()
        {
            InitializeComponent();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridViajes(Viajes viajeAaux)
        {
            DataGridViewRow filaUno = new DataGridViewRow();

            filaUno.CreateCells(this.dgv_Viajes);

            filaUno.Cells[0].Value = viajeAaux.Destino.DestinoSeleccionado;
            filaUno.Cells[1].Value = viajeAaux.FechaPartida.ToString("dd/MM/yyyy");
            filaUno.Cells[2].Value = viajeAaux.Crucero.Matricula;
            filaUno.Cells[3].Value = viajeAaux.CamarotesTurista.ToString();
            filaUno.Cells[4].Value = viajeAaux.CamarotesPremium.ToString();
            filaUno.Cells[5].Value = $"${viajeAaux.PrecioTurista.ToString()}";
            filaUno.Cells[6].Value = $"${viajeAaux.PrecioPremium.ToString()}";


            if (viajeAaux.ViajeDisponible(viajeAaux))
            {
                filaUno.Cells[7].Value = $"SI";
            }
            else
            {
                filaUno.Cells[7].Value = $"NO";
            }

            this.dgv_Viajes.Rows.Add(filaUno);
        }

        private void FrmViaje_Load(object sender, EventArgs e)
        {
            
        }
    }
}
