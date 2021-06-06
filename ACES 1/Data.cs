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
			MySqlConnection connection;
			connection = getConnection();
			connection.Open();
			MySqlDataAdapter adtr = null;
			try
			{
				adtr = new MySqlDataAdapter(sql, connection);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			connection.Close();
			return adtr;
		}





	}

}
