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
    public partial class FormVenderViaje : Form
    {
        private List<Cruceros> listaCrucero = new List<Cruceros>();
        private ListadoViajes listaDeViajes = new ListadoViajes();
        private Pasajeros nuevoPasajero = new Pasajeros();

        private Viajes nuevoViaje = new Viajes();
        private ListadoViajes auxDestino = new ListadoViajes();

        public static FormVenderViaje formVenderViaje = new FormVenderViaje();


        private const double Iva = 0.21;

        public FormVenderViaje()
        {
            InitializeComponent();
        }

        private void FormVenderViaje_Load(object sender, EventArgs e)
        {
            listaCrucero = FormMain.listaCruceros;
            listaDeViajes = FormMain.viajes;

            CrucerosDeLaFlota();
            SetterDatosEstaticos();
            SetearDestinos();
        }

        private void DataGridCruceros(Cruceros cruceroAux, Viajes vAux)
        {
            Viajes capacidadCrucero = new Viajes();
            capacidadCrucero.Crucero = cruceroAux;


            DataGridViewRow filaUno = new DataGridViewRow();
            filaUno.CreateCells(dgv_Cruceros);
            filaUno.Cells[0].Value = cruceroAux.Nombre;
            filaUno.Cells[1].Value = cruceroAux.Matricula;
            filaUno.Cells[2].Value = vAux.Destino.DestinoSeleccionado;
            filaUno.Cells[3].Value = cruceroAux.Camarotes;
            filaUno.Cells[4].Value = $"{cruceroAux.Bodega}Kg";
            filaUno.Cells[5].Value = cruceroAux.SalonesDelCrucero.Comedores;
            filaUno.Cells[6].Value = cruceroAux.SalonesDelCrucero.Casinos;
            filaUno.Cells[7].Value = cruceroAux.SalonesDelCrucero.Piscinas;
            filaUno.Cells[8].Value = cruceroAux.SalonesDelCrucero.SalonesBaile;
            filaUno.Cells[9].Value = cruceroAux.Pasajeros.Count;

            dgv_Cruceros.Rows.Add(filaUno);
        }

        private void CrucerosDeLaFlota()
        {
            Viajes viajeVacio = new Viajes();
            viajeVacio.FechaPartida = new DateTime(2023, 01, 01);

            dgv_Cruceros.Rows.Clear();

            
            for (int i = 0; i < listaDeViajes.Count; i++)
            {
                DataGridCruceros(listaDeViajes.Lista[i].Crucero, listaDeViajes.Lista[i]);
            }
        }

        private void cmb_Destinos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Crucero.Enabled == false)
            {
                cmb_Crucero.Enabled = true;
                btn_Crucero.Enabled = false;
                SetearCruceros();
            }
            SetearCruceros();
        }

        private void SetterDatosEstaticos()
        {
            cmb_Sexo.Items.Add(Sexo.Otro.ToString());
            cmb_Sexo.Items.Add(Sexo.Masculino.ToString());
            cmb_Sexo.Items.Add(Sexo.Femenino.ToString());

            cmb_Clase.Items.Add("Turista");
            cmb_Clase.Items.Add("Premium");

            cmb_Nacionalidad.Items.Add("Argentina");
            cmb_Nacionalidad.Items.Add("Uruguay");
            cmb_Nacionalidad.Items.Add("Chile");
            cmb_Nacionalidad.Items.Add("Bolivia");
            cmb_Nacionalidad.Items.Add("Brasil");
            cmb_Nacionalidad.Items.Add("Otra");
        }

        private void SetearDestinos()
        {
            cmb_Destinos.Items.Clear();
            for (int i = 0; i < listaDeViajes.Count; i++)
            {
                if (!cmb_Destinos.Items.Contains(listaDeViajes.Lista[i].Destino.DestinoSeleccionado))
                {
                    cmb_Destinos.Items.Add(listaDeViajes.Lista[i].Destino.DestinoSeleccionado);
                }
            }
        }

        private void SetearCruceros()
        {
            Destino destino = new Destino();
            for (int i = 0; i < listaDeViajes.Count; i++)
            {
                if (cmb_Destinos.SelectedItem.ToString() == listaDeViajes.Lista[i].Destino.DestinoSeleccionado)
                {
                    destino = listaDeViajes.Lista[i].Destino;
                }
            }
            nuevoViaje = ListadoViajes.ViajesSegunDestino(destino.EnumDestino, listaDeViajes);


            auxDestino = ListadoViajes.FiltrarPorDestino(destino.EnumDestino, listaDeViajes);

            cmb_Crucero.Items.Clear();
            for (int i = 0; i < auxDestino.Count; i++)
            {
                cmb_Crucero.Items.Add(auxDestino.Lista[i].Crucero.Matricula);
            }
        }

        private void cmb_Crucero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btn_Crucero.Enabled == false)
            {
                btn_Crucero.Enabled = true;
                MostrarCrucero();
            }
            MostrarCrucero();
        }

        private void MostrarCrucero()
        {
            for (int i = 0; i < auxDestino.Count; i++)
            {
                if (cmb_Crucero.SelectedItem.ToString() == auxDestino.Lista[i].Crucero.Matricula)
                {
                    nuevoViaje = auxDestino.Lista[i];
                    break;
                }
            }

            txt_crucero.Text = nuevoViaje.Crucero.Nombre;
            txt_Matricula.Text = nuevoViaje.Crucero.Matricula;
            txt_Restaurantes.Text = nuevoViaje.Crucero.SalonesDelCrucero.Comedores.ToString();
            txt_Casinos.Text = nuevoViaje.Crucero.SalonesDelCrucero.Casinos.ToString();
            txt_Piscinas.Text = nuevoViaje.Crucero.SalonesDelCrucero.Piscinas.ToString();
            txt_Salones.Text = nuevoViaje.Crucero.SalonesDelCrucero.SalonesBaile.ToString();
            txt_FechaPartida.Text = nuevoViaje.FechaPartida.ToString("dd/MM/yyyy");
            txt_HsVIaje.Text = $"{nuevoViaje.HorasDeViaje.ToString()}hs";
        }

        private void btn_Crucero_Click(object sender, EventArgs e)
        {
            gpb_Destino.Enabled = false;
            gpb_Crucero.Enabled = false;
            gpb_Pasajero.Enabled = true;
        }

        private void btn_Pasajero_Click(object sender, EventArgs e)
        {
            if (ValidarPasajero() != null)
            {
                if (cmb_Clase.SelectedItem.ToString() == "Premium")
                {
                    nuevoPasajero = ValidarPasajero();
                    SettPrecioFinal(nuevoViaje.PrecioPremium);
                    gpb_Pasajero.Enabled = false;
                    btn_Venta.Enabled = true;
                }
                else
                {
                    nuevoPasajero = ValidarPasajero();
                    SettPrecioFinal(nuevoViaje.PrecioTurista);
                    gpb_Pasajero.Enabled = false;
                    btn_Venta.Enabled = true;
                    //btn_Cancelar.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("LLena los datos CRACK");
            }
        }

        private void SettPrecioFinal(double precio)
        {
            double PrecioConIva = 0;

            PrecioConIva = precio * Iva;
            PrecioConIva += precio;
            txt_PrecioIVA.Text = $"{PrecioConIva.ToString()}";
        }

        private Pasajeros ValidarPasajero()
        {
            Pasajeros auxPasajero = new Pasajeros();
            Pasaporte pasaporte = new Pasaporte();
            Equipajes equipaje = new Equipajes();

            auxPasajero.Pasaporte = pasaporte;
            auxPasajero.Equipaje = equipaje;

            /*
            string auxNacionalidad = "";

            string auxNombre = txt_Nombre.Text;
            string auxApellido = txt_Apellido.Text;
            string auxNumPasaporte = txt_Pasaporte.Text;

            try
            {
                auxNacionalidad = cmb_Nacionalidad.SelectedItem.ToString();
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Elegi nacio");
            }
            
            string auxSexo = cmb_Sexo.SelectedItem.ToString();
            int auxDNI = Convert.ToInt32(txt_DNI.Text);
            int auxEdad = Convert.ToInt32(txt_Edad);
            int auxCantValijas = Convert.ToInt32(cmb_Valijas.SelectedItem);
            int auxKg = Convert.ToInt32(txt_Equipaje.Text);
            bool auxBolsoMano = checkBox1.Checked;
            */
            if ((txt_Nombre.Text != "" && txt_Apellido.Text != "" && txt_DNI.Text != "" && txt_Edad.Text != "" && txt_Pasaporte.Text != "" && txt_Equipaje.Text != "") &&
                (cmb_Nacionalidad.SelectedItem != null && cmb_Sexo.SelectedItem != null && cmb_Clase.SelectedItem != null && cmb_Valijas != null))
            {
                
                string auxNombre = txt_Nombre.Text;
                string auxApellido = txt_Apellido.Text;
                string auxNumPasaporte = txt_Pasaporte.Text;
                string auxNacionalidad = cmb_Nacionalidad.SelectedItem.ToString();
                string auxSexo = cmb_Sexo.SelectedItem.ToString();
                int auxDNI = Convert.ToInt32(txt_DNI.Text);
                int auxEdad = Convert.ToInt32(txt_Edad.Text);
                int auxCantValijas = Convert.ToInt32(cmb_Valijas.SelectedItem);
                double auxKg = Convert.ToDouble(txt_Equipaje.Text);
                bool auxBolsoMano = checkBox1.Checked;

                auxPasajero.Nombre = auxNombre;
                auxPasajero.Apellido = auxApellido;
                auxPasajero.DNI = auxDNI;
                auxPasajero.Pasaporte.NumeroPasaporte = auxNumPasaporte;
                auxPasajero.Edad = auxEdad;
                auxPasajero.Pasaporte.Nacionalidad = auxNacionalidad;
                auxPasajero.Pasaporte.Sexo = auxSexo;
                auxPasajero.Equipaje.CountValijas = auxCantValijas;
                auxPasajero.Equipaje.BolsoMano = auxBolsoMano;

                if ((auxPasajero.Equipaje.CountValijas > 0 && auxPasajero.Equipaje.CountValijas < 2) && (auxKg > 0 && auxKg < 26))
                {
                    auxPasajero.Equipaje.KgValija = auxKg;
                }
                else
                {
                    if ((auxPasajero.Equipaje.CountValijas > 1) && (auxKg > 25 && auxKg < 51))
                    {
                        auxPasajero.Equipaje.KgValija = auxKg;
                    }
                    else
                    {
                        if ((auxPasajero.Equipaje.CountValijas == 0) && (auxKg == 0))
                        {
                            auxPasajero.Equipaje.KgValija = auxKg;
                        }
                    }
                }
            }
            else
            {
                auxPasajero = null;
            }

            return auxPasajero;
        }

        private void cmb_Clase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Clase.SelectedItem.ToString() == "Premium")
            {
                nuevoPasajero = InicializarPasajeroPremium();
            }
            else
            {
                nuevoPasajero = InicializarPasajeroTurista();
            }
        }

        private Pasajeros InicializarPasajeroPremium()
        {
            Pasajeros auxPsjPremium = new Pasajeros();
            auxPsjPremium.EsPremium = true;

            cmb_Valijas.Items.Clear();
            cmb_Valijas.Items.Add(0);
            cmb_Valijas.Items.Add(1);
            cmb_Valijas.Items.Add(2);

            txt_PrecioB.Text = $"{nuevoViaje.PrecioPremium.ToString()}";
            return auxPsjPremium;
        }

        private Pasajeros InicializarPasajeroTurista()
        {
            Pasajeros auxPsjTurista = new Pasajeros();
            cmb_Valijas.Items.Clear();
            cmb_Valijas.Items.Add(0);
            cmb_Valijas.Items.Add(1);

            txt_PrecioB.Text = $"{nuevoViaje.PrecioTurista.ToString()}";
            return auxPsjTurista;
        }

        private void btn_Venta_Click(object sender, EventArgs e)
        {
            if (this.cmb_Clase.SelectedItem.ToString() == "Premium")
            {
                if (this.nuevoViaje.ConfirmarVenta(this.nuevoPasajero) && ListadoViajes.AgregarPasajeroACrucero(this.nuevoViaje, FormMain.viajes, this.nuevoPasajero))
                {
                    MessageBox.Show("Venta Realizada");
                    FormMain.viajes += this.nuevoViaje;
                    Cruceros.ActualizarCrucero(this.nuevoViaje.Crucero, FormMain.listaCruceros);
                    CrucerosDeLaFlota();
                    LimpiarGroupBox(gpb_Crucero);
                    LimpiarGroupBox(gpb_Destino);
                    LimpiarGroupBox(gpb_Factura);
                    LimpiarGroupBox(gpb_Pasajero);
                    btn_Venta.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error, Venta rechazada");
                }
            }
            else
            {
                if (this.nuevoViaje.ConfirmarVenta(this.nuevoPasajero) && ListadoViajes.AgregarPasajeroACrucero(this.nuevoViaje, FormMain.viajes, this.nuevoPasajero))
                {
                    MessageBox.Show("Venta Realizada");
                    FormMain.viajes += this.nuevoViaje;
                    Cruceros.ActualizarCrucero(this.nuevoViaje.Crucero, FormMain.listaCruceros);
                    CrucerosDeLaFlota();
                    LimpiarGroupBox(gpb_Crucero);
                    LimpiarGroupBox(gpb_Destino);
                    LimpiarGroupBox(gpb_Factura);
                    LimpiarGroupBox(gpb_Pasajero);
                    btn_Venta.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error, no hay camarote disponible");
                    CrucerosDeLaFlota();
                    LimpiarGroupBox(gpb_Crucero);
                    LimpiarGroupBox(gpb_Destino);
                    LimpiarGroupBox(gpb_Factura);
                    LimpiarGroupBox(gpb_Pasajero);
                    btn_Venta.Enabled = false;
                }
            }
        }

        private void LimpiarGroupBox(GroupBox gpb)
        {
            foreach (var txt in gpb.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                else if (txt is ComboBox)
                {
                    ((ComboBox)txt).SelectedItem = "";
                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar la Venta?", "Cancelar Venta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FormMain.formVenderViaje.Close();
                /*
                gpb_Destino.Enabled = true;
                gpb_Factura.Enabled = false;
                gpb_Pasajero.Enabled = false;
                btn_Venta.Enabled = false;
                LimpiarGroupBox(gpb_Crucero);
                LimpiarGroupBox(gpb_Destino);
                LimpiarGroupBox(gpb_Factura);
                LimpiarGroupBox(gpb_Pasajero);
                */
            }
        }
    }
}
