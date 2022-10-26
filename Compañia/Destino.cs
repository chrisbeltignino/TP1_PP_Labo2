using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compañia
{
    public class Destino
    {
        private eDestinos destino;
        private bool regional;

        public Destino()
        {
            this.destino = eDestinos.NoSeleccionado;
            this.regional = true;
        }

        public Destino(eDestinos destino, bool esRegional)
        {
            this.destino = destino;
            this.regional = esRegional;
        }

        public static bool operator ==(Destino d1, Destino d2)
        {
            bool equals = false;
            if (!(d1 is null || d2 is null))
            {
                equals = (d1.destino == d2.destino) && (d1.regional == d2.regional);
            }

            return equals;
        }
        public static bool operator !=(Destino d1, Destino d2)
        {
            return !(d1 == d2);
        }

        public static bool operator ==(Destino d, eDestinos ds)
        {
            bool equals = false;
            if (!(d is null))
            {
                equals = d.EnumDestino == ds;
            }

            return equals;
        }
        public static bool operator !=(Destino d, eDestinos ds)
        {
            return !(d == ds);
        }

        public override bool Equals(object obj)
        {
            bool equals = false;
            if (obj is Destino)
            {
                equals = this == ((Destino)obj);
            }
            return equals;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public string DestinoSeleccionado
        {
            get
            {
                string destino = this.destino.ToString();
                return destino;
            }
        }

        public eDestinos EnumDestino
        {
            get
            {
                return this.destino;
            }
        }

        public bool EsRegional
        {
            get
            {
                return this.regional;
            }
        }
    }
}
