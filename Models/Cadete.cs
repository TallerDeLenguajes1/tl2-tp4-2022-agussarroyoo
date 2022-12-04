using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tl2_tp4_2022_agussarroyoo.Models
{
    public class Cadete
    {
        private static int cont;
        private int id;
        private string nombre;
        private string direc;
        
        private long telefono;

       
        private List<Pedido> pedidos = new List<Pedido>();
        private  int pedEnt ;

        public Cadete(){}
        public Cadete(string nombre, string direc, long telefono) {
            this.pedEnt = 0;
            this.nombre = nombre;
            this.direc = direc;
            this.telefono = telefono;
            cont++;
            this.id = cont;
        }


        public int ID {
            get {
                return this.id;
            } set{
                this.id =value;
            }
        }
        public string Nombre {
            get {
                return this.nombre;
            }set{
                this.nombre = value;
            }
        }
        public string Direccion {
            get{
                return this.direc;
            }set{
                this.direc = value;
            }
        }
        public long Telefono {
            get{
                return this.telefono;
            } set{
                this.telefono = value;
            }
        }
        public void listarInfo() {
            System.Console.WriteLine("nombre: " + this.nombre);
            System.Console.WriteLine("direccion: " + this.direc);
            System.Console.WriteLine("telefono: " + this.telefono);
        }
        public void agregarPedido(Pedido P) {
            pedidos.Add(P);
        }

        public int JornalACobra() {
            int monto = 0;
            foreach (Pedido P in pedidos)
            {
                if (P.Estado == Estado.Entregado)
                {
                    monto += 300;
                }
            }
            return monto;
        }

        public void altaPedido (int idPedido) {
            foreach (Pedido P in pedidos)
            {
                if (P.id == idPedido)
                {
                    P.Estado = Estado.Entregado;
                    this.pedEnt++;
                }
            }
        }

        public List<Pedido> Pedidos {
            get {
                return pedidos;
            }
        }

        public int PedEnt {
            get {
                return pedEnt;
            }
        }

    
    }
}