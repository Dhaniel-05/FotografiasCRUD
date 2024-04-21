using Álbum_Fotográfico_Empresarial.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Álbum_Fotográfico_Empresarial.Datos
{
    public class Fotografias_Datos
    {
        public DataTable ListarFotografias()
        {
            Conexion conexion = new Conexion();
            //string readLlenar = "Select * From Fotografias";
            string readLlenar = "Select IdFotografias, Foto, DescripcionImagen AS 'Descripción de la imagen', FechaEvento AS 'Fecha del evento', Lugar, DescripcionEvento AS 'Descripción del evento' From Fotografias;\r\n";
            SqlCommand sql = new SqlCommand(readLlenar, conexion.conectar());
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            sqlData.Fill(dt);
            return dt;
        }

        public void AgregarFotografias(byte[] Foto, string DescripcionImagen, DateTime FechaEvento, string Lugar, string DescripcionEvento)
        {
            Conexion conectar = new Conexion();
            string consultaInsertar = "Insert INTO Fotografias (Foto, DescripcionImagen, FechaEvento, Lugar, DescripcionEvento) Values (@Foto,@DescripcionImagen,@FechaEvento,@Lugar,@DescripcionEvento)";

            SqlCommand comandoInsertaUsuario = new SqlCommand(consultaInsertar, conectar.conectar());

            comandoInsertaUsuario.Parameters.AddWithValue("@Foto", Foto);
            comandoInsertaUsuario.Parameters.AddWithValue("@DescripcionImagen", DescripcionImagen);
            comandoInsertaUsuario.Parameters.AddWithValue("@FechaEvento", FechaEvento);
            comandoInsertaUsuario.Parameters.AddWithValue("@Lugar", Lugar);
            comandoInsertaUsuario.Parameters.AddWithValue("@DescripcionEvento", DescripcionEvento);

            comandoInsertaUsuario.ExecuteNonQuery();
        }

        public DataTable TraerFotografiasPorId(int IdFotografias)
        {
            Conexion conexion = new Conexion();
            string consulta = "SELECT IdFotografias, Foto, DescripcionImagen, FechaEvento, Lugar, DescripcionEvento FROM Fotografias WHERE IdFotografias = @IdFotografias";
            SqlCommand sql = new SqlCommand(consulta, conexion.conectar());
            sql.Parameters.AddWithValue("@IdFotografias", IdFotografias);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);
            return dataTable;
        }

        public void ModificarFotografias(int IdFotografias, byte[] Foto, string DescripcionImagen, DateTime FechaEvento, string Lugar, string DescripcionEvento)
        {
            Conexion conectar = new Conexion();
            string consultaModificar = "UPDATE Fotografias SET Foto = @Foto, DescripcionImagen = @DescripcionImagen, FechaEvento = @FechaEvento, Lugar = @Lugar, DescripcionEvento = @DescripcionEvento WHERE IdFotografias = @IdFotografias";

            SqlCommand sql = new SqlCommand(consultaModificar, conectar.conectar());

            sql.Parameters.AddWithValue("@IdFotografias", IdFotografias);
            sql.Parameters.AddWithValue("@Foto", Foto);
            sql.Parameters.AddWithValue("@DescripcionImagen", DescripcionImagen);
            sql.Parameters.AddWithValue("@FechaEvento", FechaEvento);
            sql.Parameters.AddWithValue("@Lugar", Lugar);
            sql.Parameters.AddWithValue("@DescripcionEvento", DescripcionEvento);

            sql.ExecuteNonQuery();
        }

        public void EliminarFotografias(int IdFotografias)
        {
            Conexion conectar = new Conexion();
            string consultaEliminar = "DELETE FROM Fotografias WHERE IdFotografias = @IdFotografias";
            SqlCommand sql = new SqlCommand(consultaEliminar, conectar.conectar());
            sql.Parameters.AddWithValue("@IdFotografias", IdFotografias);
            sql.ExecuteNonQuery();
        }
    }
}
