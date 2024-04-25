using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;

namespace InitialSqlInC_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
            connectionStringBuilder.DataSource = "localhost";
            connectionStringBuilder.InitialCatalog = "BookDb";
            connectionStringBuilder.IntegratedSecurity = true;
            string connectionString = connectionStringBuilder.ConnectionString;

         
            Console.WriteLine("1 - Add Author 2 - View Author 3 - Add Book");
            while (true)
            {
                if ( int.TryParse(Console.ReadLine(), out int button))
                {
                    switch (button)
                    {
                        case 1:
                            AddAuthors(connectionString);
                            break;
                        case 2:
                            ViewAllAuthors(connectionString);
                            break;
                        case 3:
                            AddAuthors(connectionString);
                            break;
                        case 0:
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Please enter true button");
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter true button");
                }
                
            }

         
        }

        public static void AddAuthors(string connectionString)
        {
            Console.WriteLine("\n\nPlease enter author name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter author surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Please enter author email: ");
            string email = Console.ReadLine();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string cmdText = $"insert into Authors values (N'@{name}', N'@{surname}', '@{email}')";

                using (SqlCommand command = new SqlCommand(cmdText, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@surname", name);
                    command.Parameters.AddWithValue("@email", name);
                    command.ExecuteNonQuery();
                    Console.WriteLine("Author succesfuly added!!!");
                }
            }
        }

        public static void ViewAllAuthors(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string cmdText = $"Select * from Authors";

                using (SqlCommand command = new SqlCommand(cmdText, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    Console.WriteLine("\n");
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string surname = reader.GetString(2);
                        string email = reader.GetString(3);
                        Console.WriteLine($"{id}  {name} {surname}  {email}");
                    }
                }
            }
        }

        public static void AddBooks(string connectionString)
        {
            ViewAllAuthors(connectionString);
            Console.WriteLine("\n\nPlease enter book name");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter book page");
            short pageOfBook = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please enter  author id");
            int authorId = int.Parse(Console.ReadLine());


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string cmdText = $"insert into Books values (N'{@name}', @authorID, @pageOfBook)";

                using (SqlCommand command = new SqlCommand(cmdText, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@authorID", authorId);
                    command.Parameters.AddWithValue("@pageOfBook", pageOfBook);
                    command.ExecuteNonQuery();
                    Console.WriteLine("Book succesfuly added!!!");
                }
            }
        }

        public static void Update()
        {

        }
    }
}
