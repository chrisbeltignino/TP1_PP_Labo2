using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compañia
{
    public static class Hardcodeo
    {
        public static Viajes ViajeUnoHardcode()
        {
            Viajes viajeUno = new Viajes();
            Destino nuevoDestino = new Destino(eDestinos.Acapulco, false);

            viajeUno.Destino = nuevoDestino;
            viajeUno.Crucero = CruceroHardcode();
            viajeUno.FechaPartida = new DateTime(2022, 10, 10);

            return viajeUno;
        }

        public static List<Pasajeros> PasajerosHardcode()
        {
            List<Pasajeros> pasajerosListaUno = new List<Pasajeros>();

            Pasaporte pasaporteUno = new Pasaporte("ANJ234JK", "Argentina", Sexo.Masculino);
            Equipajes equipajeUno = new Equipajes(true, 50, 2);
            Pasajeros pasajeroUno = new Pasajeros("Martin", "Rodriguez", 45, 30373847, true, pasaporteUno, equipajeUno);

            Pasaporte pasaporteDos = new Pasaporte("JNK34244K2", "Uruguay", Sexo.Otro);
            Equipajes equipajeDos = new Equipajes(true, 20, 1);
            Pasajeros pasajeroDos = new Pasajeros("Alex", "Canigia", 27, 37457634, false, pasaporteDos, equipajeDos);

            Pasaporte pasaporteTres = new Pasaporte("GVJH334K3LL", "Otra", Sexo.Femenino);
            Equipajes equipajeTres = new Equipajes(false, 25, 1);
            Pasajeros pasajeroTres = new Pasajeros("Anya", "Serlova", 20, 41383849, false, pasaporteTres, equipajeTres);

            Pasaporte pasaporteCuatro = new Pasaporte("JK234JJN4", "Chile", Sexo.Masculino);
            Equipajes equipajeCuatro = new Equipajes(false, 50, 2);
            Pasajeros pasajeroCuatro = new Pasajeros("Gabi", "Rodriguez", 55, 19435829, true, pasaporteCuatro, equipajeCuatro);

            pasajerosListaUno.Add(pasajeroUno);
            pasajerosListaUno.Add(pasajeroDos);
            pasajerosListaUno.Add(pasajeroTres);
            pasajerosListaUno.Add(pasajeroCuatro);

            return pasajerosListaUno;
        }

        public static Cruceros CruceroHardcode()
        {
            Salones s1 = new Salones();
            Cruceros cruceroUno = new Cruceros("EV-1000", "EL VIAJERO", 500, 5000, s1);
            cruceroUno.Pasajeros = PasajerosHardcode();

            return cruceroUno;
        }

        public static ListadoViajes ListaDeViajesHardcode()
        {
            ListadoViajes newList = new ListadoViajes();

            List<Cruceros> flotaJ = new List<Cruceros>();
            flotaJ = ListaCrucerosHardcode();


            Viajes viajeUno = new Viajes();
            viajeUno.Crucero = flotaJ[0];
            viajeUno.Destino = new Destino(eDestinos.Taipei, false);
            viajeUno.FechaPartida = new DateTime(2022, 12, 01);
            viajeUno.CamarotesPremium = 200;
            viajeUno.CamarotesTurista = 150;
            viajeUno.CiudadesPartida = eCiudadesPartida.CABA;

            Viajes viajeDos = new Viajes();
            viajeDos.Crucero = flotaJ[1];
            viajeDos.Destino = new Destino(eDestinos.Miami, false);
            viajeDos.FechaPartida = new DateTime(2022, 10, 30);
            viajeDos.CamarotesPremium = 10;
            viajeDos.CamarotesTurista = 5;
            viajeDos.CiudadesPartida = eCiudadesPartida.Mar_del_Plata;

            Viajes viajeTres = new Viajes();
            viajeTres.Crucero = flotaJ[2];
            viajeTres.Destino = new Destino(eDestinos.Miami, false);
            viajeTres.FechaPartida = new DateTime(2022, 12, 28);
            viajeTres.CamarotesPremium = 1;
            viajeTres.CamarotesTurista = 0;
            viajeTres.CiudadesPartida = eCiudadesPartida.CABA;

            Viajes viajeCuatro = new Viajes();
            viajeCuatro.Crucero = flotaJ[3];
            viajeCuatro.Destino = new Destino(eDestinos.Rio_de_Janeiro, true);
            viajeCuatro.FechaPartida = new DateTime(2022, 10, 8);
            viajeCuatro.CamarotesPremium = 100;
            viajeCuatro.CamarotesTurista = 50;
            viajeCuatro.CiudadesPartida = eCiudadesPartida.Mar_del_Plata;

            Viajes viajeCinco = new Viajes();
            viajeCinco.Crucero = flotaJ[4];
            viajeCinco.Destino = new Destino(eDestinos.Isla_Galapagos, true);
            viajeCinco.FechaPartida = new DateTime(2022, 10, 30);
            viajeCinco.CamarotesPremium = 0;
            viajeCinco.CamarotesTurista = 0;
            viajeCinco.CiudadesPartida = eCiudadesPartida.CABA;

            newList += viajeUno;
            newList += viajeDos;
            newList += viajeTres;
            newList += viajeCuatro;
            newList += viajeCinco;

            return newList;
        }

        public static ListadoViajes ListaDeViajesAntiguosHardcode()
        {
            ListadoViajes newList = new ListadoViajes();

            List<Cruceros> flotaJ = new List<Cruceros>();
            flotaJ = ListaCrucerosHardcode();


            Viajes viajeUno = new Viajes();
            viajeUno.Crucero = flotaJ[0];
            viajeUno.Destino = new Destino(eDestinos.Miami, false);
            viajeUno.FechaPartida = new DateTime(2022, 01, 01);
            viajeUno.CamarotesPremium = 200;
            viajeUno.CamarotesTurista = 150;
            viajeUno.CiudadesPartida = eCiudadesPartida.CABA;

            Viajes viajeDos = new Viajes();
            viajeDos.Crucero = flotaJ[0];
            viajeDos.Destino = new Destino(eDestinos.Miami, false);
            viajeDos.FechaPartida = new DateTime(2022, 03, 30);
            viajeDos.CamarotesPremium = 10;
            viajeDos.CamarotesTurista = 5;
            viajeDos.CiudadesPartida = eCiudadesPartida.Mar_del_Plata;

            Viajes viajeTres = new Viajes();
            viajeTres.Crucero = flotaJ[2];
            viajeTres.Destino = new Destino(eDestinos.Miami, false);
            viajeTres.FechaPartida = new DateTime(2022, 05, 28);
            viajeTres.CamarotesPremium = 1;
            viajeTres.CamarotesTurista = 0;
            viajeTres.CiudadesPartida = eCiudadesPartida.CABA;

            Viajes viajeCuatro = new Viajes();
            viajeCuatro.Crucero = flotaJ[4];
            viajeCuatro.Destino = new Destino(eDestinos.Isla_Galapagos, true);
            viajeCuatro.FechaPartida = new DateTime(2022, 02, 8);
            viajeCuatro.CamarotesPremium = 100;
            viajeCuatro.CamarotesTurista = 50;
            viajeCuatro.CiudadesPartida = eCiudadesPartida.Mar_del_Plata;

            Viajes viajeCinco = new Viajes();
            viajeCinco.Crucero = flotaJ[4];
            viajeCinco.Destino = new Destino(eDestinos.Isla_Galapagos, true);
            viajeCinco.FechaPartida = new DateTime(2022, 07, 30);
            viajeCinco.CamarotesPremium = 0;
            viajeCinco.CamarotesTurista = 0;
            viajeCinco.CiudadesPartida = eCiudadesPartida.CABA;

            newList += viajeUno;
            newList += viajeDos;
            newList += viajeTres;
            newList += viajeCuatro;
            newList += viajeCinco;

            for (int i = 0; i < viajeCinco.Crucero.Count; i++)
            {
                viajeCinco.Crucero.Pasajeros.Remove(viajeCinco.Crucero.Pasajeros[i]);
            }

            return newList;
        }

        public static List<Cruceros> ListaCrucerosHardcode()
        {
            List<Cruceros> flotaJ = new List<Cruceros>();

            Salones s1 = new Salones(5, 10, 5, 10);
            Cruceros cruceroUno = new Cruceros("HW-0075", "HAWKMOON", 20000, 35000, s1);

            Salones s2 = new Salones(1, 3, 1, 4);
            Cruceros cruceroDos = new Cruceros("LG-0000", "THE LIGTH", 2000, 11000, s2);

            Salones s3 = new Salones(1, 2, 3, 5);
            Cruceros cruceroTres = new Cruceros("BS-0004", "BANSHE-04", 30, 120, s3);

            Salones s4 = new Salones(0, 2, 1, 3);
            Cruceros cruceroCuatro = new Cruceros("CZ-0001", "CAPITAN ZAVALA", 6000, 16000, s4);

            Salones s5 = new Salones(1, 2, 0, 3);
            Cruceros cruceroCinco = new Cruceros("CM-X000", "BIG J", 1200, 12000, s5);

            Salones s6 = new Salones(1, 1, 1, 2);
            Cruceros cruceroSeis = new Cruceros("IB-4505", "IRON BANNER", 150, 2000, s6);

            Salones s7 = new Salones(5, 15, 6, 15);
            Cruceros cruceroSiete = new Cruceros("DL-T007", "DELTA-007", 10000, 25000, s7);

            flotaJ.Add(cruceroUno);
            flotaJ.Add(cruceroDos);
            flotaJ.Add(cruceroTres);
            flotaJ.Add(cruceroCuatro);
            flotaJ.Add(cruceroCinco);
            flotaJ.Add(cruceroSeis);
            flotaJ.Add(cruceroSiete);

            cruceroCinco.Pasajeros = PasajerosHardcode();

            return flotaJ;
        }
    }
}