using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApplication11
{
    class Type
    {
        int _idType;
        String _nameType;
        String _codeType;

        public int IdType
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

        public string NameType
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

        public string CodeType
        {
            get
            {
                return _codeType;
            }

            set
            {
                _codeType = value;
            }
        }

        public Type()
        { }

        public static List<Type> GetType(int? IdType)
        {
            try
            {
                SqlParameter[] parameters =
                                            {
                                                new SqlParameter("@IdType", SqlDbType.Int) { Value = IdType}
                                             };

                return TableToList(SQLHelper.ExecuteDataset(GlobalVars.DBConn, CommandType.StoredProcedure, "[dbo].[SelectTypeByID]", parameters).Tables[0]);


            }
            catch (Exception e)
            {
                return null;
            }

        }

        public static bool InsertType(Type t)
        {
            try
            {
                SqlParameter[] parameters =
                                            {
                                                new SqlParameter("@Name_Type", SqlDbType.NVarChar) { Value = t.NameType},
                                                new SqlParameter("@Code_Type", SqlDbType.NVarChar) { Value = t.CodeType},

                                                new SqlParameter("@IdType", SqlDbType.Int) { Direction = ParameterDirection.ReturnValue}
                                             };

                SQLHelper.ExecuteScalar(GlobalVars.DBConn, CommandType.StoredProcedure, "[dbo].[InsertType]", parameters);
                t.IdType = Convertions.ParseToIntOrZero(parameters[2].Value.ToString());
                return Convertions.ParseToValidBoolean(t.IdType.ToString());

            }
            catch (Exception e)
            {
                return false;
            }

        }

        public static bool UpdateType(Type t)
        {
            try
            {
                SqlParameter[] parameters =
                                            {
                                                new SqlParameter("@IdType", SqlDbType.Int) { Value = t.IdType},
                                                new SqlParameter("@Name_Type", SqlDbType.NVarChar) { Value = t.NameType},
                                                new SqlParameter("@Code_Type", SqlDbType.NVarChar) { Value = t.CodeType},
                                             };

                SQLHelper.ExecuteScalar(GlobalVars.DBConn, CommandType.StoredProcedure, "[dbo].[UpdateType]", parameters);
                return true;


            }
            catch (Exception e)
            {
                return false;
            }

        }

        public static bool DeleteTypeById(int id)
        {
            try
            {
                SqlParameter[] parameters =
                                            {
                                                 new SqlParameter("@IdType", SqlDbType.Int) { Value = id}
                                             };
                SQLHelper.ExecuteScalar(GlobalVars.DBConn, CommandType.StoredProcedure, "[dbo].[DeleteType]", parameters);
                return true;

            }
            catch (Exception e)
            {
                return false;
            }

        }

        private static List<Type> TableToList(DataTable _dataTable)
        {
            List<Type> _lstTypes = new List<Type>();

            for (int i = 0; i <= _dataTable.Rows.Count - 1; i++)
            {
                Type _t = new Type();

                _t.IdType = Convert.ToInt32(_dataTable.Rows[i]["ID_Type"].ToString());
                _t.NameType = _dataTable.Rows[i]["Name_Type"].ToString();
                _t.CodeType = _dataTable.Rows[i]["Code_Type"].ToString();

                _lstTypes.Add(_t);
            }

            return _lstTypes;

        }
    }
}
