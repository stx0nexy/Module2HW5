using Module2HW5.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW5.Services
{
    public class NoteService : INoteService
    {
        private StreamWriter _streamWriter;

        public void Start(string logFileName)
        {
            _streamWriter = new StreamWriter(logFileName);
        }

        public void Add(string log)
        {
            _streamWriter.WriteLine(log);
        }

        public void Close()
        {
            Close(_streamWriter);
        }

        public void Close(StreamWriter streamWriter)
        {
            streamWriter.Close();
        }
    }
}
