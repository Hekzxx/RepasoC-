using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capa_Datos;
using Capa_Entidades;
using System.Data;

namespace Capa_Services
{
    public class sPaciente
    {
        dPaciente objetoPaciente = new dPaciente();

        public DataTable Listar_Pacientes()
        {
            return objetoPaciente.r_ListarPacientes();
        }

        public string MantenimientoPacientes(Paciente obj, string accion)
        {
            return objetoPaciente.r_MantenimientoPacientes(obj, accion);
        }

        public int ValidacionPaciente(Paciente obj)
        {
            return objetoPaciente.r_ValidacionPaciente(obj);
        }

        public int ValidacionAdmin(Paciente obj)
        {
            return objetoPaciente.r_ValidacionAdmin(obj);
        }
    }
}
