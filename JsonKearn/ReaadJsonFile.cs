using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;//json的引用
using System.IO;//add
namespace JsonStudys {
    public class ReaadJsonFile {

        public static Config config = new Config();

        /// <summary>
        /// 读取JSON
        /// </summary>
        /// <param name="filepath"></param>
        public static void ReadFileConfig(string filepath) {
            try {
                using (StreamReader sr = new StreamReader(filepath)) {
                    string ret = sr.ReadToEnd();
                    config = JsonConvert.DeserializeObject<Config>(ret);//反序列化对象
                    //Console.WriteLine("读取的温度"+config.temp);
                }
            } catch {
                config = new Config();
            }
        }

        /// <summary>
        /// 写入JSON内容
        /// </summary>
        public static void ConfigPersistence() {
            try {
                using (StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "..\\..\\Configuration\\Config.json"))
                {
                    string ret = JsonConvert.SerializeObject(config);//序列化对象
                    sw.Write(ret);
                }
            } catch { }
        }

    }
}
