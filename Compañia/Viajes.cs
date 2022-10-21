using System;
using System.Text;

namespace Compañia
{
    public class Viajes
    {
        private static eCiudadesPartida ciudadPartida;
        private Destino destino;
        private DateTime fechaInicio;
        private Cruceros crucero;
        private int camarotesTurista;
        private int camarotesPremium;
        private double precioTurista;
        private double precioPremium;
        private double duracion;

        static Viajes()
        {
            Viajes.ciudadPartida = eCiudadesPartida.CABA;
        }
        public Viajes()
        {
            this.fechaInicio = new DateTime();
            this.crucero = null;
            this.camarotesTurista = 0;
            this.camarotesPremium = 0;
            this.precioTurista = 0;
            this.precioPremium = 0;
            this.destino = null;
        }

        public eCiudadesPartida CiudadesPartida
        {
            set
            {
                Viajes.ciudadPartida = value;
            }
            get
            {
                return Viajes.ciudadPartida;
            }
        }

        public Destino Destino
        {
            set
            {
                this.destino = value;
                CalcularHorasDeViaje();
            }
            get
            {
                return this.destino;
            }
        }

        public Cruceros Crucero
        {
            set
            {
                this.crucero = value;
                CalcularCamarotes();
            }
            get
            {
                return this.crucero;
            }
        }

        public DateTime FechaPartida
        {
            set
            {
                this.fechaInicio = value;
            }
            get
            {
                return this.fechaInicio;
            }
        }

        public int CamarotesTurista
        {
            get
            {
                return this.camarotesTurista;
            }
            set
            {
                this.camarotesTurista = value;
            }
        }

        public int CamarotesPremium
        {
            get
            {
                return this.camarotesPremium;
            }
            set
            {
                this.camarotesPremium = value;
            }
        }

        public double PrecioTurista
        {
            get
            {
                return this.precioTurista;
            }
        }

        public double PrecioPremium
        {
            get
            {
                return this.precioPremium;
            }
        }

        public double HorasDeViaje
        {
            get
            {
                return this.duracion;
            }
        }


        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            string cadena;
            sb.AppendLine("|DATOS DEL VIAJE-------------------------------|");
            cadena = this.CiudadesPartida.ToString();
            sb.AppendLine($"|Ciudad de partida {cadena.Replace("_", " ")}");
            sb.AppendLine($"|Ciudad de destino {this.destino.DestinoSeleccionado}");
            sb.AppendLine($"|Fecha de inicio {this.fechaInicio.ToString("dd/MM/yyyy")}");
            sb.AppendLine($"|Crucero {this.Crucero.Nombre} {this.Crucero.Matricula}");
            sb.AppendLine($"|Camarotes Turista {this.camarotesTurista}");
            sb.AppendLine($"|Camarotes Premium {this.camarotesPremium}");
            sb.AppendLine($"|Precio pasaje Turista ${this.precioTurista}");
            sb.AppendLine($"|Precio pasaje Premium ${this.precioPremium}");
            sb.AppendLine($"|Horas del viaje {this.duracion}");
            sb.AppendLine("|----------------------------------------------|");

            return sb.ToString();
        }

        private void CalcularCamarotes()
        {
            double camarotes = (int)this.crucero;
            double camarotesPremium;
            double camarotesTurista;
            camarotesPremium = camarotes * 0.35;
            camarotesTurista = camarotes - camarotesPremium;

            this.camarotesPremium = (int)camarotesPremium;
            this.camarotesTurista = (int)camarotesTurista;
        }

        private void CalcularHorasDeViaje()
        {
            Random horas = new Random();
            if (this.destino.EsRegional)
            {
                this.duracion = horas.Next(72, 360);
                CalcularPrecios(this.duracion);
            }
            else
            {
                this.duracion = horas.Next(480, 720);
                CalcularPrecios(this.duracion);
            }
        }

        private void CalcularPrecios(double horas)
        {
            double aumento;
            if (horas < 361)
            {
                this.precioTurista = 54 * horas;
                aumento = this.precioTurista * 0.20;
                this.precioPremium = this.precioTurista + aumento;
            }
            else
            {
                this.precioTurista = 120 * horas;
                aumento = this.precioTurista * 0.20;
                this.precioPremium = this.precioTurista + aumento;
            }
        }

        public DateTime IngresarFechaPartida
        {
            set
            {
                this.fechaInicio = value;
            }
        }

        public static bool operator ==(Viajes v1, Viajes v2)
        {
            bool isOk = false;
            if (!(v1 is null || v2 is null))
            {
                isOk = (v1.crucero == v2.crucero) && (v1.fechaInicio == v2.fechaInicio);
            }
            return isOk;
        }

        public static bool operator !=(Viajes v1, Viajes v2)
        {
            return !(v1 == v2);
        }

        public override bool Equals(object obj)
        {
            bool equals = false;
            if (obj is Viajes)
            {
                equals = this == ((Viajes)obj);
            }

            return equals;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public bool ViajeDisponible(Viajes v)
        {
            bool disponible = false;
            DateTime dtNow = DateTime.Now;
            DateTime dtV = v.fechaInicio;

            disponible = (v.camarotesPremium > 0 || v.camarotesTurista > 0) && (dtV > dtNow);

            return disponible;
        }
    }
}
