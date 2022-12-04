using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tl2_tp4_2022_agussarroyoo.Models
{
    public class Pedido
    {
        static private  int nro=0;
        private int ID;
        private string obs;
        private Cliente cliente ;
        private Estado estado;

        public Pedido (string obs, string nombCliente, Direccion direcCliente, long telefCliente, string referencias) {
            nro++;
            this.ID = nro;
            this.obs = obs;
            this.estado = Estado.Enviado;

            cliente = new Cliente(nombCliente, direcCliente,telefCliente, referencias);
        }

        public void listarInfo() {
            System.Console.WriteLine("nro: " + this.ID);
            System.Console.WriteLine("estado: " + this.estado);
        }

        
        public int id {
            get {
                return this.ID;
            }
        }
        public string Obs {
            get{
                return obs;
            }
        }
        public Cliente Cliente {
            get {
                return cliente;
            }
        }
        public Estado Estado {
            get {
                return estado;
            } set {
                estado = value;
            }
        }
    
    }
}