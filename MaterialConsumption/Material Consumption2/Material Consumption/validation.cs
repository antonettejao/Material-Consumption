    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;



namespace Material_Consumption
{
    public class validation
    {

        private string ln;
        public string LN
        {
            get { return ln; }
            set
            {
                int i = 0;
                bool blnTry = false;
                while (i < value.Length && !blnTry)
                {
                    char tmpChar = value[i];
                    int intTry = 0;
                    blnTry = int.TryParse(tmpChar.ToString(), out intTry);

                    i++;
                }
                if (!blnTry)
                    ln = value;
                else
                    ln = "";

                if (value.Length < 2)
                {
                    throw new Exception(
                        "Lastname must be " +
                        "at least 2 characters " +
                        "long.");
                }
                if (value.Length > 50)
                {
                    throw new Exception(
                        "Lastname must not " +
                        "exceed 50 characters.");
                }

                ln = value;
            }
        }


        private string fn;
        public string FN
        {
            get { return fn; }
            set
            {
                int i = 0;
                bool blnTry = false;
                while (i < value.Length && !blnTry)
                {
                    char tmpChar = value[i];
                    int intTry = 0;
                    blnTry = int.TryParse(tmpChar.ToString(), out intTry);

                    i++;
                }
                if (!blnTry)
                    ln = value;
                else
                    fn = "";

                if (value.Length < 1)
                {
                    throw new Exception(
                        "Firstname must be " +
                        "at least 1 character " +
                        "long.");
                }
                if (value.Length > 50)
                {
                    throw new Exception(
                        "Firstname must not " +
                        "exceed 50 characters.");
                }

                fn = value;
            }
        }

        private string mn;
        public string MN
        {
            get { return mn; }
            set
            {
                int i = 0;
                bool blnTry = false;
                while (i < value.Length && !blnTry)
                {
                    char tmpChar = value[i];
                    int intTry = 0;
                    blnTry = int.TryParse(tmpChar.ToString(), out intTry);

                    i++;
                }
                if (!blnTry)
                    ln = value;
                else
                    mn = "";

                if (value.Length > 50)
                {
                    throw new Exception(
                        "Lastname must not " +
                        "exceed 50 characters.");
                }

                mn = value;
            }
        }

        private string pwd;
        public string PWD
        {
            get { return ln; }
            set
            {

                if (value.Length < 2)
                {
                    throw new Exception(
                        "Password must be " +
                        "at least 8 characters " +
                        "long.");
                }
                if (value.Length > 50)
                {
                    throw new Exception(
                        "Password must be " +
                        "at least 8 characters " +
                        "long.");
                }

                pwd = value;
            }
        }

        private int eid;
        public int EID
        {
            get
            {
                return eid;
            }
            set
            {
                if (value < 1000000)
                {
                    throw new Exception(
                        "EmployeeID must be 7 digits long");
                }
                if (value < 9000000)
                {
                    throw new Exception(
                        "EmployeeID must begin with 2");
                }
                eid = value;
            }
        }

        private string add;
        public string Add
        {
            get { return add; }
            set
            {
                if (value.Length > 50)
                {
                    throw new Exception(
                        "Address cannot exceed 50 " +
                        "characters");
                }
                add = value;
            }
        }

        private int cno;
        public int CNO
        {
            get { return cno; }
            set
            {
                if (value > 0)
                {
                    cno = value;

                    throw new Exception(
                    "Contact number cannot exceed 50 " +
                    "characters");
                }
                else
                    cno = 1;
            }
        }

        private int tno;
        public int TNO
        {
            get { return tno; }
            set
            {
                if (value > 0)
                {
                    tno = value;

                    throw new Exception(
                    "Telephone number cannot exceed 50 " +
                    "characters");
                }
                else
                    tno = 1;
            }
        }

        private string ead;
        public string EAD
        {
            get { return ead; }
            set
            {

                if (value.Length < 2)
                {
                    throw new Exception(
                        "Password must be " +
                        "at least 8 characters " +
                        "long.");
                }
                if (value.Length > 50)
                {
                    throw new Exception(
                        "Password must be " +
                        "at least 8 characters " +
                        "long.");
                }

                ead = value;
            }
        }


        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value > 0)
                {

                    quantity = value;

                    throw new Exception(
                        "Quantity must be " +
                        "numbers " +
                        "only.");
                }
                else
                    quantity = 1;
            }
        }

        DateTime date;
        public DateTime Date
        {
            get { return date; }
            set
            {
                if (value > DateTime.Now)
                {
                    date = value;

                    throw new Exception(
                        "Expiration Date must be " +
                        "after " +
                        "today.");
                }
                else
                    date = DateTime.Now.AddDays(1);

            }
        }
    }
}



                