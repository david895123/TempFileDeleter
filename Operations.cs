using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Runtime.InteropServices;

namespace TempFileDeleter
{
    internal class Operations
    {

        enum RecycleFlags : uint
        {
            SHERB_NOCONFIRMATION = 0x00000001,
            SHERB_NOPROGRESSUI = 0x00000002,
            SHERB_NOSOUND = 0x00000004
        }

        [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
        static extern uint SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlags dwFlags);

        public static void DeleteTemp()
        {

            System.IO.DirectoryInfo di1 = new DirectoryInfo("C:\\Users\\David\\AppData\\Local\\Temp");

            DeleteFiles(di1);

            System.IO.DirectoryInfo di2 = new DirectoryInfo("C:\\Windows\\Temp");

            DeleteFiles(di2);



        }

        public static void DeleteDownloads()
        {
            System.IO.DirectoryInfo di1 = new DirectoryInfo("C:\\Users\\David\\Downloads");

            DeleteFiles(di1);
        }


        public static void EmptyRecycleBin()
        {
            uint result = SHEmptyRecycleBin(IntPtr.Zero, null, 0);
            if (result == 0)
            {
                //OK
            }

        }


        static void DeleteFiles(System.IO.DirectoryInfo di)
        {

            foreach (FileInfo file in di.EnumerateFiles())
            {
                try
                {
                    file.Delete();
                }
                catch
                {

                }

            }
            foreach (DirectoryInfo dir in di.EnumerateDirectories())
            {
                try
                {
                    dir.Delete(true);
                }
                catch
                {

                }
            }
        }



    }
}
