using System;
using System.Windows.Forms;

namespace Plantilla
{
    public partial class Form1 : Form
    {
        ClassProcesos Proceso = new ClassProcesos();
        public Form1()
        {
            InitializeComponent();
        }

        //Proceso método para limmpiar.
        private void limpiar()
        {
            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtproducto.Text = "";
            txttelefono.Text = "";
            txtestado.Text = "";
        }

        //Process actualización y recarga información. 
        private void Form1_Load(object sender, EventArgs e)
        {
            RecargarDataGrid(Proceso.getDatosPersonas());
        }

        public void RecargarDataGrid(object DatosPersona)
        {
            dataGridView1.DataSource = DatosPersona;
        }



        //Proceso registrar
        private void buttonagregar_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text != "") //Verificamos que los campos no esten vacíos.
            {
                Boolean respuesta;
                Proceso.setVariables(txtnombre.Text, txtapellido.Text, txtproducto.Text, txttelefono.Text);
                respuesta = Proceso.getRegistrar();

                if (txtestado.Text == "") 
                {
                    if (respuesta == true)
                    {
                        RecargarDataGrid(Proceso.getDatosPersonas());
                        MessageBox.Show("El usuario " + txtnombre.Text + " fue registrado con éxito", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar al usuario " + txtnombre.Text, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }
                }
                else
                {
                    MessageBox.Show("El usuario " + txtnombre.Text + " ya está registrado", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
            }
            else //Evitamos la caida del programa ebiado a requerimeintos nulos. 
            {
                MessageBox.Show("Nada que agregar", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }                        
        }


        //Proceso registrar
        private void buttonmodificar_Click(object sender, EventArgs e)
        {

            if (txtcodigo.Text != "" ) //Verificamos que los campos no esten vacíos.
            {
                Boolean respuesta;
                Proceso.setVariables(txtnombre.Text, txtapellido.Text, txtproducto.Text, txttelefono.Text, txtestado.Text, int.Parse(txtcodigo.Text));
                respuesta = Proceso.getActualizar();


                if (respuesta == true)
                {
                    RecargarDataGrid(Proceso.getDatosPersonas());

                    MessageBox.Show("El usuario " + txtnombre.Text + " fue modificado con éxito", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar al usuario " + txtnombre.Text, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
            }
            else //Evitamos la caida del programa ebiado a requerimeintos nulos. 
            {
                MessageBox.Show("Nada que modificar", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
        }


        //Proceso eliminar
       
        private void buttoneliminar_Click(object sender, EventArgs e)
        {

            if (txtcodigo.Text != "") //Verificamos que los campos no esten vacíos.
            {
                Boolean respuesta;
                Proceso.setVariables(txtnombre.Text, txtapellido.Text, txtproducto.Text, txttelefono.Text, txtestado.Text, int.Parse(txtcodigo.Text));
                respuesta = Proceso.getEliminar();

                if (respuesta == true)
                {
                    RecargarDataGrid(Proceso.getDatosPersonas());
                    MessageBox.Show("El usuario " + txtnombre.Text + "fue eliminado con éxito", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar al usuario " + txtnombre.Text, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
            }
            else //Evitamos la caida del programa ebiado a requerimeintos nulos. 
            {
                MessageBox.Show("Nada que eliminar", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
        }


        //Proceso limpiar
        private void buttonlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }


        //Proceso mostrar datos en datagrid
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;

            txtcodigo.Text = dataGridView1[0, fila].Value.ToString();
            txtnombre.Text = dataGridView1[1, fila].Value.ToString();
            txtapellido.Text = dataGridView1[2, fila].Value.ToString();
            txtproducto.Text = dataGridView1[3, fila].Value.ToString();
            txttelefono.Text = dataGridView1[4, fila].Value.ToString();
            txtestado.Text = dataGridView1[5, fila].Value.ToString();
        }
    }
}
