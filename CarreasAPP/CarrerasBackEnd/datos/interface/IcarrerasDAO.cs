using CarrerasBackEnd.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerasBackEnd.datos
{
    public interface IcarrerasDAO
    {
        List<materias> getMaterias();

        List<titulo> getTitulos(int id);

        bool crearCarrera(carreras oCarrera);



    }
}
