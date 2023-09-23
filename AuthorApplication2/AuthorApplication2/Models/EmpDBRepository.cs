using Microsoft.Data.SqlClient;
using System.Data;

namespace AuthorApplication2.Models
{
    public class EmpDBRepository
    {
        public static List<Emptbl> GetEmpList()
        {
            List<Emptbl> emplist = new List<Emptbl>();
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != System.Data.ConnectionState.Open)
                    cn.Open();


                SqlCommand selectempcmd = cn.CreateCommand();
                String selectAllEmps = "Select * from emptbl";
                selectempcmd.CommandText = selectAllEmps;
                SqlDataReader empdr = selectempcmd.ExecuteReader();
                while (empdr.Read())
                {
                    Emptbl emp = new Emptbl
                    {
                        Id = empdr.GetInt32(0),
                        Name = empdr.GetString(1),
                        Salary = empdr.GetDecimal(2),
                        City = empdr.GetString(3)

                    };
                    emplist.Add(emp);
                }
            }

            return emplist;

        }
        public static Emptbl GetEmpID(int id)
        {
            Emptbl empFound = null;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != System.Data.ConnectionState.Open)
                    cn.Open();


                SqlCommand selectempcmd = cn.CreateCommand();
                String selectEmp = "Select * from emptbl where eno=@id";
                selectempcmd.Parameters.Add("@id",SqlDbType.Int).Value = id;
                selectempcmd.CommandText = selectEmp;
                SqlDataReader empdr = selectempcmd.ExecuteReader();
                while (empdr.Read())
                {
                    empFound = new Emptbl
                    {
                        Id = empdr.GetInt32(0),
                        Name = empdr.GetString(1),
                        Salary = empdr.GetDecimal(2),
                        City = empdr.GetString(3)

                    };
                   
                }
            }

            return empFound;


        }
        public static int AddNewEmp(Emptbl newEmp)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand insertEmpcmd = cn.CreateCommand();
                String insertNewEmpQuery = "insert into emptbl values( @id,@name,@salary,@city )";
                insertEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = newEmp.Id;
                insertEmpcmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = newEmp.Name;
                insertEmpcmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = newEmp.Salary;
                insertEmpcmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = newEmp.City;
                insertEmpcmd.CommandText = insertNewEmpQuery;
                query_result = insertEmpcmd.ExecuteNonQuery(); // insert stmt is a non-query - it is a reader 
            }
            return query_result; // no of rows inserted
        }

        public static int DeleteEmp(int id)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand deleteEmpcmd = cn.CreateCommand();
                String deleteEmpQuery = "Delete from emptbl where eno=@id";
                deleteEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                deleteEmpcmd.CommandText = deleteEmpQuery;
                query_result = deleteEmpcmd.ExecuteNonQuery();
            }
            return query_result;
        }
        public static int UpdateEmp(Emptbl modifiedEmp)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand updateEmpcmd = cn.CreateCommand();
                String updateEmpQuery = "Update emptbl set name=@name, salary=@salary, city=@city where eno=@id";
                updateEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = modifiedEmp.Id;
                updateEmpcmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = modifiedEmp.Name;
                updateEmpcmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = modifiedEmp.Salary;
                updateEmpcmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = modifiedEmp.City;
                updateEmpcmd.CommandText = updateEmpQuery;
                query_result = updateEmpcmd.ExecuteNonQuery();
            }
            return query_result;
        }
    }
}
