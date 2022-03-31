using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//1
using System.Data.SqlClient;

namespace KasirBaru_Pertemuan7
{
	public class Koneksi
	{
		public SqlConnection GetConn(){
			SqlConnection Conn = new SqlConnection();
			Conn.ConnectionString = "Data Source=DESKTOP-15TBTTA; initial catalog=Kasir; integrated security=true";
			return Conn;
       	} 
	}
}
