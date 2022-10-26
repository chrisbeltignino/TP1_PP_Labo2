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
    public partial class FormCrearCrucero : Form
    {
        private List<Cruceros> listaCrucero = new List<Cruceros>();
        private ListadoViajes listaDeViajes = new ListadoViajes();

        private bool esRegional = false;
        public FormCrearCrucero()
        {
            InitializeComponent();
        }

        private void FormCrearCrucero_Load(object sender, EventArgs e)
        {
            listaCrucero = FormMain.listaCruceros;
            listaDeViajes = FormMain.viajes;

            CrucerosDeLaFlota();
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
            bool isOk = false;

            for (int i = 0; i < this.listaDeViajes.Count; i++)
            {
                this.DataGridCruceros(this.listaDeViajes.Lista[i].Crucero, this.listaDeViajes.Lista[i]);
            }

            for (int i = 0; i < this.listaCrucero.Count; i++)
            {
                isOk = false;

                for (int j = 0; j < this.listaDeViajes.Lista.Count; j++)
                {
                    if (listaDeViajes.Lista[j].Crucero == this.listaCrucero[i])
                    {
                        isOk = true;
                    }
                }

                if (isOk == false)
                {
                    viajeVacio.Crucero = this.listaCrucero[i];
                    this.DataGridCruceros(this.listaCrucero[i], viajeVacio);
                }
            }
        }

        private void chb_Regional_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chb_Regional.Checked)
            {
                this.esRegional = true;
            }
            else
            {
                this.esRegional = false;
            }
        }

        private void btn_ConfirmarRegional_Click(object sender, EventArgs e)
        {
            if (this.chb_Regional.Checked == true)
            {
                this.cmb_ProxViaje.Items.Clear();
                for (int i = 10; i < 18; i++)
                {
                    this.cmb_ProxViaje.Enabled = true;
                    this.cmb_ProxViaje.Items.Add((eDestinos)i);
                }
            }
            else
            {
                this.cmb_ProxViaje.Items.Clear();
                for (int i = 0; i < 10; i++)
                {
                    this.cmb_ProxViaje.Enabled = true;
                    this.cmb_ProxViaje.Items.Add((eDestinos)i);
                }
            }
        }

        private void VaciarDatos()
        {
            foreach (TextBox item in gpb_Crucero.Controls)
            {
                item.Text = " ";
            }
            foreach (ComboBox item in gpb_Crucero.Controls)
            {
                item.SelectedIndex = 0;
            }
        }

        private void btn_AgregarCrucero_Click(object sender, EventArgs e)
        {
            Viajes nuevoViaje = new Viajes();
            Cruceros auxCrucero = new Cruceros();
            Salones salones = new Salones();

            nuevoViaje.Crucero = auxCrucero;
            auxCrucero.SalonesDelCrucero = salones;

            bool isOk = false;

            if (txt_Nombre.Text != "" && txt_Matricula.Text != "" && txt_Bodega.Text != "" && txt_TotalCamarotes.Text != "" && txt_Restaurante.Text != "")
            { 
                string auxNombre = txt_Nombre.Text;
                string auxMatricula = txt_Matricula.Text;
                double auxBodega = Convert.ToDouble(txt_Bodega.Text);
                int auxTotalCamarotes = Convert.ToInt32(txt_TotalCamarotes.Text);
                int auxRestaurantes = Convert.ToInt32(txt_Restaurante.Text);
                int auxPiscinas = Convert.ToInt32(txt_Piscinas.Text);
                int auxSalonesBaile = Convert.ToInt32(txt_SalonesBaile.Text);
                int auxCasinos = Convert.ToInt32(txt_Casinos.Text);

                txt_TotalCamarotes.Text = Convert.ToString(auxTotalCamarotes);

                auxCrucero.Nombre = auxNombre;
                auxCrucero.Matricula = auxMatricula;
                auxCrucero.Camarotes = auxTotalCamarotes;
                auxCrucero.Bodega = auxBodega;
                auxCrucero.SalonesDelCrucero.Casinos = auxCasinos;
                auxCrucero.SalonesDelCrucero.Comedores = auxRestaurantes;
                auxCrucero.SalonesDelCrucero.Piscinas = auxPiscinas;
                auxCrucero.SalonesDelCrucero.SalonesBaile = auxSalonesBaile;

                nuevoViaje.FechaPartida = dateTimePicker1.Value;

                isOk = true;
            }
            else
            {
                MessageBox.Show("Falta llenar datos");
                isOk = false;
            }

            if (isOk == true)
            {
                VaciarDatos();
                FormMain.listaCruceros.Add(auxCrucero);
                FormMain.viajes += nuevoViaje;
                this.listaCrucero = FormMain.listaCruceros;
                CrucerosDeLaFlota();
            }
        }
    }
}
