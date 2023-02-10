using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApp1.Common
{
    internal static class Constants
    {
        public enum Status
        {
            PENDING = 1,
            ACTIVE = 2,
            CANCELLED = 3
        }

        public enum ValidationType
        {
            CREATE = 1,
            UPDATE = 2
        }

        public static string DATE_FORMAT = "yyyy-MM-dd";

        public static string DEFAULT_SELECT_ALL = "All";
        public static int DEFAULT_SELECT_ALL_INT = -1;

        public static string COLUMN_STATUS = "status";
        public static string COLUMN_ACTION = "action";
    }
}
