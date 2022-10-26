using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compañia
{
    public class ListadoViajes
    {
        private List<Viajes> listaViajes;

        public ListadoViajes()
        {
            this.listaViajes = new List<Viajes>();
        }

        #region getters

        public List<Viajes> Lista
        {
            get
            {
                return this.listaViajes;
            }
            set
            {
                this.listaViajes = value;
            }
        }

        public int Count
        {
            get
            {
                return this.listaViajes.Count;
            }
        }

        #endregion

        public static bool operator ==(ListadoViajes lista1, ListadoViajes lista2)
        {
            bool isOk = false;
            if (!(lista1 is null || lista2 is null))
            {
                for (int i = 0; i < lista1.Count; i++)
                {
                    if (lista1.listaViajes[i] != lista2.listaViajes[i])
                    {
                        break;
                    }
                }

                isOk = true;
            }
            return isOk;
        }

        public static bool operator !=(ListadoViajes lista1, ListadoViajes lista2)
        {
            return !(lista1 == lista2);
        }
        public static bool operator ==(ListadoViajes lista, Viajes viaje)
        {
            bool inList = false;

            if (!(lista is null || viaje is null))
            {
                inList = lista.listaViajes.Contains(viaje);
            }
            return inList;
        }

        public static bool operator !=(ListadoViajes lista, Viajes viaje)
        {
            return !(lista == viaje);
        }
        public static ListadoViajes operator +(ListadoViajes lista, Viajes viaje)
        {
            if (lista != viaje)
            {
                lista.listaViajes.Add(viaje);
            }
            else
            {
                if (lista == viaje)
                {
                    int indexV = lista.IndexViajes(viaje);
                    lista.listaViajes[indexV].CamarotesPremium = viaje.CamarotesPremium;
                    lista.listaViajes[indexV].CamarotesTurista = viaje.CamarotesTurista;
                }
            }

            return lista;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            bool isOk = false;
            if (obj is ListadoViajes)
            {
                isOk = this == ((ListadoViajes)obj);
            }
            return base.Equals(obj);
        }

        public ListadoViajes FiltrarPorViajesDisponibles(ListadoViajes lv)
        {
            ListadoViajes aux = new ListadoViajes();
            foreach (Viajes item in lv.listaViajes)
            {
                if (item.ViajeDisponible(item))
                {
                    aux += item;
                }
            }
            return aux;
        }

        public string MostrarListaViajes()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cntidad de Viajess {this.Count}");
            foreach (Viajes item in this.listaViajes)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        private int IndexViajes(Viajes v)
        {
            int index = 0;
            foreach (Viajes item in this.listaViajes)
            {
                if (item == v)
                {
                    break;
                }

                index++;
            }

            return index;
        }

        public static Viajes ViajesSegunDestino(eDestinos d, ListadoViajes lv)
        {
            Viajes Viajes = new Viajes();
            foreach (Viajes item in lv.listaViajes)
            {
                if (item.Destino == d)
                {
                    Viajes = item;
                    break;
                }
            }
            return Viajes;
        }

        public static ListadoViajes FiltrarPorDestino(eDestinos d, ListadoViajes lv)
        {
            ListadoViajes auxLista = new ListadoViajes();
            for (int i = 0; i < lv.Count; i++)
            {
                if (lv.listaViajes[i].Destino.EnumDestino == d)
                {
                    auxLista += lv.listaViajes[i];
                }
            }
            return auxLista;
        }

        public static bool AgregarPasajeroACrucero(Viajes v, ListadoViajes lv, Pasajeros p)
        {
            bool agregado = false;
            int index;
            if (lv == v)
            {
                index = lv.IndexViajes(v);
                lv.listaViajes[index].Crucero.Pasajeros.Add(p);

                agregado = lv.listaViajes[index].Crucero.Pasajeros.Contains(p);
            }
            return agregado;
        }

        public static double TotalFacturado(ListadoViajes lsv)
        {
            double facturado = 0;
            facturado = FacturadoAInternacional(lsv) + FacturadoRegional(lsv);
            return facturado;

        }

        public static double FacturadoRegional(ListadoViajes lsv)
        {
            double facturado = 0;
            for (int i = 0; i < lsv.Count; i++)
            {
                if (lsv.listaViajes[i].Destino.EsRegional)
                {
                    for (int j = 0; j < lsv.listaViajes[i].Crucero.Pasajeros.Count; j++)
                    {
                        if (lsv.listaViajes[i].Crucero.Pasajeros[j] is Premium)
                        {
                            facturado += lsv.listaViajes[i].PrecioPremium;
                        }
                        else
                        {
                            facturado += lsv.listaViajes[i].PrecioTurista;
                        }
                    }

                }
            }

            return facturado;
        }

        public static double FacturadoAInternacional(ListadoViajes lsv)
        {
            double facturado = 0;
            for (int i = 0; i < lsv.Count; i++)
            {
                if (!lsv.listaViajes[i].Destino.EsRegional)
                {
                    for (int j = 0; j < lsv.listaViajes[i].Crucero.Pasajeros.Count; j++)
                    {
                        if (lsv.listaViajes[i].Crucero.Pasajeros[j] is Premium)
                        {
                            facturado += lsv.listaViajes[i].PrecioPremium;
                        }
                        else
                        {
                            facturado += lsv.listaViajes[i].PrecioTurista;
                        }
                    }

                }
            }
            return facturado;

        }

        public static eDestinos DestinoMasElegido(ListadoViajes lsv)
        {
            eDestinos destinoMasElegido = new eDestinos();
            bool flag = true;
            int value;
            int max = 0;

            for (int i = 0; i < lsv.Count; i++)
            {
                value = 0;
                for (int j = 0; j < lsv.Count; j++)
                {
                    if (lsv.Lista[i].Crucero.Count >= lsv.Lista[j].Crucero.Count)
                    {
                        value = lsv.Lista[i].Crucero.Count;
                    }
                }

                if (flag || value > max)
                {
                    flag = false;
                    max = value;
                    destinoMasElegido = lsv.Lista[i].Destino.EnumDestino;

                }
            }

            return destinoMasElegido;
        }

        public static double FacturadoPorDestino(ListadoViajes lsv, eDestinos d)
        {
            double facturado = 0;
            for (int i = 0; i < lsv.Count; i++)
            {
                if (lsv.Lista[i].Destino.EnumDestino == d)
                {
                    for (int j = 0; j < lsv.listaViajes[i].Crucero.Pasajeros.Count; j++)
                    {
                        if (lsv.listaViajes[i].Crucero.Pasajeros[j] is Premium)
                        {
                            facturado += lsv.listaViajes[i].PrecioPremium;
                        }
                        else
                        {
                            facturado += lsv.listaViajes[i].PrecioTurista;
                        }
                    }

                }
            }

            return facturado;
        }

        public static double FacturaCrucero(ListadoViajes lsv, Cruceros c)
        {
            double facturado = 0;
            for (int i = 0; i < lsv.Count; i++)
            {
                if (lsv.Lista[i].Crucero == c)
                {
                    for (int j = 0; j < lsv.listaViajes[i].Crucero.Pasajeros.Count; j++)
                    {
                        if (lsv.listaViajes[i].Crucero.Pasajeros[j] is Premium)
                        {
                            facturado += lsv.listaViajes[i].PrecioPremium;
                        }
                        else
                        {
                            facturado += lsv.listaViajes[i].PrecioTurista;
                        }
                    }

                }
            }

            return facturado;
        }

        public static void ListaPorDestino(ListadoViajes lsv)
        {
            Viajes aux = new Viajes();
            for (int i = 0; i < lsv.Count - 1; i++)
            {
                for (int j = i; j < lsv.Count; j++)
                {
                    if (lsv.Lista[i].Crucero.Count < lsv.Lista[j].Crucero.Count)
                    {
                        aux = lsv.Lista[i];
                        lsv.Lista[i] = lsv.Lista[j];
                        lsv.Lista[j] = aux;

                    }
                }
            }
        }

        public static ListadoViajes ClonarLista(ListadoViajes ld)
        {
            ListadoViajes aux = new ListadoViajes();
            foreach (Viajes item in ld.Lista)
            {
                aux.Lista.Add(item);
            }

            return aux;
        }

        public static ListadoViajes ClonarLista(ListadoViajes ld1, ListadoViajes ld2)
        {
            ListadoViajes aux = new ListadoViajes();
            foreach (Viajes item in ld1.Lista)
            {
                aux.Lista.Add(item);
            }
            foreach (Viajes item in ld2.Lista)
            {
                aux.Lista.Add(item);
            }

            return aux;
        }

        public static List<Pasajeros> PasajeroFrecuente(ListadoViajes ld)
        {
            List<Pasajeros> pj = new List<Pasajeros>();
            int count;
            int max = 0;
            bool flag = true;
            int x = 0;
            foreach (Viajes item in ld.Lista)
            {
                for (int j = 0; j < item.Crucero.Count; j++)
                {
                    count = 0;
                    foreach (Viajes item2 in ld.Lista)
                    {
                        count += Cruceros.PasajeroMasFrecuente(item.Crucero.Pasajeros[j], item2.Crucero);
                    }

                    if (flag || count > max)
                    {
                        pj.Add(item.Crucero.Pasajeros[j]);
                        flag = false;
                        max = count;
                        pj[0] = item.Crucero.Pasajeros[j];
                    }
                    else
                    {
                        if (count == max)
                        {
                            pj.Add(item.Crucero.Pasajeros[j]);
                            x++;
                            pj[x] = item.Crucero.Pasajeros[j];
                        }
                    }
                }
            }
            return pj;
        }
    }
}
