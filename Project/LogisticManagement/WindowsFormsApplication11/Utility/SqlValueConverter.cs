using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication11
{
    /// <summary>
    /// Gets the value from DataReader and converts it to primitive (string, int, etc),
    /// performing checks for DBNull
    /// </summary>
    internal sealed class SqlValueConverter
    {
        private SqlValueConverter() { }

        #region getters based on ordinals
        public static String GetString(IDataReader reader, int ordinal)
        {
            if (reader.IsDBNull(ordinal)) return String.Empty;
            return reader.GetString(ordinal);
        }
        public static int GetInt32(IDataReader reader, int ordinal)
        {
            if (reader.IsDBNull(ordinal)) return 0;
            return Convert.ToInt32(reader.GetValue(ordinal));
        }
        public static long GetInt64(IDataReader reader, int ordinal)
        {
            if (reader.IsDBNull(ordinal)) return 0;
            return Convert.ToInt64(reader.GetValue(ordinal));
        }
        public static DateTime GetDateTime(IDataReader reader, int ordinal)
        {
            if (reader.IsDBNull(ordinal)) return DateTime.MinValue;
            return Convert.ToDateTime(reader.GetValue(ordinal));
        }
        #endregion

    }        //end class
}
