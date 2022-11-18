using CarrerasBackEnd.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerasBackEnd.facade
{
    public interface Idatos
    {
        public List<materias> GetMaterias();

        public List<titulo> GetTitulos();

        public bool PostCarrera(carreras oCarrera);
    }
}
