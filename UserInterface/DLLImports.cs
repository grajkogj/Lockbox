using System.Runtime.InteropServices;

namespace UserInterface
{
    public static class DLLImports
    {
        [DllImport(@"Encryption.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void EncryptFile([MarshalAs(UnmanagedType.LPStr)] string fileName, [MarshalAs(UnmanagedType.LPStr)] string key);

        [DllImport(@"Encryption.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DecryptFile([MarshalAs(UnmanagedType.LPStr)] string fileName, [MarshalAs(UnmanagedType.LPStr)] string key);
    }
}
