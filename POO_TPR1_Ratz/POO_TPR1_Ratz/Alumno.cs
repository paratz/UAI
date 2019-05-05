using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace POO_TPR1_Ratz
{
    public class Alumno //Definición de la Clase Alumno
    {
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public int Edad { get; set; }
        public bool Activo { get; set; }
        public int Cant_Materias_Aprobadas { get; set; }

        public int Antigüedad(string Unidad) /*unidad es un string que debe tomar valor "A" - Años, "M" - Meses o "D" - Dias */
        { /* aqui va el calculo de la antiguedad, se contemplan meses de 30 dias únicamente y no se contemplan años bisiestos */

            if (Unidad.Equals("D"))
            {
                TimeSpan TotalD = DateTime.Now.Subtract(this.Fecha_Ingreso);
                return (int)TotalD.TotalDays;
            }

            if (Unidad.Equals("M"))
            {
                TimeSpan TotalM = DateTime.Now.Subtract(this.Fecha_Ingreso);
                return (int)(TotalM.TotalDays / 30);
            }

            if (Unidad.Equals("A"))
            {
                TimeSpan TotalA = DateTime.Now.Subtract(this.Fecha_Ingreso);
                return (int)(TotalA.TotalDays / 365);
            }

            return 0;
        }
    

        public int Materias_No_Aprobadas()
        {
            return (int)36 - this.Cant_Materias_Aprobadas;
        }

        //este método se utiliza para calcular la edad de ingreso del alumno

        public int Edad_De_Ingreso()
        {
            byte axo = (byte)this.Fecha_Nacimiento.Year;
            if (this.Fecha_Nacimiento.DayOfYear <= this.Fecha_Ingreso.DayOfYear) { axo -= 1; }
            return (byte)(this.Fecha_Ingreso.Year - axo);
        }

        //Este metodo se utiliza para calcular la edad del alumno

        public int Edad_Alumno()
        {
            byte axo = (byte)this.Fecha_Nacimiento.Year;
            if (this.Fecha_Nacimiento.DayOfYear <= DateTime.Today.DayOfYear) { axo -= 1; }
            return (byte)(DateTime.Today.Year - axo);
        }

        //Constructor sin parámetros
        public Alumno() { }

        //Constructor con todos los parámetros que permiten inicializar las propiedades.
        public Alumno(int pLegajo, string pNombre, string pApellido, DateTime pFecha_Nacimiento, DateTime pFecha_Ingreso, int pEdad, Boolean pActivo, int pCant_Materias_Aprobadas)
        {
            this.Legajo = pLegajo;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.Fecha_Nacimiento = pFecha_Nacimiento;
            this.Fecha_Ingreso = pFecha_Ingreso;
            this.Edad = pEdad;
            this.Activo = pActivo;
            this.Cant_Materias_Aprobadas = pCant_Materias_Aprobadas;
        }

        // Finalizador: Que cuando el objeto queda liberado muestre una leyenda indicando el Legajo, Nombre y Apellido del Alumno.
        ~Alumno()
        {

            string box_title = "Objeto Liberado";
            string box_msg = "Legajo: " + this.Legajo + "\n" + "Nombre: " + this.Nombre + "\n" + "Apellido: " + this.Apellido;
            MessageBox.Show(box_msg, box_title, MessageBoxButtons.OK);

        }

    }

}
