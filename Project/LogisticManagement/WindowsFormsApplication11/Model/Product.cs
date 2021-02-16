using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication11
{
    class Product
    {
        int _idPackets;
        String _numberOfPeaces;
        int _idCustomer;
        String _sizeOfPeaces;
        String _totalWeight;
        String _customerName;
        String _customerSurname;
        String _customerPhone;

        public int IdPackets
        {
            get
            {
                return _idPackets;
            }

            set
            {
                _idPackets = value;
            }
        }

        public string NumberOfPeaces
        {
            get
            {
                return _numberOfPeaces;
            }

            set
            {
                _numberOfPeaces = value;
            }
        }

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

        public string SizeOfPeaces
        {
            get
            {
                return _sizeOfPeaces;
            }

            set
            {
                _sizeOfPeaces = value;
            }
        }

        public string TotalWeight
        {
            get
            {
                return _totalWeight;
            }

            set
            {
                _totalWeight = value;
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

        public Product()
        { }

        public static List<Product> GetProduct(int? idPacket)
        {
            try
            {

                return TableToList(SQLHelper.ExecuteDataset(GlobalVars.DBConn, CommandType.StoredProcedure, "[dbo].[SelectCustomerProductByID]", null).Tables[0]);


            }
            catch (Exception e)
            {
                return null;
            }

        }

        public static bool InsertProduct(Product p)
        {
            try
            {
                SqlParameter[] parameters =
                                            {
                                                new SqlParameter("@Number_of_Peaces", SqlDbType.NVarChar) { Value = p.NumberOfPeaces},
                                                new SqlParameter("@Size_of_Peaces", SqlDbType.NVarChar) { Value = p.SizeOfPeaces},
                                                new SqlParameter("@ID_Customer", SqlDbType.Int) { Value = p.IdCustomer},
                                                new SqlParameter("@Total_Weight", SqlDbType.NVarChar) { Value = p.TotalWeight},

                                                new SqlParameter("@IdPackets", SqlDbType.Int) { Direction = ParameterDirection.ReturnValue}
                                             };

                SQLHelper.ExecuteScalar(GlobalVars.DBConn, CommandType.StoredProcedure, "[dbo].[InsertProduct]", parameters);
                p.IdPackets = Convertions.ParseToIntOrZero(parameters[4].Value.ToString());
                return Convertions.ParseToValidBoolean(p.IdPackets.ToString());

            }
            catch (Exception e)
            {
                return false;
            }

        }

        public static bool UpdateProduct(Product p)
        {
            try
            {
                SqlParameter[] parameters =
                                            {
                                                new SqlParameter("@Id_Packets", SqlDbType.Int) { Value = p.IdPackets},
                                                new SqlParameter("@Number_of_Peaces", SqlDbType.NVarChar) { Value = p.NumberOfPeaces},
                                                new SqlParameter("@ID_Customer", SqlDbType.Int) { Value = p.IdCustomer},
                                                new SqlParameter("@Size_of_Peaces", SqlDbType.NVarChar) { Value = p.SizeOfPeaces},
                                                  new SqlParameter("@Total_Weight", SqlDbType.NVarChar) { Value = p.TotalWeight},
                                             };

                SQLHelper.ExecuteScalar(GlobalVars.DBConn, CommandType.StoredProcedure, "[dbo].[UpdateProduct]", parameters);
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
                                                 new SqlParameter("@IdPacket", SqlDbType.Int) { Value = id}
                                             };
                SQLHelper.ExecuteScalar(GlobalVars.DBConn, CommandType.StoredProcedure, "[dbo].[DeleteProductByID]", parameters);
                return true;

            }
            catch (Exception e)
            {
                return false;
            }

        }

        private static List<Product> TableToList(DataTable _dataTable)
        {
            List<Product> _lstProducts = new List<Product>();

            for (int i = 0; i <= _dataTable.Rows.Count - 1; i++)
            {
                Product _p = new Product();

                _p._idPackets = Convert.ToInt32(_dataTable.Rows[i]["ID_Packets"].ToString());
                _p._numberOfPeaces = _dataTable.Rows[i]["Number_of_Peaces"].ToString();
                _p.CustomerName = _dataTable.Rows[i]["Customer_Name"].ToString();
                _p.CustomerSurname = _dataTable.Rows[i]["Customer_Surname"].ToString();
                _p.CustomerPhone = _dataTable.Rows[i]["Phone_Number"].ToString();
                _p.SizeOfPeaces = _dataTable.Rows[i]["Size_of_Peaces"].ToString();
                _p._totalWeight = _dataTable.Rows[i]["Total_Weight"].ToString();


                _lstProducts.Add(_p);
            }

            return _lstProducts;

        }
    }
}

