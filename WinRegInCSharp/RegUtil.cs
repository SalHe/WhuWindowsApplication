using System;
using System.Runtime.InteropServices;

namespace WinRegInCSharp
{
    public class RegUtil
    {
        public static readonly uint REG_SZ = 1;
        public static readonly uint REG_DWORD = 4;

        public static readonly IntPtr HKEY_CLASSES_ROOT = new IntPtr(unchecked((int)0x80000000));
        public static readonly IntPtr HKEY_CURRENT_USER = new IntPtr(unchecked((int)0x80000001));
        public static readonly IntPtr HKEY_LOCAL_MACHINE = new IntPtr(unchecked((int)0x80000002));
        public static readonly IntPtr HKEY_USERS = new IntPtr(unchecked((int)0x80000003));
        public static readonly IntPtr HKEY_PERFORMANCE_DATA = new IntPtr(unchecked((int)0x80000004));
        public static readonly IntPtr HKEY_CURRENT_CONFIG = new IntPtr(unchecked((int)0x80000005));
        public static readonly IntPtr HKEY_DYN_DATA = new IntPtr(unchecked((int)0x80000006));

        // 获取操作Key值句柄 
        [DllImport("Advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int RegOpenKey(IntPtr hKey, string lpSubKey, out IntPtr phkResult);

        //创建或打开Key值
        [DllImport("Advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int RegCreateKey(IntPtr hKey, string lpSubKey, out IntPtr phkResult);

        //获取Key值（即：Key值句柄所标志的Key对象的值）
        [DllImport("Advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int RegQueryValueEx(IntPtr hKey, string lpValueName, int lpReserved, out uint lpType, System.Text.StringBuilder lpData, ref uint lpcbData);
        
        [DllImport("Advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int RegQueryValueEx(IntPtr hKey, string lpValueName, int lpReserved, out uint lpType, out int lpData, ref uint lpcbData);

        //设置Key值
        [DllImport("Advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int RegSetValueEx(IntPtr hKey, string lpValueName, uint unReserved, uint unType, string lpData, uint dataCount);
        
        [DllImport("Advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int RegSetValueEx(IntPtr hKey, string lpValueName, uint unReserved, uint unType, ref int lpData, uint dataCount);

        //关闭Key值
        [DllImport("Advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int RegCloseKey(IntPtr hKey);
    }
}