using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CRUDAJAX.Models
{
    public class EmployeeDB
    {
        string cs = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;

        //returen list all employee
        public List<Employee> listAll()
        {
            List<Employee> lst = new List<Employee>();
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select_Employee",con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rd = cmd.ExecuteReader();
                while(rd.Read())
                {
                    lst.Add(new Employee
                    {
                        Eid = Convert.ToInt32(rd["EId"]),
                        Ename = rd["Ename"].ToString(),
                        EEmail = rd["EEmail"].ToString(),
                        EPassword = rd["EPassword"].ToString(),
                        EGender = rd["EGender"].ToString()
                    }) ;
                }
                return lst;
            }
        }





    }
}