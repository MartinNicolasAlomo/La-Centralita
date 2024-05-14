using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspacioCentralita
{
    public enum ETipoLlamada { Local, Provincial, Total }

    public abstract class Llamada
    {
        protected float duracion;
        protected string numeroOrigen;
        protected string numeroDestino;


        public Llamada(float duracion, string numeroOrigen, string numeroDestino)
        {
            this.duracion = duracion;
            this.numeroOrigen = numeroOrigen;
            this.numeroDestino = numeroDestino;
        }


        public float Duracion
        {
            get { return duracion; }
        }

        public string NumeroOrigen
        {
            get { return numeroOrigen; }
        }

        public string NumeroDestino
        {
            get { return numeroDestino; }
        }

        public abstract float CostoLlamada
        {
            get;
        }


        protected virtual string Mostrar()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine($"Duración: {duracion} minutos")
                .AppendLine($"Número de Origen: {numeroOrigen}")
                .AppendLine($"Número de Destino: {numeroDestino}")
                ;
            return text.ToString();
        }

        public static int OrdernarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return (int)(llamada1.duracion - llamada2.duracion);
        }


        //   SOBRECARGA DE OPERADOR  ==
        //  El operador == comparará dos llamadas y retornará true:
        //  si las llamadas son del mismo tipo (utilizar el método Equals, sobrescrito en las clases derivadas)
        //  y los números de destino y origen son iguales en ambas llamadas.

        public static bool operator ==(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1 is not null && llamada2 is not null)
            {
                return llamada1.Equals(llamada2) &&
                       llamada1.numeroOrigen == llamada2.numeroOrigen &&
                       llamada1.numeroDestino == llamada2.numeroDestino;
            }
            return false;
        }

        public static bool operator !=(Llamada llamada1, Llamada llamada2)
        {
            return !(llamada1 == llamada2);
        }




    }
}
