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
        public ListadoViajes listadoViajes;
        public List<Viajes> viajes;

        public FormViaje()
        {
            InitializeComponent();
        }

        public FormViaje(List<Viajes> viajes) : this()
        {
            this.viajes = viajes;
        }

        private void DataGridViajes(Viajes viajeAux)
        {
            DataGridViewRow filaUno = new DataGridViewRow();

            filaUno.CreateCells(this.dgv_Viajes);
            
            if (viajeAux.ViajeDisponible(viajeAux))
            {
                filaUno.Cells[0].Value = $"SI";
            }
            else
            {
                filaUno.Cells[0].Value = $"NO";
            }
            filaUno.Cells[1].Value = viajeAux.FechaPartida.ToString("dd/MM/yyyy");
            filaUno.Cells[2].Value = $"{viajeAux.Crucero.Matricula}";
            filaUno.Cells[3].Value = viajeAux.CamarotesTurista.ToString();
            filaUno.Cells[4].Value = viajeAux.CamarotesPremium.ToString();
            filaUno.Cells[5].Value = viajeAux.Destino.DestinoSeleccionado;
            
            this.dgv_Viajes.Rows.Add(filaUno);
        }

        private void FormViaje_Load(object sender, EventArgs e)
        {
            this.listadoViajes = new ListadoViajes();
            this.listadoViajes = FormMain.viajes;
            foreach (Viajes item in this.listadoViajes.Lista)
            {
                DataGridViajes(item);
            }
            
        }
    }
}
