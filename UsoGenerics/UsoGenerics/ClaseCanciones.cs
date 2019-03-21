using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoGenerics
{
    public interface Icanciones
    {
        string Nombre { get; set; }
        string Album { get; set; }
        string Genero { get; set; }
    }

    public class Cancion : Icanciones
    {
        string _nombre, _album, _genero;

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }
        public string Album
        {
            get { return this._album; }
            set { this._album = value; }
        }
        public string Genero
        {
            get { return this._genero; }
            set { this._genero = value; }
        }


    }
}
