using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication11
{
    class Truck
    {
        int _idTruck;
        String _plateTruck;
        String _plateTruckbad;

        public int IdTruck
        {
            get
            {
                return _idTruck;
            }

            set
            {
                _idTruck = value;
            }
        }

        public string PlateTruck
        {
            get
            {
                return _plateTruck;
            }

            set
            {
                _plateTruck = value;
            }
        }

        public string PlateTruckBad
        {
            get
            {
                return _plateTruckbad;
            }

            set
            {
                _plateTruckbad = value;
            }
        }

        public Truck()
        { }

        public static List<Truck> GetTruck(int? idTruck)
        {
            try
            {
                SqlParameter[] parameters =
                                            {
                                                new SqlParameter("@IdTruck", SqlDbType.Int) { Value = idTruck}
                                             };

                return TableToList(SQLHelper.ExecuteDataset(GlobalVars.DBConn, CommandType.StoredProcedure, "[dbo].[SelectTruckByID]", parameters).Tables[0]);


            }
            catch (Exception e)
            {
                return null;
            }

        }

        public static bool InsertTruck(Truck t)
        {
            try
            {
                SqlParameter[] parameters =
                                            {
                                                new SqlParameter("@Plate_Truck", SqlDbType.NVarChar) { Value = t.PlateTruck},
                                                new SqlParameter("@Plate_Truckbad", SqlDbType.NVarChar) { Value = t.PlateTruckBad},
                                             
                                                new SqlParameter("@IdTruck", SqlDbType.Int) { Direction = ParameterDirection.ReturnValue}
                                             };

                SQLHelper.ExecuteScalar(GlobalVars.DBConn, CommandType.StoredProcedure, "[dbo].[InsertTruck]", parameters);
                t.IdTruck = Convertions.ParseToIntOrZero(parameters[2].Value.ToString());
                return Convertions.ParseToValidBoolean(t.IdTruck.ToString());

            }
            catch (Exception e)
            {
                return false;
            }

        }

        public static bool UpdateTruck(Truck t)
        {
            try
            {
                SqlParameter[] parameters =
                                            {
                                                new SqlParameter("@IdTruck", SqlDbType.Int) { Value = t.IdTruck},
                                                new SqlParameter("@Plate_Truck", SqlDbType.NVarChar) { Value = t.PlateTruck},
                                                new SqlParameter("@Plate_Truckbad", SqlDbType.NVarChar) { Value = t.PlateTruckBad},
                                             };

                SQLHelper.ExecuteScalar(GlobalVars.DBConn, CommandType.StoredProcedure, "[dbo].[UpdateTruck]", parameters);
                return true;


            }
            catch (Exception e)
            {
                return false;
            }

        }

        public static bool DeleteTruckById(int id)
        {
            try
            {
                SqlParameter[] parameters =
                                            {
                                                 new SqlParameter("@IdTruck", SqlDbType.Int) { Value = id}
                                             };
                SQLHelper.ExecuteScalar(GlobalVars.DBConn, CommandType.StoredProcedure, "[dbo].[DeleteTruck]", parameters);
                return true;

            }
            catch (Exception e)
            {
                return false;
            }

        }

        private static List<Truck> TableToList(DataTable _dataTable)
        {
            List<Truck> _lstTrucks = new List<Truck>();

            for (int i = 0; i <= _dataTable.Rows.Count - 1; i++)
            {
                Truck _t = new Truck();

                _t.IdTruck = Convert.ToInt32(_dataTable.Rows[i]["ID_Truck"].ToString());
                _t.PlateTruck = _dataTable.Rows[i]["Plate_Truck"].ToString();
                _t.PlateTruckBad = _dataTable.Rows[i]["Plate_Truckbad"].ToString();

                _lstTrucks.Add(_t);
            }

            return _lstTrucks;

        }
    }
}
