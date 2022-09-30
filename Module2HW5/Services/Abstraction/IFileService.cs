using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW5.Services.Abstraction
{
    public interface IFileService
    {
        void Add(string log);

        void Close();

        void Close(INoteService writer);
    }
}
