using System;

namespace Compañia
{
    public class Viajes
    {
        private static CiudadesPartida ciudadPartida;
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
            Viajes.ciudadPartida = CiudadesPartida.CABA;
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

        public CiudadesPartida CiudadesPartida
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
    }
}
