using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SeriesNamer
{
    public static class FileUtil
    {
        public static void MakeSureDirectoryExist(string path)
        {
            DirectoryInfo info = new DirectoryInfo(path);
            MakeSureDirectoryExist(info);
        }

        public static void MakeSureDirectoryExist(DirectoryInfo info)
        {
            DirectoryInfo p = info.Parent;
            if (p != null) MakeSureDirectoryExist(p);
            if (info.Exists) return;
            info.Create();
        }
    }
}
