using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace app_TWINTER.Global_Constraints
{
    public class Constants
    {
        // URole
        public const char ordinary_user = '0';
        public const char moderator = '1';
        public const char administrator = '2';
        // ProcessStatus
        public const char NEED_TO_DO = '0';
        public const char IN_PROCESS = '1';
        public const char DONE = '2';
        // Errors
        public const string TOO_LONG_DESCRIPTION = "Too long description";
        public const string INVALID_EMAIL = "Invalod Email";
        public const string REGEX_ERROR = "There are allowed passwords in rage of (12, 40) and could be used English symbols, digits and [!@#$%&*<>]";
    }

}