using System.Data.SqlClient;

// Establecer la conexión a la base de datos
string connectionString = "Data Source=nombre_del_servidor;Initial Catalog=nombre_de_la_bbdd;Integrated Security=True;";
SqlConnection connection = new SqlConnection(connectionString);

// Abrir la conexión
connection.Open();

// Crear el comando SQL para insertar el registro en la tabla
string query = "INSERT INTO nombre_de_la_tabla (campo1, campo2, campo3) VALUES (@valor1, @valor2, @valor3)";
SqlCommand command = new SqlCommand(query, connection);

// Establecer los valores de los parámetros del comando
command.Parameters.AddWithValue("@valor1", "valor_del_campo_1");
command.Parameters.AddWithValue("@valor2", "valor_del_campo_2");
command.Parameters.AddWithValue("@valor3", "valor_del_campo_3");

// Ejecutar el comando para insertar el registro
command.ExecuteNonQuery();

// Cerrar la conexión
connection.Close();
