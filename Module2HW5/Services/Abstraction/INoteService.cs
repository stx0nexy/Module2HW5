using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW5.Services.Abstraction
{
    public interface INoteService
    {
        void Start(string logFileName);

        void Add(string log);
        void Close();

        void Close(StreamWriter stringWriter);
    }
}
