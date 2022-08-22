using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDAD
{
    public class E_REGISTRO
    {
        private int _Id_Visita;
        private string _Nombre;
        private string _Apellido;
        private string _Carrera;
        private string _CorreoElectronico;
        private string _Edificio;
        private string _HoraEntrada;
        private string _HoraSalida;
        private string _MotivoVisita;
        private string _AulaLugar;

        public int Id_Visita { get => _Id_Visita; set => _Id_Visita = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Carrera { get => _Carrera; set => _Carrera = value; }
        public string CorreoElectronico { get => _CorreoElectronico; set => _CorreoElectronico = value; }
        public string Edificio { get => _Edificio; set => _Edificio = value; }
        public string HoraEntrada { get => _HoraEntrada; set => _HoraEntrada = value; }
        public string HoraSalida { get => _HoraSalida; set => _HoraSalida = value; }
        public string MotivoVisita { get => _MotivoVisita; set => _MotivoVisita = value; }
        public string AulaLugar { get => _AulaLugar; set => _AulaLugar = value; }

        private string _NombreUS;
        private string _ApellidoUS;
        private string _FechaNacimiento;
        private string _TipoUsuario;

        public string NombreUS { get => _NombreUS; set => _NombreUS = value; }
        public string ApellidoUS { get => _ApellidoUS; set => _ApellidoUS = value; }
        public string FechaNacimiento { get => _FechaNacimiento; set => _FechaNacimiento = value; }
        public string TipoUsuario { get => _TipoUsuario; set => _TipoUsuario = value; }
        
    }
}
