using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using negocio;
using System.Windows.Forms;
using Conecion;
using System.Data;

namespace acessoDato
{
    public class AcessoDatos : agendaDao
    {
        private static AcessoDatos instance;
        Conexions ss = new Conexions();

         SqlConnection conn;

        private AcessoDatos()
        {
            conn = Conexions.conecion();

        }

        public static AcessoDatos getInstance()
        {
            if (instance == null)
            {
                instance = new AcessoDatos();
            }
            return instance;
        }

        public void delete(int agenda)
        {

            MessageBox.Show("Conectado");
            string query = "DELETE FROM merca WHERE id = @id";

            // Crear el comando para ejecutar el query de eliminación
            using (SqlCommand command = new SqlCommand("delete_merca", conn))
            {
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter = new SqlParameter("@id", SqlDbType.Int);
                parameter.Value = agenda;
                command.Parameters.Add(parameter);

                command.ExecuteNonQuery();
            }

           



            
            MessageBox.Show("cerrando...");
        }

        public void insert(agendaDTO agenda)
        {
            
            MessageBox.Show("Conectado");

            string come = "Bienvenido";

            MessageBox.Show(come);

          
                if (conn.State == ConnectionState.Closed)
                {
                conn = Conexions.conecion();
                 }
            
           

            string query = "INSERT INTO merca (nombre, cantidad, distribuidora) VALUES (@nombre,@cantidad,@distribuidora)"; ;
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                // Asignar los valores a los parámetros del comando
                command.Parameters.AddWithValue("@Nombre", agenda.Nombre);
                command.Parameters.AddWithValue("@cantidad", agenda.cantidad);
                command.Parameters.AddWithValue("@distribuidora", agenda.provedores);
             

                // Ejecutar el comando
                command.ExecuteNonQuery();
            }
            

           

            
            MessageBox.Show("cerrando...");
        }

      
        public List<string> Select(string nombres)
        {
            List<string> resultados = new List<string>();

            // Crear la conexión a la base de datos
          
               

                // Crear el query de selección
                string query = "SELECT * FROM merca WHERE Nombre LIKE @Nombre";

                // Crear el comando para ejecutar el query de selección
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    // Asignar el valor del parámetro @Nombre
                    command.Parameters.AddWithValue("@Nombre", "%" + nombres + "%");

                    // Ejecutar el comando y crear un objeto SqlDataReader para leer los resultados
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Recorrer los registros y agregarlos a la lista de resultados
                        while (reader.Read())
                        {
                        int idAgenda = reader.GetInt32(0);
                        string nombre = reader.GetString(1);
                        int apellido = reader.GetInt32(2);
                        string fechaNacimiento = reader.GetString(3);


                        string resultado = string.Format("ID: {0}, Nombre: {1} cantidad : {2}, Distribuidora: {3}", idAgenda, nombre, apellido, fechaNacimiento);

                        resultados.Add(resultado);
                    }
                    }
                }
            return resultados;
        

        }
        public List<string> Select()
        {
            List<string> resultados = new List<string>();

            // Crear la conexión a la base de datos



            // Crear el query de selección
            string query = "SELECT * FROM merca ";
            
            // Crear el comando para ejecutar el query de selección
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                // Asignar el valor del parámetro @Nombre
                

                // Ejecutar el comando y crear un objeto SqlDataReader para leer los resultados
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Recorrer los registros y agregarlos a la lista de resultados
                    while (reader.Read())
                    {
                        int idAgenda = reader.GetInt32(0);
                        string nombre = reader.GetString(1);
                        int apellido = reader.GetInt32(2);
                        string fechaNacimiento = reader.GetString(3);
                       

                        string resultado = string.Format("ID: {0}, Nombre: {1} cantidad : {2}, Distribuidora: {3}", idAgenda, nombre, apellido, fechaNacimiento);

                        resultados.Add(resultado);
                    }
                }
            }
            
            return resultados;


        }

        public int validar(string nombres, string pass)
        {


            string[] vali = new string[1];
            string usuario="";
            string password;
            int nivel = 0;
                // Crea la consulta SELECT.
                string query = "SELECT usario, password,nivel FROM usuario WHERE usario=@nombres AND password=@pass";

                // Crea el objeto SqlCommand con la consulta y los parámetros.
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@nombres", nombres);
                    command.Parameters.AddWithValue("@pass", pass);

                    // Abre la conexión y ejecuta la consulta.
                   
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Itera a través de los resultados y realiza alguna acción.
                        while (reader.Read())
                        {
                             usuario = reader.GetString(0);
                             password = reader.GetString(1);
                        try
                        {
                            nivel = reader.GetInt32(2);
                        }
                        catch (Exception e)
                        {

                        }
                            
                            //Console.WriteLine("Usuario: {0}, Password: {1}", usuario, password);

                       
                        }

                    }
                }
            MessageBox.Show(usuario);
           


            return nivel;

        }

        public void insertU(createU agenda)
        {

            MessageBox.Show("Conectado");

            string come = "Bienvenido";

            MessageBox.Show(come);

            string query = "insert into usuario (usario,password)values(@username, @password)"; ;
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                // Asignar los valores a los parámetros del comando
                command.Parameters.AddWithValue("@username", agenda.username);
                command.Parameters.AddWithValue("@password", agenda.password);

                // Ejecutar el comando
                command.ExecuteNonQuery();
            }
            



            conn.Close();
            MessageBox.Show("cerrando....");
        }



        public void update(agendaDTO agenda)
        {
            MessageBox.Show("Conectado");
            string query = "UPDATE merca SET nombre = @nombre, cantidad = @cantidad, distribuidora = @distribuidora WHERE id = @id";

            // Crear el comando para ejecutar el query de actualización
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                // Asignar los valores a los parámetros del comando
                command.Parameters.AddWithValue("@nombre", agenda.Nombre);
                command.Parameters.AddWithValue("@cantidad", agenda.cantidad);
                command.Parameters.AddWithValue("@distribuidora", agenda.provedores);
                command.Parameters.AddWithValue("@id", agenda.id);

                // Ejecutar el comando
                command.ExecuteNonQuery();
            }



            
            MessageBox.Show("cerrando...");
        }
    }
}
