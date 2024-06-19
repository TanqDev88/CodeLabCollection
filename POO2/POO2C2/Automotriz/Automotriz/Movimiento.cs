using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotriz
{
    public class Movimiento
    {
        private DateTime fecha;
        private int numero;
        public double total;
        private Cliente cliente;
        private Folio folio;
        private List<Item> items;

        public Movimiento(int numero, DateTime fecha, Cliente cliente)
        {
            this.fecha = fecha;
            this.numero = numero;
            this.cliente = cliente;//Agregacion ya que necesitamos un objeto instancia de la clase cliente para que el constructor lo tome y se pueda crear un objeto del tipo movimiento
            this.items = new List<Item>();
        }




        public void SetFolio(Folio folio)
        {
            this.folio = folio;
        }
        public void AgregarItem(Articulo articulo, double cantidad, double valorUnidad, double Iva, double descuento)
        {
            Item item = new Item(articulo, cantidad, valorUnidad, Iva, descuento);
            this.items.Add(item);
        }
        public List<Item> GetItems() {
            return this.items;
        }
        public void imprimir()
        {
            Console.WriteLine("MOVIMIENTO Nro " + this.ToString());
            Console.WriteLine("CLIENTE: ");
            Console.WriteLine(this.cliente.GetNombreCompleto());
            Console.WriteLine(" **Detalle** ");
            foreach (var item in this.GetItems())
            {
                Console.WriteLine(item.GetArticulo() + "- cantidad: " + item.GetCantidad());
            }
        }
    }

}
