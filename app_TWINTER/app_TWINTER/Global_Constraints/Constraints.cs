using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace app_TWINTER.Global_Constraints
{
    public static class Constants
    {
        // Birthday privacy
        public const Int16 Public= 0;
        public const Int16 UserFollowers = 1;
        public const Int16 FollowingUsers = 2;
        public const Int16 EachOtherFollowing = 3;
        public const Int16 OnlyUser = 4;
        // URole
        public const Int16 ordinary_user = 0;
        public const Int16 moderator = 1;
        public const Int16 administrator = 2;
        public const Int16 main_administrator = 3;
        // ProcessStatus
        public const Int16 NEED_TO_DO = 0;
        public const Int16 IN_PROCESS = 1;
        public const Int16 DONE = 2;
        // Errors
        public const string TOO_LONG_DESCRIPTION = "Too long description";
        public const string TOO_SHORT_DESCRIPTION = "Too short description";
        public const string WRONG_SIZE = "Wrong size";
        public const string INVALID_EMAIL = "Invalod Email";
        public const string REGEX_ERROR = "There are allowed passwords in rage of (12, 40) and could be used English symbols, digits and [!@#$%&*<>]";
        public const string REQUIRED_FIELD = "This field is required!!!";
        public const string PASSWORDS_CONFIRMATION_FAULT = "The Passwords differs! Confirmation Fault!";
        // Files
        public const string FILE_PATH_TERMS_OF_USE = @"D:\GIThub\TWINTER\app_TWINTER\app_TWINTER\Content\Files\TERMS_OF_USE.docx";
        public const string FILE_TERMS_OF_USE = "TERMS_OF_USE.docx";
        public const string FILE_PATH_PRIVACY_POLICY = @"D:\GIThub\TWINTER\app_TWINTER\app_TWINTER\Content\Files\PRIVACY_POLICY.docx";
        public const string FILE_PRIVACY_POLICY = "PRIVACY_POLICY.docx";
    }

}