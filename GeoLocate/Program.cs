using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace GeoLocate
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("1. Busque una direccion");
                Console.WriteLine("2. Salir");
                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    Console.WriteLine("Digite la direccion de la siguiente forma Pais, Ciudad, Direccion");
                    string direccion = Console.ReadLine();

                    var address = @"https://maps.googleapis.com/maps/api/geocode/json?&address=" + direccion;
                    var result = new System.Net.WebClient().DownloadString(address);
                    GoogleGeoCodeResponse respuesta = JsonConvert.DeserializeObject<GoogleGeoCodeResponse>(result);

                    if (respuesta.status == "OK")
                    {
                        Console.Clear();
                        Console.WriteLine("**********************************************************************");
                        Console.WriteLine("*    Encontramos la ubicacion geografica de tu direccion:");
                        Console.WriteLine("*    Latitud: " + respuesta.results[0].geometry.location.lat);
                        Console.WriteLine("*    Longitud: " + respuesta.results[0].geometry.location.lng);
                        Console.WriteLine("*    Direccion: " + respuesta.results[0].formatted_address);
                        Console.WriteLine("**********************************************************************");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("No fue posible ubicar la dirección");
                    }
                }
                else if (opcion == "2")
                {
                    break;
                }
                

            }
        }

        public class GoogleGeoCodeResponse
        {

            public string status { get; set; }
            public results[] results { get; set; }

        }
        public class results
        {
            public string formatted_address { get; set; }
            public geometry geometry { get; set; }
            public string[] types { get; set; }
            public address_component[] address_components { get; set; }
        }
        public class geometry
        {
            public string location_type { get; set; }
            public location location { get; set; }
        }
        public class location
        {
            public string lat { get; set; }
            public string lng { get; set; }
        }
        public class address_component
        {
            public string long_name { get; set; }
            public string short_name { get; set; }
            public string[] types { get; set; }
        }
    }

}