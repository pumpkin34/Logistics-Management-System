using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication11
{
    class Driver
    {
        int _idDriver;
        String _driverName;
        String _driverSurname;
        String _driverPhone;
        bool _driverStatus;

        public int IdDriver
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

        public string DriverName
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

        public string DriverSurname
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

        public string DriverPhone
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
        public bool DriverStatus

        {
            get
            {
                return _driverStatus;
            }

            set
            {
                _driverStatus = value;
            }
        }


        public Driver()
        { }

        public static List<Driver> GetDriver(int? idDriver)
        {
            try
            {
                SqlParameter[] parameters =
                                            {
                                                new SqlParameter("@IdDriver", SqlDbType.Int) { Value = idDriver}
                                             };

                return TableToList(SQLHelper.ExecuteDataset(GlobalVars.DBConn, CommandType.StoredProcedure, "[dbo].[SelectDriverByID]", parameters).Tables[0]);
                

            }
            catch (Exception e)
            {
                return null;
            }

        }

        public static bool InsertDriver(Driver d)
        {
            try
            {
                SqlParameter[] parameters =
                                            {
                                                new SqlParameter("@Name", SqlDbType.NVarChar) { Value = d.DriverName},
                                                new SqlParameter("@Surname", SqlDbType.NVarChar) { Value = d.DriverSurname},
                                                new SqlParameter("@Phone", SqlDbType.NVarChar) { Value = d.DriverPhone},
                                                 new SqlParameter("@Status", SqlDbType.Bit) { Value = d.DriverStatus},

                                                new SqlParameter("@IdDriver", SqlDbType.Int) { Direction = ParameterDirection.ReturnValue}
                                             };

                SQLHelper.ExecuteScalar(GlobalVars.DBConn, CommandType.StoredProcedure, "[dbo].[InsertDriver]", parameters);
                d.IdDriver = Convertions.ParseToIntOrZero(parameters[4].Value.ToString());
                return Convertions.ParseToValidBoolean(d.IdDriver.ToString());

            }
            catch (Exception e)
            {
                return false;
            }

        }

        public static bool UpdateDriver(Driver d)
        {
            try
            {
                SqlParameter[] parameters =
                                            {
                                                new SqlParameter("@IdDriver", SqlDbType.Int) { Value = d.IdDriver},
                                                new SqlParameter("@Name", SqlDbType.NVarChar) { Value = d.DriverName},
                                                new SqlParameter("@Surname", SqlDbType.NVarChar) { Value = d.DriverSurname},
                                                new SqlParameter("@Phone", SqlDbType.NVarChar) { Value = d.DriverPhone},
                                                  new SqlParameter("@Status", SqlDbType.TinyInt) { Value = d.DriverStatus}
                                             };

                SQLHelper.ExecuteScalar(GlobalVars.DBConn, CommandType.StoredProcedure, "[dbo].[UpdateDriver]", parameters);
                return true;


            }
            catch (Exception e)
            {
                return false;
            }

        }

        public static bool DeleteDriverById(int id)
        {
            try
            {
                SqlParameter[] parameters =
                                            {
                                                 new SqlParameter("@IdDriver", SqlDbType.Int) { Value = id}
                                             };
                SQLHelper.ExecuteScalar(GlobalVars.DBConn, CommandType.StoredProcedure, "[dbo].[DeleteDriver]", parameters);
                return true;

            }
            catch (Exception e)
            {
                return false;
            }

        }

        private static List<Driver> TableToList(DataTable _dataTable)
        {
            List<Driver> _lstDrivers = new List<Driver>();

            for (int i = 0; i <= _dataTable.Rows.Count - 1; i++)
            {
                Driver _d = new Driver();

                _d.IdDriver = Convert.ToInt32(_dataTable.Rows[i]["ID_Driver"].ToString());
                _d.DriverName = _dataTable.Rows[i]["Driver_Name"].ToString();
                _d.DriverSurname = _dataTable.Rows[i]["Driver_Surname"].ToString();
                _d.DriverPhone = _dataTable.Rows[i]["Driver_Phone"].ToString();
                _d.DriverStatus = Convert.ToBoolean(_dataTable.Rows[i]["Driver_Status"].ToString());

                _lstDrivers.Add(_d);
            }

            return _lstDrivers;

        }
    }
}

