using Module2HW5.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW5.Services
{
    public class FileService : IFileService
    {
        private INoteService _note;
        private string _logPath;
        public FileService(INoteService writer, IConfigService config)
        {
            _note = writer;
            Config = config;
            _logPath = config.Config.LogPath;

            if (!Directory.Exists(_logPath))
            {
                Directory.CreateDirectory(_logPath);
            }

            ClearOldLogFiles();
            OpenWriter();
        }

        public IConfigService Config { get; set; }

        public void OpenWriter()
        {
            OpenWriter(GetNameLogFile());
        }

        public string GetNameLogFile()
        {
            return Path.Combine(Config.Config.LogPath, $"{DateTime.UtcNow.ToString("hh.mm.ss dd.MM.yyyy")}.txt");
        }

        public void OpenWriter(string logFileName)
        {
            _note.Start(logFileName);
        }

        public void Add(string log)
        {
            _note.Add(log);
        }

        public void Close()
        {
            Close(_note);
        }

        public void Close(INoteService writer)
        {
            writer.Close();
        }

        public void ClearOldLogFiles()
        {
            var directoryInfo = new DirectoryInfo(_logPath);
            var fileInfos = directoryInfo.GetFiles("*.txt");

            Array.Sort<FileInfo>(fileInfos, new ComprarerFiles());

            var countDeleteFles = fileInfos.Length - Config.Config.CountLogs;

            for (var i = 0; i < countDeleteFles; i++)
            {
                try
                {
                    File.Delete(fileInfos[i].FullName);
                }
                catch
                {
                }
            }
        }
    }
}
