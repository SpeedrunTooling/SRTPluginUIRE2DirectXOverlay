//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Runtime.InteropServices;
//using System.Text;

//namespace SRTPluginUIRE2DirectXOverlay
//{
//    public static class NativeWindowHelper
//    {
//        private delegate bool EnumThreadDelegate(IntPtr hWnd, IntPtr lParam);

//        [DllImport("user32.dll")]
//        private static extern bool EnumThreadWindows(int dwThreadId, EnumThreadDelegate lpfn, IntPtr lParam);

//        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
//        private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

//        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
//        private static extern int GetWindowTextLength(IntPtr hWnd);

//        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
//        private static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

//        public static IList<IntPtr> EnumerateProcessWindowHandles(Process process)
//        {
//            IList<IntPtr> windowHandles = new List<IntPtr>();
//            foreach (ProcessThread thread in process.Threads)
//            {
//                EnumThreadWindows(thread.Id, (hWnd, lParam) =>
//                {
//                    windowHandles.Add(hWnd);
//                    return true;
//                }, IntPtr.Zero);
//            }
//            return windowHandles;
//        }

//        public static string GetWindowTitle(IntPtr hWnd)
//        {
//            int length = GetWindowTextLength(hWnd) + 1;
//            StringBuilder title = new StringBuilder(length);
//            GetWindowText(hWnd, title, length);
//            return title.ToString();
//        }

//        public static string GetClassName(IntPtr hWnd)
//        {
//            StringBuilder className = new StringBuilder(256);
//            GetClassName(hWnd, className, className.Capacity);
//            return className.ToString();
//        }
//    }
//}
