using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBD
{
    public class Articulo
    {
        private int id;
        private string nombre;
        private string des;
        private double precio;
        private int famid;

        public Articulo(int id, string nombre, string des, double precio, int famid)
        {
            this.id = id;
            this.nombre = nombre;
            this.des = des;
            this.precio = precio;
            this.famid = famid;
        }

        public int pId { get => id; set => id = value; }
        public string pNombre { get => nombre; set => nombre = value; }
        public string pDes { get => des; set => des = value; }
        public double pPrecio { get => precio; set => precio = value; }
        public int pFamid { get => famid; set => famid = value; }
    }
}
