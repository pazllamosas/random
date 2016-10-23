using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Inicio.Login());
        }
    }

    public class FormProvider
    {

        public static Inicio.Menu MainMenu
        {
            get
            {
                if (_mainMenu == null)
                {
                    _mainMenu = new Inicio.Menu();
                }
                return _mainMenu;
            }
        }
        private static Inicio.Menu _mainMenu;


        public static Inicio.Login Login
        {
            get
            {
                if (_Login == null)
                {
                    _Login = new Inicio.Login();
                }
                return _Login;
            }
        }
        private static Inicio.Login _Login;

        public static Abm_Afiliado.VerAfiliado Afiliado
        {
            get
            {
                if (_Afiliado == null)
                {
                    _Afiliado = new Abm_Afiliado.VerAfiliado();
                }
                return _Afiliado;
            }
        }
        private static Abm_Afiliado.VerAfiliado _Afiliado;

        public static Abm_Afiliado.AgregarAfiliado Agafiliado
        {
            get
            {
                if (_Agafiliado == null)
                {
                    _Agafiliado = new Abm_Afiliado.AgregarAfiliado();
                }
                return _Agafiliado;
            }
        }
        private static Abm_Afiliado.AgregarAfiliado _Agafiliado;
        
        public static Abm_Afiliado.CambioPlanes CambioPlanAfiliado
        {
            get
            {
                if (_CambioPlanAfiliado == null)
                {
                    _CambioPlanAfiliado = new Abm_Afiliado.CambioPlanes();
                }
                return _CambioPlanAfiliado;
            }
        }
        private static Abm_Afiliado.CambioPlanes _CambioPlanAfiliado;

        public static AbmRol.AgregarRol AgRol
        {
            get
            {
                if (_AgRol == null)
                {
                    _AgRol = new AbmRol.AgregarRol ();
                }
                return _AgRol;
            }
        }
        private static AbmRol.AgregarRol _AgRol;

        public static AbmRol.verRol Rol
        {
            get
            {
                if (_Rol == null)
                {
                    _Rol = new AbmRol.verRol ();
                }
                return _Rol;
            }
        }
        private static AbmRol.verRol _Rol;

        public static Cancelar_Atencion.Cancelacion Cancelacion
        {
            get
            {
                if (_Cancelacion == null)
                {
                    _Cancelacion = new Cancelar_Atencion.Cancelacion();
                }
                return _Cancelacion;
            }
        }
        private static Cancelar_Atencion.Cancelacion _Cancelacion;

        public static Cancelar_Atencion.CancelacionAfiliado CancelacionAfiliado
        {
            get
            {
                if (_CancelacionAfiliado == null)
                {
                    _CancelacionAfiliado = new Cancelar_Atencion.CancelacionAfiliado();
                }
                return _CancelacionAfiliado;
            }
        }
        private static Cancelar_Atencion.CancelacionAfiliado _CancelacionAfiliado;

        public static Cancelar_Atencion.CancelacionMedico CancelacionMedico
        {
            get
            {
                if (_CancelacionMedico == null)
                {
                    _CancelacionMedico = new Cancelar_Atencion.CancelacionMedico();
                }
                return _CancelacionMedico;
            }
        }
        private static Cancelar_Atencion.CancelacionMedico _CancelacionMedico;

        public static Compra_Bono.CompraBono CompraBono
        {
            get
            {
                if (_CompraBono == null)
                {
                    _CompraBono = new Compra_Bono.CompraBono();
                }
                return _CompraBono;
            }
        }
        private static Compra_Bono.CompraBono _CompraBono;

        public static Listados.ListadoAfiliadoMasBonos ListadoAfiliadosBonos
        {
            get
            {
                if (_ListadoAfiliadosBonos == null)
                {
                    _ListadoAfiliadosBonos = new Listados.ListadoAfiliadoMasBonos();
                }
                return _ListadoAfiliadosBonos;
            }
        }
        private static Listados.ListadoAfiliadoMasBonos _ListadoAfiliadosBonos;

        public static Listados.ListadoEspCancelaciones ListadoEspCancelaciones
        {
            get
            {
                if (_ListadoEspCancelaciones == null)
                {
                    _ListadoEspCancelaciones = new Listados.ListadoEspCancelaciones();
                }
                return _ListadoEspCancelaciones;
            }
        }
        private static Listados.ListadoEspCancelaciones _ListadoEspCancelaciones;

        public static Listados.ListadoEspecBono ListadoEspBonos
        {
            get
            {
                if (_ListadoEspBonos == null)
                {
                    _ListadoEspBonos = new Listados.ListadoEspecBono();
                }
                return _ListadoEspBonos;
            }
        }
        private static Listados.ListadoEspecBono _ListadoEspBonos;

        public static Listados.ListadoEstadistico ListadoEstadistico
        {
            get
            {
                if (_ListadoEstadistico == null)
                {
                    _ListadoEstadistico = new Listados.ListadoEstadistico();
                }
                return _ListadoEstadistico;
            }
        }
        private static Listados.ListadoEstadistico _ListadoEstadistico;

        public static Listados.ListadoProfMenosHoras ListadoProfHoras
        {
            get
            {
                if (_ListadoProfHoras == null)
                {
                    _ListadoProfHoras = new Listados.ListadoProfMenosHoras ();
                }
                return _ListadoProfHoras;
            }
        }
        private static Listados.ListadoProfMenosHoras _ListadoProfHoras;

        public static Listados.ListadoProfporPlan ListadoProfPlan
        {
            get
            {
                if (_ListadoProfPlan == null)
                {
                    _ListadoProfPlan = new Listados.ListadoProfporPlan();
                }
                return _ListadoProfPlan;
            }
        }
        private static Listados.ListadoProfporPlan _ListadoProfPlan;

        public static Pedir_Turno.Turno Turno
        {
            get
            {
                if (_Turno == null)
                {
                    _Turno = new Pedir_Turno.Turno ();
                }
                return _Turno;
            }
        }
        private static Pedir_Turno.Turno _Turno;

        public static Registro_Llegada.RegistroLlegada RegistroLlegada
        {
            get
            {
                if (_RegistroLlegada == null)
                {
                    _RegistroLlegada = new Registro_Llegada.RegistroLlegada();
                }
                return _RegistroLlegada;
            }
        }
        private static Registro_Llegada.RegistroLlegada _RegistroLlegada;

        public static Registro_Llegada.TurnoProfesional TurnoProf
        {
            get
            {
                if (_TurnoProf == null)
                {
                    _TurnoProf = new Registro_Llegada.TurnoProfesional() ;
                }
                return _TurnoProf;
            }
        }
        private static Registro_Llegada.TurnoProfesional _TurnoProf;

        public static Registro_Resultado.Diagnostico Diagnostico
        {
            get
            {
                if (_Diagnostico == null)
                {
                    _Diagnostico = new Registro_Resultado.Diagnostico();
                }
                return _Diagnostico;
            }
        }
        private static Registro_Resultado.Diagnostico _Diagnostico;

        public static Registrar_Agenta_Medico.RegistrarAgenda Agenda
        {
            get
            {
                if (_Agenda == null)
                {
                    _Agenda = new Registrar_Agenta_Medico.RegistrarAgenda();
                }
                return _Agenda;
            }
        }
       private static Registrar_Agenta_Medico.RegistrarAgenda _Agenda;












    }

}
