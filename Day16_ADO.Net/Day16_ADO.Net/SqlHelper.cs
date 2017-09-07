using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

// Interaction with the database
namespace Day16_ADO.Net
{
    public class SqlHelper
    {
        private SqlConnection _sqlConnection;          //Connection Object
        private SqlCommand _sqlCommand;                //To fire Query
        private SqlDataAdapter _sqlDataAdapter;
        public string sqlQuery = null;
        public string conString = @"Data Source=.\SQLExpress;Initial Catalog=StudentDemo;Integrated Security=True;Pooling=False";     // Data source

            

        public SqlHelper()
        {
            _sqlConnection = new SqlConnection(conString);
            if(_sqlConnection.State==System.Data.ConnectionState.Closed)
            {
                _sqlConnection.Open();                               //open connection
                Console.WriteLine("Connection is open\n");
            }


            
        }

        public SqlDataReader ExecuteQuery(string sqlQuery)
        {
            _sqlCommand = new SqlCommand(sqlQuery,_sqlConnection);
           // _sqlCommand.CommandText = sqlQuery;
           // _sqlCommand.Connection = _sqlConnection;
            return _sqlCommand.ExecuteReader();
        }

        public string ExecuteScalar(string sqlQuery)
        {
            _sqlCommand = new SqlCommand(sqlQuery, _sqlConnection);
            return _sqlCommand.ExecuteScalar().ToString();
        }

        public bool ExecuteNonQuery(string sql)
        {
            var result = false;
            _sqlCommand = new SqlCommand(sql, _sqlConnection);
            var count = _sqlCommand.ExecuteNonQuery();
            result = count > 0 ? true : false;
            return result;
        }

        public DataTable GetDataSet(string sqlQuery)
        {
            var ds = new DataSet();
            _sqlDataAdapter = new SqlDataAdapter(sqlQuery,conString);
            _sqlDataAdapter.Fill(ds, "stud");
            return ds.Tables[0];
        }

        public void update()
        {
            string sqlQuery = "select * from [Table]";
            var ds = new DataSet();
            _sqlDataAdapter = new SqlDataAdapter(sqlQuery, conString);
            SqlCommandBuilder sb = new SqlCommandBuilder(_sqlDataAdapter);
            _sqlDataAdapter.Fill(ds, "stud");
            DataTable dt = ds.Tables[0];
            dt.Rows[0][0] = 1;
            dt.Rows[0][1] = "S";
            dt.Rows[0][2] = 58;
            _sqlDataAdapter.Update(dt);
        }

        public void updateName()
        {
            string sqlQuery = "select * from [Table]";
            var ds = new DataSet();
            _sqlDataAdapter = new SqlDataAdapter(sqlQuery, conString);
            SqlCommandBuilder sb = new SqlCommandBuilder(_sqlDataAdapter);
            _sqlDataAdapter.Fill(ds, "stud");
            DataTable dt = ds.Tables[0];

            for(int i=0;i<dt.Rows.Count;i++)
            {
                if(dt.Rows[i][1].Equals("pooja"))
                {
                    dt.Rows[i][1] = "Snehaaaaaa";
                    dt.Rows[i][2] = 58;
                }
            }

         
            
            _sqlDataAdapter.Update(dt);
        }

       
    }
}
