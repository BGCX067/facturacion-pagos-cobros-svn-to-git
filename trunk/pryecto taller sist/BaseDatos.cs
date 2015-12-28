using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace pryecto_taller_sist
{
    public class BaseDatos 
    {
        private string connectionString;
        private string nombreTabla;
        private string consultaSql;
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private SqlCommand command;
        private SqlCommandBuilder commandBuilder;
        private DataSet dataSet;


        public DataSet DataSet
        {
            get { return this.dataSet; }
            set { this.dataSet = value; }
        }

        public string ConsultaSql
        {
            get { return this.consultaSql; }
            set { this.consultaSql = value; }
        }

        public string NombreTabla
        {
            get { return this.nombreTabla; }
            set { this.nombreTabla = value; }
        }

        public BaseDatos(string consultaSql, string nombreTabla)
        {
            this.consultaSql = consultaSql;
            this.nombreTabla = nombreTabla;
            this.extraerDatos();
        }

        public void extraerDatos()
        {
            try
            {
                this.connectionString = ConfigurationManager.ConnectionStrings["connectionStringName"].ToString();
                this.connection = new SqlConnection(this.connectionString);
                this.command = new SqlCommand(this.consultaSql, this.connection);
                this.dataAdapter = new SqlDataAdapter(this.command);
                this.commandBuilder = new SqlCommandBuilder(this.dataAdapter);
                this.dataSet = new DataSet();
                this.dataAdapter.Fill(this.dataSet, nombreTabla);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message.ToString());
            }
        }

        public void agregarFila(DataRow fila)
        {
            try
            {
                this.dataSet.Tables[this.nombreTabla].Rows.Add(fila);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message.ToString());
            }
            
            
        }


        public void guardar()
        {
            try
            {
                if (dataSet.HasChanges())
                {
                    this.dataAdapter.Update(this.dataSet, this.nombreTabla);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message.ToString());
            }
        }

    }

    public class Clientes
    {
        private BaseDatos datos;
        string tabla="CLIENTE";
        public Clientes()
        {
            
        }

        public BaseDatos Datos
        {
            get { return this.datos; }
            set { this.datos = value; }
        }

        public void extraerClienteTodosClientes()
        {
            datos = new BaseDatos("select * from CLIENTE", this.tabla);
        }

        public void extraerDatosBusqueda(string nombreCampo,string valor)
        {
            datos = new BaseDatos("select * from CLIENTE where "+nombreCampo+" like '%"+valor+"%'", this.tabla);
            //"select * from CLIENTE where CI likes '2345'";
        }

        public void nuevoCliente(int id,string nombr,string apPat,string apMat,int ci,string dir,int tel)
        {
            DataRow fila = datos.DataSet.Tables[this.tabla].NewRow();
            fila["Id_Cliente"]=id;
            fila["Nombre"]=nombr;
            fila["Apellido_P"]=apPat;
            fila["Apellido_M"]=apMat;
            fila["CI"]=ci;
            fila["Dirección"]=dir;
            fila["Teléfono"]=tel;
            datos.agregarFila(fila);
         }

        public void guardarClientes()
        {
            datos.guardar();
        }

        
    }

    public class Productos
    {
        private BaseDatos datos;
        string tabla = "PRODUCTOS";
        public Productos()
        {

        }

        public BaseDatos Datos
        {
            get { return this.datos; }
            set { this.datos = value; }
        }

        public void extraerTodosProductos()
        {
            datos = new BaseDatos("select * from PRODUCTOS", this.tabla);
        }

        public void extraerDatosBusqueda(string nombreCampo, string valor)
        {
            datos = new BaseDatos("select * from PRODUCTOS where " + nombreCampo + " like '%" + valor + "%'", this.tabla);
            //"select * from CLIENTE where CI likes '2345'";
        }

        public void nuevoProducto(int id, string descripcion, int precio, int stock)
        {
            DataRow fila = datos.DataSet.Tables[this.tabla].NewRow();
            fila["Id_Producto"] = id;
            fila["Descripcion"] = descripcion;
            fila["Precio"] = precio;
            fila["Stock"] = stock;
            datos.agregarFila(fila);
        }

        public void guardarProducto()
        {
            datos.guardar();
        }


    }
}
