using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;
using CAPA_ENTIDAD;

namespace CAPA_NEGOCIO
{
    public class N_REGISTRO
    {
        D_REGISTRO objDato = new D_REGISTRO();

        public List<E_REGISTRO> ListarRegistro(string buscar) 
        {
            return objDato.ListarRegistro(buscar);
        }

        public void AgregandoVisitas(E_REGISTRO REGISTRO_VISITAS)
        {
            objDato.AgregarVisitas(REGISTRO_VISITAS);
        }

        public void AgregandoUsuarios(E_REGISTRO REGISTRO_USUARIO) 
        {
            objDato.AgregarUsuarios(REGISTRO_USUARIO);
        }

        public void ModificandoVisitas(E_REGISTRO REGISTRO_VISITAS, int ID) 
        {
            objDato.ModificarVisitas(REGISTRO_VISITAS, ID);
        }
    }
}
