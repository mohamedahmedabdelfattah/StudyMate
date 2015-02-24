using System;
using System.Data;
using System.Data.SqlClient;

namespace StudyMate
{
    class DBAccess
    {
        SqlConnection Connection = new SqlConnection(Properties.Settings.Default.StudyMateConnectionString);
        SqlCommand Command = new SqlCommand();

        string _error = "";

        public string error
        {
            get { return _error; }
            set { _error = value; }
        }

        string _LoginUserName;

        public string LoginUserName
        {
            get { return _LoginUserName; }
            set { _LoginUserName = value; }
        }

        string _LoginPassword;

        public string LoginPassword
        {
            get { return _LoginPassword; }
            set { _LoginPassword = value; }
        }

        public string Get(string query,string column)
        {
            string result = "";

            SqlCommand Command = new SqlCommand(query,Connection);

            Connection.Open();

            SqlDataReader reader = Command.ExecuteReader();

            while (reader.Read())
            {
                result = reader[column].ToString();
            }
            reader.Close();

            Connection.Close();

            return result;
        }

        public Boolean SignUp(string UserName, string Password)
        {
            try
            {
                Command.Connection = Connection;

                if (Get("SELECT UserName FROM UsersList WHERE UserName = '" + UserName + "'", "UserName") != UserName)
                {
                    SqlParameter param_UserName = new SqlParameter("@UserName", SqlDbType.VarChar);
                    param_UserName.Direction = ParameterDirection.Input;
                    param_UserName.Value = Password;
                    Command.Parameters.Add(param_UserName);

                    SqlParameter param_Password = new SqlParameter("@Password", SqlDbType.VarChar);
                    param_Password.Direction = ParameterDirection.Input;
                    param_Password.Value = UserName;
                    Command.Parameters.Add(param_Password);

                    Command.CommandText = ("INSERT INTO [UsersList] (UserName,Password) VALUES (@UserName,@Password)");

                    Connection.Open();
                    Command.ExecuteNonQuery();
                    Connection.Close();
                }
                else
                {
                    error = "Username "+ UserName + " is already registered.";
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            if (error == "")
                return true;
            else
                return false;
        }

        public Boolean LogIn()
        {
            string StoredPassword = "", StoredUserName = "";

            // Check UserName and Password
            StoredUserName = Get("SELECT UserName FROM UsersList WHERE UserName = '" + LoginUserName + "'","UserName");
            StoredPassword = Get("SELECT Password FROM UsersList WHERE Password = '" + LoginPassword + "'", "Password");

            // Set Authorization
            if (LoginPassword == StoredPassword && LoginUserName == StoredUserName)
                return true;
            else
                return false;
        }

        public Boolean SendBug(string AppVersion, string Category, string Description)

        {
            try
            {
                int ID = 0;

                Command.Connection = Connection;
                Command.CommandText = ("SELECT COUNT(ID) AS ID FROM BugsList");

                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                while (reader.Read())
                {
                    ID = (int)reader["ID"];
                }

                reader.Close();
                Connection.Close();

                SqlParameter param_ID = new SqlParameter("@ID", SqlDbType.Int);
                param_ID.Direction = ParameterDirection.Input;
                param_ID.Value = ID++;
                Command.Parameters.Add(param_ID);

                SqlParameter param_AppVersion = new SqlParameter("@AppVersion", SqlDbType.VarChar);
                param_AppVersion.Direction = ParameterDirection.Input;
                param_AppVersion.Value = AppVersion;
                Command.Parameters.Add(param_AppVersion);

                SqlParameter param_Description = new SqlParameter("@Description", SqlDbType.VarChar);
                param_Description.Direction = ParameterDirection.Input;
                param_Description.Value = Description;
                Command.Parameters.Add(param_Description);

                SqlParameter param_Category = new SqlParameter("@Category", SqlDbType.VarChar);
                param_Category.Direction = ParameterDirection.Input;
                param_Category.Value = Category;
                Command.Parameters.Add(param_Category);

                Command.CommandText = ("INSERT INTO [BugsList] ([ID],[AppVersion],[Category],[Description]) VALUES (@ID,@AppVersion,@Category,@Description)");

                Connection.Open();
                Command.ExecuteNonQuery();
                Connection.Close();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            if (error == "")
                return true;
            else
                return false;
        }

        public Boolean AddOther(string Author, string Name, string Category, string Link, string Comment)
        {
            try
            {
                Command.Connection = Connection;

                SqlParameter param_Name = new SqlParameter("@Name", SqlDbType.VarChar);
                param_Name.Direction = ParameterDirection.Input;
                param_Name.Value = Name;
                Command.Parameters.Add(param_Name);

                SqlParameter param_Author = new SqlParameter("@Author", SqlDbType.VarChar);
                param_Author.Direction = ParameterDirection.Input;
                param_Author.Value = Author;
                Command.Parameters.Add(param_Author);

                SqlParameter param_Category = new SqlParameter("@Category", SqlDbType.VarChar);
                param_Category.Direction = ParameterDirection.Input;
                param_Category.Value = Category;
                Command.Parameters.Add(param_Category);

                SqlParameter param_Link = new SqlParameter("@Link", SqlDbType.VarChar);
                param_Link.Direction = ParameterDirection.Input;
                param_Link.Value = Link;
                Command.Parameters.Add(param_Link);

                SqlParameter param_Comment = new SqlParameter("@Comment", SqlDbType.VarChar);
                param_Comment.Direction = ParameterDirection.Input;
                param_Comment.Value = Comment;
                Command.Parameters.Add(param_Comment);

                Command.CommandText = ("INSERT INTO [DataList] ([Name],[Author],[Category],[Link],[Comment]) VALUES (@Name,@Author,@Category,@Link,@Comment)");

                Connection.Open();
                Command.ExecuteNonQuery();
                Connection.Close();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            if (_error == "")
                return true;
            else
                return false;
        }

    }
}