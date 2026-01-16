using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SnakeForms
{
    public class Punteggio
    {
        public string Nome { get; set; }
        public int Punti { get; set; }
        public DateTime Data { get; set; }
        public string Difficolta { get; set; }

        public override string ToString()
        {
            return $"{Nome} - {Punti} punti - {Difficolta} - {Data:g}";
        }
    }
}
