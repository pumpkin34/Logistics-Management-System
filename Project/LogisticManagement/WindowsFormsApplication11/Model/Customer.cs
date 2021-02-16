using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication11
{
    class Customer
    {
        int _idCustomer;
        String _customerName;
        String _customerSurname;
        String _customerPhone;

        public int IdCustomer
        {
            get
            {
                return _idCustomer;
            }

            set
            {
                _idCustomer = value;
            }
        }

        public string CustomerName
        {
            get
            {
                return _customerName;
            }

            set
            {
                _customerName = value;
            }
        }

        public string CustomerSurname
        {
            get
            {
                return _customerSurname;
            }

            set
            {
                _customerSurname = value;
            }
        }

        public string CustomerPhone
        {
            get
            {
                return _customerPhone;
            }

            set
            {
                _customerPhone = value;
            }
        }

        public Customer()
        { }

        public static List<Customer> GetCustomer(int? idCustomer)
        {
            try
            {
                SqlParameter[] parameters =
                                            {
                                                new SqlParameter("@IdCustomer", SqlDbType.Int) { Value = idCustomer}
                                             };

                return TableToList(SQLHelper.ExecuteDataset(GlobalVars.DBConn, CommandType.StoredProcedure, "[dbo].[SelectCustomerByID]", parameters).Tables[0]);


            }
            catch (Exception e)
            {
                return null;
            }

        }

        public static bool InsertCustomer(Customer c)
        {
            try
            {
                SqlParameter[] parameters =
                                            {
                                                new SqlParameter("@Name", SqlDbType.NVarChar) { Value = c.CustomerName},
                                                new SqlParameter("@Surname", SqlDbType.NVarChar) { Value = c.CustomerSurname},
                                                new SqlParameter("@Number", SqlDbType.NVarChar) { Value = c.CustomerPhone},

                                                new SqlParameter("@IdCustomer", SqlDbType.Int) { Direction = ParameterDirection.ReturnValue}
                                             };

                SQLHelper.ExecuteScalar(GlobalVars.DBConn, CommandType.StoredProcedure, "[dbo].[InsertCustomer]", parameters);
                c.IdCustomer = Convertions.ParseToIntOrZero(parameters[3].Value.ToString());
                return Convertions.ParseToValidBoolean(c.IdCustomer.ToString());

            }
            catch (Exception e)
            {
                return false;
            }

        }

        public static bool UpdateCustomer(Customer c)
        {
            try
            {
                SqlParameter[] parameters =
                                            {
                                                new SqlParameter("@IdCustomer", SqlDbType.Int) { Value = c.IdCustomer},
                                                new SqlParameter("@Name", SqlDbType.NVarChar) { Value = c.CustomerName},
                                                new SqlParameter("@Surname", SqlDbType.NVarChar) { Value = c.CustomerSurname},
                                                new SqlParameter("@Number", SqlDbType.NVarChar) { Value = c.CustomerPhone}
                                             };

                SQLHelper.ExecuteScalar(GlobalVars.DBConn, CommandType.StoredProcedure, "[dbo].[UpdateCustomer]", parameters);
                return true;


            }
            catch (Exception e)
            {
                return false;
            }

        }

        public static bool DeleteCustomerById(int id)
        {
            try
            {
                SqlParameter[] parameters =
                                            {
                                                 new SqlParameter("@IdCustomer", SqlDbType.Int) { Value = id}
                                             };
                SQLHelper.ExecuteScalar(GlobalVars.DBConn, CommandType.StoredProcedure, "[dbo].[DeleteCustomerByID]", parameters);
                return true;

            }
            catch (Exception e)
            {
                return false;
            }

        }

        private static List<Customer> TableToList(DataTable _dataTable)
        {
            List<Customer> _lstCustomers = new List<Customer>();

            for (int i = 0; i <= _dataTable.Rows.Count - 1; i++)
            {
                Customer _c = new Customer();

                _c.IdCustomer = Convert.ToInt32(_dataTable.Rows[i]["ID_Customer"].ToString());
                _c.CustomerName = _dataTable.Rows[i]["Customer_Name"].ToString();
                _c.CustomerSurname = _dataTable.Rows[i]["Customer_Surname"].ToString();
                _c.CustomerPhone = _dataTable.Rows[i]["Phone_Number"].ToString();

                _lstCustomers.Add(_c);
            }

            return _lstCustomers;

        }
    }
}
