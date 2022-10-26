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
    public partial class FormCruceros : Form
    {

        private List<Cruceros> listaCrucero = new List<Cruceros>();
        private ListadoViajes listaDeViajes = new ListadoViajes();
        public FormCruceros()
        {
            InitializeComponent();
        }

        private void FormCruceros_Load(object sender, EventArgs e)
        {
            this.listaCrucero = FormMain.listaCruceros;
            this.listaDeViajes = FormMain.viajes;

            this.CrucerosDeLaFlota();
        }

        private void DataGridCruceros(Cruceros cruceroAux, Viajes viajeAux)
        {
            Viajes capacidadCrucero = new Viajes();
            capacidadCrucero.Crucero = cruceroAux;

            DataGridViewRow filaUno = new DataGridViewRow();

            filaUno.CreateCells(this.dgv_Cruceros);
            filaUno.Cells[0].Value = cruceroAux.Nombre;
            filaUno.Cells[1].Value = cruceroAux.Matricula;
            filaUno.Cells[2].Value = cruceroAux.Camarotes;
            filaUno.Cells[3].Value = $"{cruceroAux.Bodega}Kg";
            filaUno.Cells[4].Value = cruceroAux.SalonesDelCrucero.Comedores;
            filaUno.Cells[5].Value = cruceroAux.SalonesDelCrucero.Casinos;
            filaUno.Cells[6].Value = cruceroAux.SalonesDelCrucero.Piscinas;
            filaUno.Cells[7].Value = cruceroAux.SalonesDelCrucero.SalonesBaile;
            filaUno.Cells[8].Value = cruceroAux.Pasajeros.Count;
            filaUno.Cells[9].Value = capacidadCrucero.CamarotesPremium;
            filaUno.Cells[10].Value = capacidadCrucero.CamarotesTurista;
            //filaUno.Cells[11].Value = viajeAux.Destino.DestinoSeleccionado;

            if (!(viajeAux.ViajeDisponible(viajeAux)))
            {
                if (viajeAux.FechaPartida <= DateTime.Now)
                {
                    filaUno.Cells[12].Value = "EN VIAJE";
                }
                else
                {
                    if (viajeAux.CamarotesPremium < 1 && viajeAux.CamarotesTurista < 1)
                    {
                        filaUno.Cells[12].Value = "COMPLETO";
                    }
                }
            }
            else
            {
                filaUno.Cells[12].Value = "DISPONIBLE";
            }

            this.dgv_Cruceros.Rows.Add(filaUno);
        }

        private void CrucerosDeLaFlota()
        {
            Viajes viajeVacio = new Viajes();
            viajeVacio.FechaPartida = new DateTime(2023, 01, 01);


            this.dgv_Cruceros.Rows.Clear();
            bool inList = false;

            ///Carga Los que estan en la lista con datos extra
            for (int i = 0; i < this.listaDeViajes.Count; i++)
            {
                this.DataGridCruceros(this.listaDeViajes.Lista[i].Crucero, this.listaDeViajes.Lista[i]);
            }

            ///Carga los que no estan en lista y algunos datos vacios
            for (int i = 0; i < this.listaCrucero.Count; i++)
            {
                inList = false;

                for (int j = 0; j < this.listaDeViajes.Lista.Count; j++)
                {
                    if (listaDeViajes.Lista[j].Crucero == this.listaCrucero[i])
                    {
                        inList = true;
                    }
                }

                if (inList == false)
                {
                    viajeVacio.Crucero = this.listaCrucero[i];
                    this.DataGridCruceros(this.listaCrucero[i], viajeVacio);
                }
            }

        }

        private void dgv_Cruceros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
