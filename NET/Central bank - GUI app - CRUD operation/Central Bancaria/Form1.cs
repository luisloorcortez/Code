//Librerías creadas.
using Capa_entidad;
using Capa_negocio;

//Librerías del systema.
using System;
using System.Data;
using System.Windows.Forms;


namespace Cetralita
{
    //Programamos los eventos de la interfaz gráfica en el formulario. 
    public partial class mebotones : Form
    {
        //Instanciamos métodos en las clases entidad y negocio, utilizada a travez de las bobliotecas importadas.
        ClassEntidad objent = new ClassEntidad();
        ClassNegocio objneg = new ClassNegocio();
        public mebotones()
        {
            InitializeComponent();
        }

        //Hacemos el enlace de los elementos en la base de datos con cada txtbox del formulario. 
        private void mantenimiento(String accion)
        {
            //Realizamos control de exepciones en los elementos enviados a travez de cada txtbox.
            try
            {
                //Asignamos los valores tomados por todos los métodos en la clase entidad, a cada texbox utilizado. Usando el objeto objent
                objent.codigo = txtidentificador.Text;
                objent.nombre = txtnombre.Text;
                objent.apellidos = txtapellido.Text;
                objent.estado = txtestado.Text;
                objent.cedula = txtcedula.Text;
                objent.tarjeta = txttarjeta.Text;
                objent.direccion = txtdireccion.Text;
                objent.cuenta = txtcuenta.Text;
                objent.edad = Convert.ToInt32(txtedad.Text);
                objent.telefono = txttelefono.Text;
                objent.accion = accion;
                String men = objneg.N_mantenimiento_cliente(objent);
                MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Además, por rebote verificamos que el usuario haya llenado todas las casillas. No permitimos campos nulos en la base. 
            catch
            {
                MessageBox.Show("Parece que algo anda mal... ¿Ingresaste datos correctos?", "Notificación de Banco el Desfalcador.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        //Método para limpiar los texbox luego de cada acción realizada. Entregando valores 0 a cada texbox. 
        private void limpiar()
        {
            txtidentificador.Text = "";
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtestado.Text = "";
            txtcedula.Text = "";
            txttarjeta.Text = "";
            txtdireccion.Text = "";
            txtcuenta.Text = "";
            txtedad.Text = "";
            txttelefono.Text = "";
            txtbuscar.Text = "";
            dataGridView1.DataSource = objneg.N_listar_clientes();
        }



        //Creamso el evento que nos mostrará los valores existentes en la tabla.
        private void mebotones_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objneg.N_listar_clientes();
        }


        //Realizamos operaciones de mantenimiento en la base de datos, además creamos lógica de ingreso revisando por txtbox, por cada método de mantenimiento.
        //Utilizamos los procedimientos colocados en la base de datos conectada. 
      
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Verificamos que el usuario no se encuentre utilizando una actualizando de registro para crear un nuevo usuario.
            if (txtidentificador.Text != "")
            {
                MessageBox.Show("El usuario " + txtnombre.Text + " ya está registrado. Código "+ txtidentificador.Text, "Notificación de Banco el Desfalcador.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Verificamos que las casillas no estén vacías.
                if (txtnombre.Text != "")
                {
                    if (MessageBox.Show("¿Deseas registrar a " + txtnombre.Text + "?", "Notificación de Banco el Desfalcador.",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        mantenimiento("crear");
                        limpiar();
                    }
                }
                else MessageBox.Show("Por favor, ingresa los datos que deseas registrar.", "Notificación de Banco el Desfalcador.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                {
                    limpiar();
                }
            }
        }



        //Modificar elemento.
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Verificamos que las casillas no estén vacías.
            if (txtidentificador.Text != "")
            {
                if (MessageBox.Show("¿Deseas modificar a " + txtnombre.Text + "?", "Notificación de Banco el Desfalcador.",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("actualizar");
                    limpiar();
                }
                else MessageBox.Show("No se relizaron cambios.", "Notificación de Banco el Desfalcador.");
            }
            else MessageBox.Show("Por favor, selecciona el registro que deseas modificar.", "Notificación de Banco el Desfalcador.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        //Buscar y mostrar elemento.
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text != "")
            {
                objent.nombre = txtbuscar.Text;
                DataTable dt = new DataTable();
                dt = objneg.N_buscar_clientes(objent);
                dataGridView1.DataSource = dt;
            }

            else
            {
                dataGridView1.DataSource = objneg.N_listar_clientes();
            }
        }



        //Borrar elemento.
        private void limpiarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Verificamos que las casillas no estén vacías.
            if (txtidentificador.Text != "")
            {
                if (MessageBox.Show("¿Deseas eliminar a " + txtnombre.Text + "?", "Notificación de Banco el Desfalcador.",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("borrar");
                    limpiar();
                }
            }
            else MessageBox.Show("Por favor, selecciona el registro que deseas eliminar.", "Notificación de Banco el Desfalcador.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        //Limpiar capos de txtbox.
        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtidentificador.Text != "")
            {
                limpiar();
            }
            else MessageBox.Show("Nada que limpiar", "Notificación de Banco el Desfalcador.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        //Mostramos los elementos de la base de datos en el DataGrid, desde la columa 0 hasta la 9 en la tabla que usaremos. 
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex; //Obtenemmos y establecemos las filas.

            txtidentificador.Text = dataGridView1[0, fila].Value.ToString();
            txtcedula.Text = dataGridView1[1, fila].Value.ToString();
            txtnombre.Text = dataGridView1[2, fila].Value.ToString();
            txtapellido.Text = dataGridView1[3, fila].Value.ToString();
            txtedad.Text = dataGridView1[4, fila].Value.ToString();
            txtcuenta.Text = dataGridView1[5, fila].Value.ToString();
            txttarjeta.Text = dataGridView1[6, fila].Value.ToString();
            txttelefono.Text = dataGridView1[7, fila].Value.ToString();
            txtdireccion.Text = dataGridView1[8, fila].Value.ToString();
            txtestado.Text = dataGridView1[9, fila].Value.ToString();
        }
    }
}
