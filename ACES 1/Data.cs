using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ACES_1
{
    public class Data
    {
		public MySqlConnection getConnection()
		{
			MySqlConnection connection = null;
			try
			{
				connection = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=diyetveri_050621");
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			return connection;
		}

		public MySqlDataAdapter getAdapter(string sql)
		{
			
			MySqlDataAdapter adtr = null;
			MySqlConnection connection = null;
			connection = getConnection();
			connection.Open();
			try
			{
				adtr = new MySqlDataAdapter(sql, connection);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			return adtr;
		}
		public MySqlCommand getCommand(string sql)
		{

			MySqlCommand command= null;
			MySqlConnection connection = null;
			connection = getConnection();
			connection.Open();
			try
			{
				command = new MySqlCommand(sql, connection);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			return command;
		}





	}

}
