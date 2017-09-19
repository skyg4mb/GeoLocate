using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeoLocate
{
    class Objetivo
    {
        string latitud;
        string longitud;
        string pais;
        string ciudad;
        string direccion;

        public Objetivo(string latitud, string longitud, string pais, string ciudad, string direccion)
        {
            Latitud = latitud;
            Longitud = longitud;
            Pais = pais;
            Ciudad = ciudad;
            Direccion = direccion;
        }
        public Objetivo()
        {

        }
        public string Latitud
        {
            get
            {
                return latitud;
            }

            set
            {
                latitud = value;
            }
        }
        public string Longitud
        {
            get
            {
                return longitud;
            }

            set
            {
                longitud = value;
            }
        }
        public string Pais
        {
            get
            {
                return pais;
            }

            set
            {
                pais = value;
            }
        }
        public string Ciudad
        {
            get
            {
                return ciudad;
            }

            set
            {
                ciudad = value;
            }
        }
        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

    }
}
