using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_TPR1_Ratz
{
    public partial class Form1 : Form
    {

        List<Alumno> ListaDeAlumnos = new List<Alumno>();
        int IndexAlumnoModificado = new int();

        public Form1()
        {
            InitializeComponent();

            //cargo algunos alumnos de ejemplo al incio del form, utilizando el contructor con parámetros
            Alumno AlumnoTemp1 = new Alumno(1, "Mariano", "Moreno", new DateTime(1978, 3, 23, 0, 0, 00), new DateTime(2012, 9, 10, 0, 0, 00), 22, true, 10);
            AlumnoTemp1.Edad = AlumnoTemp1.Edad_Alumno();
            ListaDeAlumnos.Add(AlumnoTemp1);

            Alumno AlumnoTemp2 = new Alumno(2, "Juan", "Paso", new DateTime(1962, 4, 2, 0, 0, 00), new DateTime(2016, 3, 4, 0, 0, 00), 22, true, 6);
            AlumnoTemp2.Edad = AlumnoTemp2.Edad_Alumno();
            ListaDeAlumnos.Add(AlumnoTemp2);

            Alumno AlumnoTemp3 = new Alumno(3, "Maria", "Cuenca", new DateTime(1984, 7, 8, 0, 0, 00), new DateTime(2015, 3, 8, 0, 0, 00), 22, true, 14);
            AlumnoTemp3.Edad = AlumnoTemp3.Edad_Alumno();
            ListaDeAlumnos.Add(AlumnoTemp3);

            Alumno AlumnoTemp4 = new Alumno(4, "Diana", "Ventura", new DateTime(1986, 3, 3, 0, 0, 00), new DateTime(2012, 2, 3, 0, 0, 00), 22, true, 1);
            AlumnoTemp4.Edad = AlumnoTemp4.Edad_Alumno();
            ListaDeAlumnos.Add(AlumnoTemp4);

            //actualizo la lista de alumnos que ve el usuario.
            RefrescarDataGridView();

            //se asegura que los controles de ingreso estén deshabilitados.
            LimpiarYDeshabilitarIngresoDeDatos();
            

        }

        public void button1_Click(object sender, EventArgs e)
        {

            //el boton de aceptar un nuevo usuario, en primer instancia guarda los datos de los controles de ingreso en el objeto AlumnoTemp, y temporalmente pone la edad en 1

            Alumno alumnotemp = new Alumno(int.Parse(txt_Legajo.Text), txt_Nombre.Text, txt_Apellido.Text, txt_Fecha_Nacimiento.Value.Date, txt_Fecha_Ingreso.Value.Date, 1, txt_activo.Checked, int.Parse(txt_Cant_Materias_Aprobadas.Text));

            //luego se calcula la edad de manera automática, de manera tal que el usuario no debe escribirla

            alumnotemp.Edad = alumnotemp.Edad_Alumno();
            
            // y luego agregar dicho objeto temporal al final de la lista de alumnos

            ListaDeAlumnos.Add(alumnotemp);

            //actualizo la lista de alumnos que ve el usuario.
            RefrescarDataGridView();

            // se limpian los controles de ingreso
            LimpiarYDeshabilitarIngresoDeDatos();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Se verifica que el usuario haya elegido algun Alumno del grid

            if (AlumnoSeleccionado() == true) { 

                // al intentar eliminar un alumno, se le pide confirmación al usuario

                var confirmResult = MessageBox.Show("Está seguro que desea eliminar el alumno seleccionado?",
                                         "Confirmar Eliminación",
                                         MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {

                    foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                    {

                        // Si el usuario confirma la operación, se remueve de la lista el item seleccionado el el gridview
                        ListaDeAlumnos.RemoveAt(item.Index);

                        //actualizo la lista de alumnos que ve el usuario.
                        RefrescarDataGridView();
                    
                    }

                }

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Se verifica que el usuario haya elegido algun Alumno del grid
            if (AlumnoSeleccionado() == true)
            {


                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {

                    //el boton de "Modificar Alumno Seleccionado" en primer instancia habilita los controles de entrada del usuario

                    HabilitarIngresoDeDatos("Modificación", false, true, true);
                    groupBox2.Text = "Modificando Alumno";

                    //y luego copia los datos del Alumno seleccionado a los textbox para que el usuario pueda realizar las modificaciones

                    IndexAlumnoModificado = item.Index;
                    txt_Legajo.Text = ListaDeAlumnos[item.Index].Legajo.ToString();
                    txt_Nombre.Text = ListaDeAlumnos[item.Index].Nombre;
                    txt_Apellido.Text = ListaDeAlumnos[item.Index].Apellido;
                    txt_Fecha_Nacimiento.Value = ListaDeAlumnos[item.Index].Fecha_Nacimiento;
                    txt_Fecha_Ingreso.Value = ListaDeAlumnos[item.Index].Fecha_Ingreso;
                    txt_activo.Checked = ListaDeAlumnos[item.Index].Activo;
                    txt_Cant_Materias_Aprobadas.Text = ListaDeAlumnos[item.Index].Cant_Materias_Aprobadas.ToString();
                    txt_Legajo.Focus();

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //el boton de Guardar Cambios, se utiliza solo cuando se quiera modificar un alumno.
            //en esta etapa ya se tienen los nuevos datos del alumno, por lo cual se guardan en un objeto Alumno "temporal", donde la edad es 1 y luego se calculará

            Alumno alumnotemp = new Alumno(int.Parse(txt_Legajo.Text), txt_Nombre.Text, txt_Apellido.Text, txt_Fecha_Nacimiento.Value.Date, txt_Fecha_Ingreso.Value.Date, 1, txt_activo.Checked, int.Parse(txt_Cant_Materias_Aprobadas.Text));

            //luego se calcula la edad de manera automática, de manera tal que el usuario no debe escribirla (es solo lectura de acuerdo al enunciado)

            alumnotemp.Edad = alumnotemp.Edad_Alumno();
            
            // La variable IndexAlumnoModificado indica cual es el objeto de la lista que se está modificando, por lo cual se reemplaza
            // el contenido actual por el contenido modificado.

            ListaDeAlumnos[IndexAlumnoModificado] = alumnotemp;
            
            //actualizo la lista de alumnos que ve el usuario.
            RefrescarDataGridView();
           
            //finalizo la operación

            LimpiarYDeshabilitarIngresoDeDatos();


        }

        private void button5_Click(object sender, EventArgs e)
        {

            //el boton de Alta de alumno, prepara los controles entrada para cargar un nuevo alumno en la lista

            HabilitarIngresoDeDatos("Alta", true, true, false);
            groupBox2.Text = "Agregando Alumno";

        }

        private void button6_Click(object sender, EventArgs e)
        {

            //el boton cancelar simplemente limpia los controles y deshabilita el ingreso de datos

            LimpiarYDeshabilitarIngresoDeDatos();

        }

        public void LimpiarYDeshabilitarIngresoDeDatos()
        {
            //deshabilito los botones de aceptar/cancelar/modificar

            button1.Enabled = false;
            button6.Enabled = false;
            button4.Enabled = false;

            groupBox2.Text = null;

            //limpio los controles de entrada

            txt_Legajo.Text = null;
            txt_Nombre.Text = null;
            txt_Apellido.Text = null;
            txt_Fecha_Nacimiento.Value = DateTime.Today;
            txt_Fecha_Ingreso.Value = DateTime.Today;
            txt_activo.Checked = false;
            txt_Cant_Materias_Aprobadas.Text = null;

            //deshabilito los controles de entrada
            txt_Legajo.Enabled = false;
            txt_Nombre.Enabled = false;
            txt_Apellido.Enabled = false;
            txt_Fecha_Nacimiento.Enabled = false;
            txt_Fecha_Ingreso.Enabled = false;
            txt_activo.Enabled = false;
            txt_Cant_Materias_Aprobadas.Enabled = false;


            //habilito los botones de operación

            dataGridView1.Enabled = true;

            button2.Enabled = true;
            button3.Enabled = true;
            button5.Enabled = true;
            button7.Enabled = true;

            //limpio la información adicional del usuario

            txt_antiguedad.Text = null;
            txt_no_aprobadas.Text = null;
            txt_edad_ingreso.Text = null;

        }

        public void HabilitarIngresoDeDatos(string Operacion, bool Aceptar, bool Cancelar, bool Guardar)
        {

            //deshabilita el gridview para que el usuario no cambie el alumno seleccionado

            dataGridView1.Enabled = false;

            //dependiendo si es un alta de un usuario o una modificación se muestran distintos botones

            if (Aceptar == true) { button1.Enabled = true; }
            if (Cancelar == true) { button6.Enabled = true; }
            if (Guardar == true) { button4.Enabled = true; }

            if (Operacion == "Alta")
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button7.Enabled = false;
            }

            if (Operacion == "Modificación")
            {
                button2.Enabled = false;
                button5.Enabled = false;
                button7.Enabled = false;
            }

            //se habilitan los controles de entrada

            txt_Legajo.Enabled = true;
            txt_Nombre.Enabled = true;
            txt_Apellido.Enabled = true;
            txt_Fecha_Nacimiento.Enabled = true;
            txt_Fecha_Ingreso.Enabled = true;
            txt_activo.Enabled = true;
            txt_Cant_Materias_Aprobadas.Enabled = true;

            //se limpian los controles de entrada para que no tengan ningun valor previo

            txt_Legajo.Text = null;
            txt_Nombre.Text = null;
            txt_Apellido.Text = null;
            txt_Fecha_Nacimiento.Value = DateTime.Today;
            txt_Fecha_Ingreso.Value = DateTime.Today;
            txt_activo.Checked = false;
            txt_Cant_Materias_Aprobadas.Text = null;

            txt_antiguedad.Text = null;
            txt_no_aprobadas.Text = null;
            txt_edad_ingreso.Text = null;

            txt_Legajo.Focus();

        }

        public void RefrescarDataGridView()
        {
            //simplemente se limpia el datasource del grid y se vuelve a cargar para mostrar datos actualizados.
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListaDeAlumnos;

            //debido a que los siguientes campos están marcados en el enunciado como "Solo escritura" se ocultan del grid 
            // para que el usuario no pueda leerlos, sin embargo se solicitan sus valores al dar de alta un usuario o modificarlo

            this.dataGridView1.Columns["Fecha_Nacimiento"].Visible = false;
            this.dataGridView1.Columns["Fecha_Ingreso"].Visible = false;
            this.dataGridView1.Columns["Cant_Materias_Aprobadas"].Visible = false;

        }

        public bool AlumnoSeleccionado() 
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 0) {
                MessageBox.Show("Debe Seleccionar un Alumno", "Información", MessageBoxButtons.OK);
                return false;
            } else
            {
                return true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Se verifica que el usuario haya elegido algun Alumno del grid
            if (AlumnoSeleccionado() == true)
            {


                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {

                    //llamado al metodo de la clase Alumno para calcular lo solicitado

                    int noaprobadas = ListaDeAlumnos[item.Index].Materias_No_Aprobadas();
                    txt_no_aprobadas.Text = noaprobadas.ToString();

                    //llamado al metodo de la clase Alumno para calcular lo solicitado

                    int edadingreso = ListaDeAlumnos[item.Index].Edad_De_Ingreso();
                    txt_edad_ingreso.Text = edadingreso.ToString();

                    //llamado al metodo de la clase Alumno para calcular lo solicitado, pero en este caso 
                    //se utilizan los radio buttons para entender como quiere ver el resultado el usuario

                    int antiguedad = new int();

                    if (radio_años.Checked == true) { antiguedad = ListaDeAlumnos[item.Index].Antigüedad("A"); }
                    if (radio_meses.Checked == true) { antiguedad = ListaDeAlumnos[item.Index].Antigüedad("M"); }
                    if (radio_dias.Checked == true) { antiguedad = ListaDeAlumnos[item.Index].Antigüedad("D"); }

                    txt_antiguedad.Text = antiguedad.ToString();

                }

            }

        }
    }
}
