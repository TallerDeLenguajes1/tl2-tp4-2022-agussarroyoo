using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tl2_tp4_2022_agussarroyoo.Models
{
    public class Cadeteria
    {
        string nombre;
        long telefono;
        List<Cadete> cadetes = new List<Cadete>();

        public Cadeteria(string nombre, long telefono) {
            this.nombre = nombre;
            this.telefono = telefono;
        }

        public void agregarCadete (Cadete C) {
            cadetes.Add(C);
        }

        public List<Cadete> Cadetes {
            get {
                return cadetes;
            }
        }

        public void listarInfo() {
            System.Console.WriteLine("nombre: " + this.nombre);
            System.Console.WriteLine("telefono: " + this.telefono);
            foreach (var item in this.Cadetes)
            {
                System.Console.WriteLine("cadete [" + item.ID + "]");
                item.listarInfo();
                
            }
        }

        public void FinJornada() {
            System.Console.WriteLine("-------FIN DE LA JORNADA--------");
            
            foreach (Cadete item in this.cadetes)
            {
                System.Console.WriteLine("* Cadete [" + item.ID + "] *");
                System.Console.WriteLine("Monto ganado: $" + item.JornalACobra());
                System.Console.WriteLine("Cantidad de envíos: " + item.PedEnt );
                System.Console.WriteLine("------------------------------");
            }      
            
            System.Console.WriteLine("Cantidad total de envios: " + this.Cadetes.Select(x => x.PedEnt ).Sum() );
            System.Console.WriteLine("Monto total ganado: $" + this.Cadetes.Select(x => x.JornalACobra()).Sum());
        }
    }
}
