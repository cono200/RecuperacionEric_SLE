using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacionEric_SLE
{
    public  class Carro
    {
        public string _marca;
        public int  _modelo;
        public int _anioLanzamiento;

        


        public Carro(string marca, int modelo, int anioLanzamiento)
        {
            _marca= marca;
            _modelo= modelo;
            _anioLanzamiento = anioLanzamiento;
        }



    }
}
