using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*------------------------------Jorge Carrazco------------------------
 * -----------------------------13 marzo - 19 ------------------------
 * ---------------------------uso de lsitas genericas ----------------
 * -----------------------------cracion de una clase cancion y una 
 * --------------------------lista de objetos canciones de esa clase
 */ 
namespace UsoGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            char _in ;
            string _inN,_inG, _inA;
            List<Cancion> listcancion = new List<Cancion>();

            listcancion.Add(new Cancion()
            {
                Nombre = "Fire",
                Album = "LLP featuring Mike Diamondz",
                Genero = "Pop"
            });
            listcancion.Add(new Cancion()
            {
                Nombre = "Havana",
                Album = "Camila",
                Genero = "Pop"
            });
            listcancion.Add(new Cancion()
            {
                Nombre = "Obsesión",
                Album = "We Broke the Rules",
                Genero = "PopModerno"
            });
            listcancion.Add(new Cancion()
            {
                Nombre = "Soberbio",
                Album = " Formula",
                Genero = "Pop Latino"
            });
            listcancion.Add(new Cancion()
            {
                Nombre = "Getting Better",
                Album = "Sgt. Pepper's Lonely Hearts Club Band",
                Genero = "Rock"
            });
            listcancion.Add(new Cancion()
            {
                Nombre = "One Step Closer",
                Album = "Hybrid Theory",
                Genero = "Rock"
            });
            listcancion.Add(new Cancion()
            {
                Nombre = "Super Falling Star",
                Album = "Peng!",
                Genero = "Post Rock"
            });

            while (true)
            {
                Console.Clear();
                Console.WriteLine("---------Menu de Canciones---------");
                Console.WriteLine("1. Ver todas las canciones \n" +
                                    "2. Ingresar cancion\n" +
                                    "3. Buscar por Genero");
                _in = Convert.ToChar(Console.ReadLine());
                switch (_in){
                    case '1':
                        foreach (Cancion Ucacion in listcancion)
                        {
                            Console.WriteLine(Ucacion.Nombre + " " + 
                                Ucacion.Album + " " + Ucacion.Genero);
                        }
                        Console.ReadKey();
                        break;
                    case '2':
                       
                        Console.WriteLine("Tecle el Nombre de la cancion");
                        _inN = Console.ReadLine();
                        Console.WriteLine("Tecle el nombre del Album");
                        _inA = Console.ReadLine();
                        Console.WriteLine("Tecle el genero");
                        _inG = Console.ReadLine();
                        listcancion.Add(new Cancion()
                        {
                            Nombre = _inN,
                            Album = _inA,
                            Genero = _inG
                        });
                        Console.Clear();
                        break;
                    case '3':
                        Console.WriteLine("Tecle el genero");
                        _inG = Console.ReadLine();
                        var query1 = from cancion in listcancion where cancion.Genero == _inG select cancion;
                        foreach (Cancion value in query1)
                        {
                            Console.WriteLine(value.Nombre + " " + value.Album + " "+ value.Genero);
                        }
                        Console.ReadKey();
                        break;
                }
            }


            
        }
    }
}
