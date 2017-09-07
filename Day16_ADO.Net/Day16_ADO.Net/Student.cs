using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Logical Part
namespace Day16_ADO.Net
{
    public class Student
    {
        public SqlHelper sqlHelper;
        private string sqlQuery = null;
        private string sqlQuery1 = null;
        private string sqlQuery2 = null;

        public  Student()
        {
            sqlHelper = new SqlHelper();
        }

        public void Getdata()
        {
            sqlQuery = "select * from [Table]";
            var sqlReader = sqlHelper.ExecuteQuery(sqlQuery);
            


            while (sqlReader.Read())                 //Reading data row and increment
            {
                
                Console.WriteLine(string.Format(" Roll no {0}\n Student Name {1}\n Marks {2}\n Contact {3}", sqlReader[0], sqlReader[1], sqlReader[2], sqlReader[3]));
                
            }
            sqlReader.Close();


            sqlQuery1 = "select COUNT(StudName) from [Table]";

            var sqlReader1 = sqlHelper.ExecuteScalar(sqlQuery1);
            
            Console.WriteLine("\n No Of Rows : {0}", sqlReader1);
            
        }


        public void SaveData()
        {
            Console.WriteLine("Enter Roll no");
            string rno = Console.ReadLine();
            sqlQuery2 = string.Format(@"insert into[Table] values" + "({0},'pooja', 68, '9258741236')",rno);
            bool sqlReader = sqlHelper.ExecuteNonQuery(sqlQuery2);
            
            Console.WriteLine("\n Record Inserted: {0}", sqlReader);
        }

        public void getDataSet()
        {
            sqlQuery = "select * from [Table]";
            DataTable dt = sqlHelper.GetDataSet(sqlQuery);

            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine(string.Format(" Roll no {0}\n Student Name {1}\n Marks {2}\n Contact {3}", dr[0], dr[1], dr[2], dr[3]));
            }

            dt.WriteXml("StudentDataSet.xls");
        }

        public void update()
        {
            sqlHelper.updateName();
        }

        public void delete()
        {
            sqlQuery = "delete from [Table] where (StudName='pooja')";
            
            bool sqlReader = sqlHelper.ExecuteNonQuery(sqlQuery);


            Console.WriteLine("\n Record Deleted: {0}", sqlReader);
        }
    }
}
