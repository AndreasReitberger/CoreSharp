using System;
using System.Runtime.InteropServices;
using System.Security;

namespace AndreasReitberger.Core.Utilities
{
    public static class SecureStringHelper
    {
#nullable enable
        public static string ConvertToString(SecureString? secureString)
        {
            if (secureString == null) return string.Empty;
            IntPtr valuePtr = IntPtr.Zero;
            try
            {
                valuePtr = Marshal.SecureStringToGlobalAllocUnicode(secureString);
                return Marshal.PtrToStringUni(valuePtr) ?? string.Empty;
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(valuePtr);
            }
        }
        public static SecureString ConvertToSecureString(string? clearText)
        {
            clearText ??= string.Empty;
            SecureString securePassword = new();

            foreach (var c in clearText)
                securePassword.AppendChar(c);

            securePassword.MakeReadOnly();
            return securePassword;
        }
#nullable disable
    }
}
