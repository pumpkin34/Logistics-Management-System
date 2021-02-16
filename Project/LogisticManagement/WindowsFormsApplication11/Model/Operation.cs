using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication11

{
    class Operation
    {
        int _idOperation;
        public DateTime _dateStart;
        public DateTime _dateEnd;
        public int _idType;
        public int _idPackets;
        public int _idDriver;
        public String _destiation;
        public String _nameType, _driverName, _driverSurname, _driverPhone;//, _customerName, _customerSurname;

        public int IdOperation
        {
            get
            {
                return _idOperation;
            }

            set
            {
                _idOperation = value;
            }
        }

        public DateTime DateStart
        {
            get
            {
                return _dateStart;
            }

            set
            {
                _dateStart = value;
            }
        }
        public DateTime DateEnd
        {
            get
            {
                return _dateEnd;
            }

            set
            {
                _dateEnd = value;
            }
        }

      

        public int IDType
        {
            get
            {
                return _idType;
            }

            set
            {
                _idType = value;
            }
        }

        public String nameType
        {
            get
            {
                return _nameType;
            }

            set
            {
                _nameType = value;
            }
        }


        public int IDPackets
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

        public int IDDriver
        {
            get
            {
                return _idDriver;
            }

            set
            {
                _idDriver = value;
            }
        }

        public String DriverName
        {
            get
            {
                return _driverName;
            }

            set
            {
                _driverName = value;
            }
        }

        public String DriverSurname
        {
            get
            {
                return _driverSurname;
            }

            set
            {
                _driverSurname = value;
            }
        }

        public String DriverPhone
        {
            get
            {
                return _driverPhone;
            }

            set
            {
                _driverPhone = value;
            }
        }

        

        public String Destination
        {
            get
            {
                return _destiation;
            }

            set
            {
                _destiation = value;
            }
        }

        
        

        //public String CustomerName
        //{
        //    get
        //    {
        //        return _customerName;
        //    }

        //    set
        //    {
        //        _customerName = value;
        //    }
        //}

        //public String CustomerSurname
        //{
        //    get
        //    {
        //        return _customerSurname;
        //    }

        //    set
        //    {
        //        _customerSurname = value;
        //    }
        //}

        public Operation()
        { }

        public static List<Operation> GetOperation(int? idOperation)
        {
            try
            {
                SqlParameter[] parameters =
                                            {
                                                new SqlParameter("@idOperation", SqlDbType.Int) { Value = idOperation}
                                             };

                return TableToList(SQLHelper.ExecuteDataset(GlobalVars.DBConn, CommandType.StoredProcedure, "[dbo].[SelectMultipleTableByIDs]", parameters).Tables[0]);


            }
            catch (Exception e)
            {
                return null;
            }

        }

        public static bool InsertOperation(Operation o)
        {
            try
            {
                SqlParameter[] parameters =
                                            {
                                                new SqlParameter("@Date_Start", SqlDbType.DateTime) { Value = o.DateStart},
                                                new SqlParameter("@Date_End", SqlDbType.DateTime) { Value = o.DateEnd},
                                                new SqlParameter("@ID_Type", SqlDbType.Int) { Value = o.IDType},
                                                new SqlParameter("@ID_Packets", SqlDbType.Int) { Value = o.IDPackets},
                                                new SqlParameter("@ID_Driver", SqlDbType.Int) { Value = o.IDDriver},

                                                   new SqlParameter("@Destination", SqlDbType.NVarChar) { Value = o.Destination},


                                                new SqlParameter("@IdOperation", SqlDbType.Int) { Direction = ParameterDirection.ReturnValue}
                                             };

                SQLHelper.ExecuteScalar(GlobalVars.DBConn, CommandType.StoredProcedure, "[dbo].[InsertOperation]", parameters);
                o.IdOperation = Convertions.ParseToIntOrZero(parameters[6].Value.ToString());
                return Convertions.ParseToValidBoolean(o.IdOperation.ToString());

            }
            catch (Exception e)
            {
                return false;
            }

        }

        public static bool UpdateOperation(Operation o)
        {
            try
            {
                SqlParameter[] parameters =
                                            {
                                                new SqlParameter("@IdOperation", SqlDbType.Int) { Value = o.IdOperation},
                                                new SqlParameter("@Date_Start", SqlDbType.DateTime) { Value = o.DateStart},
                                                new SqlParameter("@Date_End", SqlDbType.DateTime) { Value = o.DateEnd},
                                                new SqlParameter("@ID_Type", SqlDbType.Int) { Value = o.IDType},
                                                  new SqlParameter("@ID_Packets", SqlDbType.Int) { Value = o.IDPackets},
                                                     new SqlParameter("@ID_Driver", SqlDbType.Int) { Value = o.IDDriver},
                                                        new SqlParameter("@Destination", SqlDbType.NVarChar) { Value = o.Destination}
                                             };

                SQLHelper.ExecuteScalar(GlobalVars.DBConn, CommandType.StoredProcedure, "[dbo].[UpdateOperation]", parameters);
                return true;


            }
            catch (Exception e)
            {
                return false;
            }

        }


        public static bool DeleteMainTableByID(int id)
        {
            try
            {
                SqlParameter[] parameters =
                                            {
                                                 new SqlParameter("@idOperation", SqlDbType.Int) { Value = id}
                                             };
                SQLHelper.ExecuteScalar(GlobalVars.DBConn, CommandType.StoredProcedure, "[dbo].[DeleteMainTableByID]", parameters);
                return true;

            }
            catch (Exception e)
            {
                return false;
            }

        }

        private static List<Operation> TableToList(DataTable _dataTable)
        {
            List<Operation> _lstOperations = new List<Operation>();

            for (int i = 0; i <= _dataTable.Rows.Count - 1; i++)
            {
                Operation _o = new Operation();

                _o.IdOperation = Convert.ToInt32(_dataTable.Rows[i]["ID_Operation"].ToString());
                _o.DateStart = Convert.ToDateTime(_dataTable.Rows[i]["Date_Start"].ToString());
                _o.DateEnd = Convert.ToDateTime(_dataTable.Rows[i]["Date_End"].ToString());
                _o.IDType = Convert.ToInt32(_dataTable.Rows[i]["ID_Type"].ToString());
                _o.nameType = _dataTable.Rows[i]["Name_Type"].ToString();
                _o.IDPackets = Convert.ToInt32(_dataTable.Rows[i]["ID_Packets"].ToString());
                _o.IDDriver = Convert.ToInt32(_dataTable.Rows[i]["ID_Driver"].ToString());
                _o.DriverName = _dataTable.Rows[i]["Driver_Name"].ToString();
                _o.DriverSurname = _dataTable.Rows[i]["Driver_Surname"].ToString();
                _o.DriverPhone = _dataTable.Rows[i]["Driver_Phone"].ToString();
                _o.Destination = _dataTable.Rows[i]["Destination"].ToString();
                //_o.CustomerName = _dataTable.Rows[i]["Customer_Name"].ToString();
                //_o.CustomerSurname = _dataTable.Rows[i]["Customer_Surname"].ToString();


                _lstOperations.Add(_o);
            }

            return _lstOperations;

        }
    }
}
