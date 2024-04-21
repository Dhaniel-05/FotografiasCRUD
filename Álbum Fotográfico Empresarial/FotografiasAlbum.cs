using Álbum_Fotográfico_Empresarial.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Álbum_Fotográfico_Empresarial
{
    public partial class FotografiasAlbum : Form
    {
        public FotografiasAlbum()
        {
            InitializeComponent();
        }

        Byte[] arrayImagen; //Esta variable se declara para abrir el OpenFileDialog de Cargar Foto.


        private void FotografiasAlbum_Load(object sender, EventArgs e)
        {
            ListarFotografias();
        }

        private void ListarFotografias()
        {
            DataTable dt;
            Datos.Fotografias_Datos data = new Datos.Fotografias_Datos();
            dt = data.ListarFotografias();

            // Limpiar las columnas existentes antes de agregar las nuevas
            dgvFotografias.Columns.Clear();

            // Esta instancia agrega una columna de botones "Modificar" al DataGridView llamado dgvUsuarios.
            DataGridViewButtonColumn buttonColumnModificar = new DataGridViewButtonColumn();
            this.dgvFotografias.Columns.Add(buttonColumnModificar);

            //Esta instancia agrega una columna de botones "Eliminar" al DataGridView llamado dgvUsuarios.
            DataGridViewButtonColumn buttonColumnEliminar = new DataGridViewButtonColumn();
            this.dgvFotografias.Columns.Add(buttonColumnEliminar);


            dgvFotografias.DataSource = dt;
            //Aquí se traen los datos en el orden en el que están en la consulta de la base de datos y se muestra lo que se desea mostrar en el DataGridView con true y lo que no con false.
            dgvFotografias.Columns[0].Visible = true; //Este es el espacio para el botón de Editar
            dgvFotografias.Columns[1].Visible = true; //Este es el espacio para el botón de Eliminar
            dgvFotografias.Columns[2].Visible = false; //Este es el Id. 
            dgvFotografias.Columns[3].Visible = true;
            dgvFotografias.Columns[4].Visible = true;
            dgvFotografias.Columns[5].Visible = true;
            dgvFotografias.Columns[6].Visible = true;
            dgvFotografias.Columns[7].Visible = true;

        }

        private bool modoEdicion = false;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que la foto no esté vacía
            if (arrayImagen == null || arrayImagen.Length == 0)
            {
                MessageBox.Show("Por favor, seleccione una foto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que los campos obligatorios no estén vacíos
            if (string.IsNullOrEmpty(txtDescripcionImagen.Text) || txtDescripcionImagen.Text == "" ||
                string.IsNullOrEmpty(dtFechaEvento.Text) || dtFechaEvento.Text == "" ||
                string.IsNullOrEmpty(txtLugarEvento.Text) || txtLugarEvento.Text == "" ||
                string.IsNullOrEmpty(txtDescripcionEvento.Text) || txtDescripcionEvento.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string descripcionImage = txtDescripcionImagen.Text;
            DateTime fecha = dtFechaEvento.Value;
            string lugar = txtLugarEvento.Text;
            string descripcionEvent = txtDescripcionEvento.Text;

            try
            {
                if (modoEdicion)
                {
                    // Obtener el Id del campo oculto
                    int idFotografia = Int32.Parse(txtId.Text);

                    // Llamar al método de Editar.
                    Datos.Fotografias_Datos agregarFotografias = new Datos.Fotografias_Datos();
                    agregarFotografias.ModificarFotografias(idFotografia, arrayImagen, txtDescripcionImagen.Text, dtFechaEvento.Value, txtLugarEvento.Text, txtDescripcionEvento.Text);
                    MessageBox.Show("Fotografía del evento agregada satisfactoriamente al sistema");

                    MessageBox.Show("Fotografías actualizadas satisfactoriamente.");
                    modoEdicion = false; // Restablecer el modo de edición a false
                    ListarFotografias(); // Actualizar la listado
                    LimpiarCampos(); // Limpiar los campos
                }
                else
                {

                    // Llamar al método de Agregar.
                    Datos.Fotografias_Datos agregarFotografias = new Datos.Fotografias_Datos();
                    agregarFotografias.AgregarFotografias(arrayImagen, txtDescripcionImagen.Text, dtFechaEvento.Value, txtLugarEvento.Text, txtDescripcionEvento.Text);
                    MessageBox.Show("Fotografía del evento agregada satisfactoriamente al sistema");

                    MessageBox.Show("Fotografía agregada satisfactoriamente al sistema");
                    ListarFotografias(); // Actualizar la listado
                    LimpiarCampos(); // Limpiar los campos
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al agregar/modificar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void dgvFotografias_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //Este evento del data grid pinta el objeto que se agrega desde la pestaña de recursos las cuales son imágenes de 16x16 en fondo blanco.

            if (e.RowIndex == -1)
            {
                return;
            }

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                Image imagen = Properties.Resources.dgvEditx20; //Nombre del recurso que se debe agregar a la carpeta del proyecto Resources
                e.Graphics.DrawImage(imagen, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.dgvFotografias.Rows[e.RowIndex].Height = imagen.Height + 8;
                this.dgvFotografias.Columns[e.ColumnIndex].Width = imagen.Width + 8;
                this.dgvFotografias.Columns[e.ColumnIndex].HeaderText = "      ";
                this.dgvFotografias.Columns[e.ColumnIndex].Visible = true;
                e.Handled = true;
            }

            if (e.ColumnIndex == 1)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                Image imagen = Properties.Resources.Eliminarx20; //Nombre del recurso que se debe agregar a la carpeta del proyecto Resources
                e.Graphics.DrawImage(imagen, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
                this.dgvFotografias.Rows[e.RowIndex].Height = imagen.Height + 8;
                this.dgvFotografias.Columns[e.ColumnIndex].Width = imagen.Width + 8;
                this.dgvFotografias.Columns[e.ColumnIndex].HeaderText = "      ";
                this.dgvFotografias.Columns[e.ColumnIndex].Visible = true;
                e.Handled = true;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            // Este evento clic se encadena con la clase construida OpenDialogPicture 
            {
                OpenDialogPicture abrirCadena = new OpenDialogPicture(this.txtFile.Text, this.picFoto.Image);
                try
                {
                    this.txtFile.Text = abrirCadena.AbrirCadena(this.txtFile.Text);
                    this.picFoto.Image = abrirCadena.MostrarImagen(this.txtFile.Text);

                    Imagen imagenArray = new Imagen();
                    arrayImagen = imagenArray.ImageToByteArray(this.picFoto.Image); //Aquí se utiliza la variable declarada para cargar la foto. 
                }
                catch
                {
                    MessageBox.Show("Seleccione una foto", "Notificación");
                }
            }
        }

        private void dgvFotografias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en el botón de eliminar (segunda columna, índice 1)
            if (e.RowIndex >= 0 && e.ColumnIndex == 1 && dgvFotografias.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                // Obtener el IdUsuario del usuario a eliminar
                int IdFotografias = Convert.ToInt32(dgvFotografias.Rows[e.RowIndex].Cells["IdFotografias"].Value);

                // Mostrar ventana emergente de confirmación
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar este registro fotográfico?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Llamar al método EliminarUsuario de la clase Usuarios
                    Datos.Fotografias_Datos fotografia = new Datos.Fotografias_Datos();
                    fotografia.EliminarFotografias(IdFotografias);

                    // Actualizar el DataGridView con la lista de usuarios reciente
                    ListarFotografias();
                    LimpiarCampos();
                }
            }
            // Verificar si se hizo clic en el botón de modificar (primera columna, índice 0)
            if (e.RowIndex >= 0 && e.ColumnIndex == 0 && dgvFotografias.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                // Obtener el IdUsuario del usuario a editar
                int IdFotografias = Convert.ToInt32(dgvFotografias.Rows[e.RowIndex].Cells["IdFotografias"].Value);
                DateTime fechaSolicitud = DateTime.Parse(dtFechaEvento.Text);

                //Se implementa la lógica de cargar los datos en el formulario 
                Datos.Fotografias_Datos fotografia = new Datos.Fotografias_Datos();
                DataTable dtFoto = fotografia.TraerFotografiasPorId(IdFotografias);

                if (dtFoto.Rows.Count > 0)
                {
                    txtId.Text = dtFoto.Rows[0]["IdFotografias"].ToString();
                    txtDescripcionImagen.Text = dtFoto.Rows[0]["DescripcionImagen"].ToString();
                    dtFechaEvento.Value = DateTime.Parse(dtFoto.Rows[0]["FechaEvento"].ToString());
                    txtLugarEvento.Text = dtFoto.Rows[0]["Lugar"].ToString();
                    txtDescripcionEvento.Text = dtFoto.Rows[0]["DescripcionEvento"].ToString();


                    // Cargar la foto en el PictureBox
                    byte[] fotoUsuario = (byte[])dtFoto.Rows[0]["Foto"];
                    if (fotoUsuario != null && fotoUsuario.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(fotoUsuario))
                        {
                            picFoto.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        // Si no hay foto, se puede implemenar que muestre una imagen predeterminada o dejar el PictureBox vacío.
                        picFoto.Image = null; // PictureBox vacío

                    }
                    // Se establece la variable declarada en true para poder realizar la edición luego de dar clic en el botón de editar del dgvUsuarios.
                    modoEdicion = true;
                }
            }
        }


        private void LimpiarCampos()
        {
            txtId.Text = "0";
            picFoto.Text = "";
            txtDescripcionImagen.Text = "";
            dtFechaEvento.Text = "";
            txtLugarEvento.Text = "";
            txtDescripcionEvento.Text = "";
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            //Cuando el texto cambia busca en la base de datos según los datos ingresados.
            string filtro = txtBusqueda.Text;

            if (dgvFotografias.DataSource is DataView dataView)
            {
                FiltrarDatos(dataView, filtro);
            }
            else if (dgvFotografias.DataSource is DataTable dataTable)
            {
                DataView dvTarifas = dataTable.DefaultView;
                FiltrarDatos(dvTarifas, filtro);
            }
        }

        // Método filtrar datos mejorado para la búsqueda indexada manejando la excepción de array de bytes. 
        private void FiltrarDatos(DataView dataView, string filtro)
        {
            var columnasVisibles = dgvFotografias.Columns.Cast<DataGridViewColumn>()
                .Where(column => column.Visible)
                .Select(column => column.Name);

            StringBuilder filtroColumnas = new StringBuilder();

            foreach (string columna in columnasVisibles)
            {
                if (dataView.Table.Columns.Contains(columna))
                {
                    var columnaDataType = dataView.Table.Columns[columna].DataType;

                    try
                    {
                        if (columnaDataType == typeof(byte[]))
                        {
                            throw new NotSupportedException("");
                        }
                        else if (columnaDataType == typeof(DateTime) || columnaDataType == typeof(decimal) || columnaDataType == typeof(int))
                        {
                            filtroColumnas.Append($"CONVERT([{columna}], 'System.String') LIKE '%{filtro}%' OR ");
                        }
                        else
                        {
                            filtroColumnas.Append($"[{columna}] LIKE '%{filtro}%' OR ");
                        }
                    }
                    catch (NotSupportedException ex)
                    {
                        // Manejar la excepción, no hacer nada para que continue con el flujo normal.
                    }
                }
            }

            // Eliminar el último "OR" del filtro y aplicar el filtro al DataView del DataGridView
            if (filtroColumnas.Length > 0)
            {
                filtroColumnas.Length -= 4; // Eliminar los últimos 4 caracteres (" OR ")
                dataView.RowFilter = filtroColumnas.ToString();
            }
            else
            {
                dataView.RowFilter = string.Empty;
            }
        }

    }
}
