using MongoDB.Driver.GeoJsonObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMongo.Data.Collections
{
    public class Infectado
    {
        public  DateTime DataNascimento{ get; set; }
        public string Sexo { get; set; }
        public GeoJson2DGeographicCoordinates Localizacao { get; set; }

        public Infectado(DateTime dataNascimento, string sexo, double latitude, double longitude)
        {
            DataNascimento = dataNascimento;
            Sexo = sexo;
            Localizacao = new GeoJson2DGeographicCoordinates( longitude, latitude);
        }
    }
}
