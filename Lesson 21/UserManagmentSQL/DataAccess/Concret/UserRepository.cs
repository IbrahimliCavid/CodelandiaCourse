
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagmentSQL.DataAccess.Abstract;
using UserManagmentSQL.DataAccess.SqlDbContex;
using UserManagmentSQL.DefaultValues;
using UserManagmentSQL.Entity;




namespace UserManagmentSQL.DataAccess.Concret
{
    public class UserRepository : IUserRepository
    {
        private string _connection;

        public UserRepository()
        {
            _connection = SqlDataBaseConnect.Connect();
        }

        public void Add(User entity)
        {

            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();

                string cmdTxt = @"insert into Users(Name, UserName, Email, Password, RoleID)
                                  values (@Name, @UserName,@Email, @Password, @RoleID)";



                using (SqlCommand cmd = new SqlCommand(cmdTxt, connection))
                {

                    cmd.Parameters.AddWithValue("@Name", entity.Name);
                    cmd.Parameters.AddWithValue("@UserName", entity.UserName);
                    cmd.Parameters.AddWithValue("@Email", entity.Email);
                    cmd.Parameters.AddWithValue("@Password", entity.Password);
                    cmd.Parameters.AddWithValue("@RoleID", entity.Role);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();

                string cmdText = @"update  users 
                                   set IsDeleted = @ID 
                                   where Id = @ID";
                using (SqlCommand cmd = new SqlCommand(cmdText, connection))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();

                }
            }
        }

        public User Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                string cmdText = @"select  * from users 
                                   where Id = @ID";

                using (SqlCommand cmd = new SqlCommand(cmdText, connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    User user = new();

                    if (reader.Read())
                    {
                        cmd.Parameters.AddWithValue("@ID", id);

                        user.Id = Convert.ToInt32(reader["ID"]);
                        user.Name = Convert.ToString(reader["Name"]);
                        user.UserName = Convert.ToString(reader["UserName"]);
                        user.Email = Convert.ToString(reader["Email"]);
                        user.Password = Convert.ToString(reader["Password"]);
                        user.Role = Convert.ToInt32(reader["RoleID"]);
                        user.Deleted = Convert.ToInt32(reader["IsDeleted"]);
                        user.CreateDate = Convert.ToDateTime(reader["CreateDate"]);

                    }

                    return user;
                }
            }
        }

        public List<User> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                connection.Open();
                string cmdText = "select  * from users";

                using (SqlCommand cmd = new SqlCommand(cmdText, connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<User> userList = new();

                    while (reader.Read())
                    {
                        User user = new User()
                        {
                            Id = Convert.ToInt32(reader["ID"]),
                            Name = Convert.ToString(reader["Name"]),
                            UserName = Convert.ToString(reader["UserName"]),
                            Email = Convert.ToString(reader["Email"]),
                            Password = Convert.ToString(reader["Password"]),
                            Role = Convert.ToInt32(reader["RoleID"]),
                            Deleted = Convert.ToInt32(reader["IsDeleted"]),
                            CreateDate = Convert.ToDateTime(reader["CreateDate"])
                        };
                        userList.Add(user);
                    }

                    return userList;
                }

            }
        }

        public void Update(User entity)
        {
            using (SqlConnection connection = new(_connection))
            {
                connection.Open();

                string cmdText = @"update  users 
                                   set Name = @Name, 
                                       UserName = @UserName, 
                                       Email = @Email,  
                                       Password = @Password,  
                                       RoleID = @RoleID,  
                                       IsDeleted = IsDeleted
                                   where Id = @ID";

                using (SqlCommand cmd = new(cmdText, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", entity.Name);
                    cmd.Parameters.AddWithValue("@UserName", entity.UserName);
                    cmd.Parameters.AddWithValue("@Email", entity.Email);
                    cmd.Parameters.AddWithValue("@Password", entity.Password);
                    cmd.Parameters.AddWithValue("@RoleID", entity.Role);
                    cmd.Parameters.AddWithValue("@IsDeleted", entity.Deleted);
                    cmd.Parameters.AddWithValue("@ID", entity.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
