using System;

namespace JuanLogica

{
    public class Logica
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Resultado { get; set; }
        public object Profesion { get; set; }
        public string Seccion { get; set; }

        public void DatosMedico()
        {
            Resultado = Nombre + Apellido;
        }

        public void DatosDeLaProfesion()
        {
            Resultado = Profesion + Seccion;
        }
    }
}