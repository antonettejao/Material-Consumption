using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Material_Consumption
{
    public class Register
    {
        string cs;
        SqlConnection sql;

        public Register()
        {
            cs = "SERVER=Chelo-PC; DATABASE=Dentista, Inc.; UID=chelo; INTEGRATED SECURITY=TRUE";
            sql = new SqlConnection(cs);
        }

            public void Open()
        {
            sql.Open();
        }

        public void Close()
        {
            sql.Close();
        }

        public SqlDataReader GetEmployee()
        {
            string select = "SELECT * FROM Employee";
            SqlCommand com = new SqlCommand(select, sql);
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }

        public void AddEmployee(int eid, string pwd, string ln, string fn, string mn, string address, string cno, string telno, string pstn, string eadd)
        {
            string add = "INSERT INTO Employee(EmployeeID, Password, LN, FN, MN, Address, ContactNo, TelNo, Position, Email) VALUES ('" + eid + "','" + pwd + "','" + ln + "','" + fn + "','" + mn + "','" + address + "','" + cno + "','" + telno + "','" + pstn + "','" + eadd + "')";

            SqlCommand com = new SqlCommand(add, sql);
            com.ExecuteNonQuery();
            com.Dispose();
        }
    }
}