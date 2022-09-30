using Module2HW5.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW5.Services
{
    public class ConfigService : IConfigService
    {
        public ConfigService()
        {
            Config = new Config();
            DownloadConfig();
        }

        public Config Config { get; set; }

        public void DownloadConfig()
        {
            var configFile = File.ReadAllText("config.json");
            Config = JsonConvert.DeserializeObject<Config>(configFile);

            if (Config.CountLogs == 0)
            {
                Config.CountLogs = 3;
                SaveConfig();
            }

            if (Config.LogPath == null)
            {
                Config.LogPath = Path.Combine(Directory.GetCurrentDirectory(), "Logs");
                SaveConfig();
            }
        }

        public void SaveConfig()
        {
            var json = JsonConvert.SerializeObject(Config);
            File.WriteAllText("config.json", json);
        }
    }
}
