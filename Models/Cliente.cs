using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tl2_tp4_2022_agussarroyoo.Models
{
    public class Cliente
    {
        protected static int cont;
        protected int id;
        protected string nombre;
        protected Direccion direc;
        
        protected long telefono;


        string datosReferencia;

        public int ID {
            get {
                return this.id;
            }
        }
        public Cliente(string nombre, Direccion direc, long telefono, string datosReferencia) {
            this.datosReferencia = datosReferencia;
            this.nombre = nombre;
            this.direc = direc;
            this.telefono = telefono;
            cont++;
            this.id = cont;
        }

    }
}