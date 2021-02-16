using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsFormsApplication11
{
    public class Convertions
    {

        #region Convertions

        public static int? ParseToNullableInt(string value)
        {
            return String.IsNullOrEmpty(value) ? null : (int.Parse(value) as int?);
        }
        public static bool ParseToValidBoolean(string value)
        {
            if (String.IsNullOrEmpty(value))
                return false;
            try
            {
                if (Convert.ToInt32(value) > 0)
                    return true;
            }
            catch (Exception)
            {
                return Convert.ToBoolean(value);
            }

            return false;
        }
        public static bool? ParseToNullableBoolean(string value)
        {
            if (String.IsNullOrEmpty(value))
                return null;
            try
            {
                if (Convert.ToInt32(value) > 0)
                    return true;
            }
            catch (Exception)
            {
                return Convert.ToBoolean(value);
            }

            return null;
        }
        public static int ParseToIntOrZero(string value)
        {
            return String.IsNullOrEmpty(value) ? 0 : int.Parse(value);
        }
        public static DateTime? ParseToNullableDateTime(string value)
        {
            if (String.IsNullOrEmpty(value))
                return null;
            try
            {
                return Convert.ToDateTime(value);
            }
            catch (Exception)
            {
                return null;
            }

        }
        public static Decimal? ParseToNullableDecimal(string value)
        {
            return String.IsNullOrEmpty(value) ? null : (Decimal.Parse(value) as Decimal?);
        }
        public static Decimal ParseToZeroOrDecimal(string value)
        {
            return String.IsNullOrEmpty(value) ? 0 : (Decimal.Parse(value));
        }
        public static bool IsStringNumber(string strTextEntry)
        {
            Regex objNotWholePattern = new Regex("[^0-9]");
            return !objNotWholePattern.IsMatch(strTextEntry)
                 && (strTextEntry != String.Empty);
        }
        public static int? getIntFromString(string value)
        {
            int length = value.Length;
            string output = String.Empty;
            bool err = false;

            for (int i = 0; i <= length; i++)
            {
                try
                {
                    Convert.ToInt32(value.Substring(i, 1));
                    err = false;
                }
                catch
                {
                    err = true;
                }

                if (!err)
                    output += value.Substring(i, 1);
            }

            return ParseToNullableInt(output);
        }
        public static int? getIntFromStringPattern(string value, string pattern)
        {
            String _newValue = value.Substring(value.IndexOf(pattern));
            return getIntFromString(_newValue);
        }

        #endregion  Convertions

        #region Calculations

        public static DateTime GetLastDayOfQuarter(DateTime originalDate)
        {
            return AddQuarters(new DateTime(originalDate.Year, 1, 1), GetQuarter(originalDate)).AddDays(-1);
        }
        public static DateTime AddQuarters(DateTime originalDate, int quarters)
        {
            return originalDate.AddMonths(quarters * 3);
        }
        public static int GetQuarter(DateTime fromDate)
        {
            return ((fromDate.Month - 1) / 3) + 1;
        }
        public static DateTime GetFirstDayOfMonth(DateTime dtDate)
        {
            DateTime dtFrom = dtDate;

            dtFrom = dtFrom.AddDays(-(dtFrom.Day - 1));
            return dtFrom;
        }
        public static DateTime GetLastDayOfMonth(DateTime dtDate)
        {
            DateTime dtTo = new DateTime(dtDate.Year, dtDate.Month, 1);
            dtTo = dtTo.AddMonths(1);

            dtTo = dtTo.AddDays(-(dtTo.Day));

            return dtTo;
        }
        public static DateTime FirstDayOfYear(DateTime y)
        {
            return new DateTime(y.Year, 1, 1);
        }
        public static DateTime LastDayOfYear(DateTime d)
        {
            DateTime time = new DateTime((d.Year + 1), 1, 1);
            return time.AddDays(-1);
        }

        #endregion Calculations

    }
}
