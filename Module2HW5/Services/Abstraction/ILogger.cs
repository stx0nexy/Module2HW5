using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW5.Services.Abstraction
{
    public interface ILogger
    {
        void LogInfo(string message);

        void LogError(string message);

        void LogWarning(string message);

        void Log(LogType type, string message);

        void Close();
    }
}
