using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Employee
{
    public class Class1
    {
        #region CS
        string cs;
        SqlConnection sql;

        public Class1()
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
        #endregion

        #region GET
        public SqlDataReader GetEmployee()
        {
            string select = "SELECT * FROM Employee";
            SqlCommand com = new SqlCommand(select, sql);
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }
        #endregion

        #region ADD
        public void AddEmployee(int EmployeeID, string Password, string LN, string FN, string MN, string Address, string ContactNo, string TelNo, string Position, string Email)
        {
            string add = "INSERT INTO Employee(EmployeeID, Password, LN, FN, MN, Address, ContactNo, TelNo, Position, Email) VALUES ('" + EmployeeID + "','" + Password + "','" + LN + "','" + FN + "','" + MN + "','" + Address + "','" + ContactNo + "','" + TelNo + "','" + Position + "','" + Email + "')";
            
            SqlCommand com = new SqlCommand(add, sql);
            com.ExecuteNonQuery();
            com.Dispose();            
        }
        #endregion

        #region EDIT
        public void EditEmployee(int EmployeeID, string Password, string LN, string FN, string MN, string Address, string ContactNo, string TelNo, string Postion, string Email)
        {
            string edit = "UPDATE Employee ";
            edit += "SET Password = '" + Password + "', ";
            edit += "LN = '" + LN + "', ";
            edit += "FN = '" + FN + "', ";
            edit += "Address = '" + Address + "', ";
            edit += "ContactNo = '" + ContactNo + "', ";
            edit += "TelNo = '" + TelNo + "', ";
            edit += "Position = '" + Postion + "', ";
            edit += "Email = '" + Email + "' ";
            edit += "WHERE EmployeeID = " + EmployeeID;
            SqlCommand com = new SqlCommand(edit, sql);
            com.ExecuteNonQuery();
            com.Dispose();
        }
        #endregion

        #region DELETE
        public void DeleteEmployee(int EmployeeID)
        {
            string remove = "DELETE FROM Employee ";
            remove += "WHERE EmployeeID = " + EmployeeID;
            SqlCommand removed = new SqlCommand(remove, sql);
            removed.ExecuteNonQuery();
        }
        #endregion
    }
}