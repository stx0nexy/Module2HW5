using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW5.Services.Abstraction
{
    public interface IConfigService
    {
        Config Config { get; set; }
        void SaveConfig();
        void DownloadConfig();
    }
}
