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

    public Movimiento(int numero, DateTime fecha, Cliente cliente)
    {
            this.fecha = fecha;
            this.numero = numero;
            this.cliente = cliente;//Agregacion ya que necesitamos un objeto instancia de la clase cliente para que el constructor lo tome y se pueda crear un objeto del tipo movimiento
    }

    public void SetFolio(Folio folio)
        {
            this.folio = folio;
        }
    }
}
