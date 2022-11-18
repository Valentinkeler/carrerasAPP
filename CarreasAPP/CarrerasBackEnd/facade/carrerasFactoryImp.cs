using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerasBackEnd.facade
{
    abstract class carrerasFactoryImp : abstractCarrerasFactory
    {
        public override Idatos getInstance()
        {
            return  new datosCarreras();
        }
    }
}
