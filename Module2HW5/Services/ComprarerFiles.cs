using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW5.Services
{
    public class ComprarerFiles : IComparer<FileInfo>
    {
        public int Compare(FileInfo fileInfoX, FileInfo fileInfoY)
        {
            if (fileInfoX.LastWriteTimeUtc > fileInfoY.LastWriteTimeUtc)
            {
                return 1;
            }
            else if (fileInfoX.LastWriteTimeUtc < fileInfoY.LastWriteTimeUtc)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
