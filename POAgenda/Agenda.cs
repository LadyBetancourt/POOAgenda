using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POAgenda
{
    internal class Agenda
    {
        private Contacto[] _contactos;
        private int _tope;

        public Agenda()
        {
            _contactos = new Contacto[50];
            _tope = 0;
        }
        
        public void Agregar(Contacto contacto)
        {
            _contactos[_tope] = contacto;
            _tope++;
        }
        
        public Contacto[] ObtenerContactos()
        {
            return _contactos;  
        }
    }
}
