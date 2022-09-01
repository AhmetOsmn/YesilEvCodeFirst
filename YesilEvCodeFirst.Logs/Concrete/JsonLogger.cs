using Newtonsoft.Json;
using System;
using System.IO;
using YesilEvCodeFirst.Logs.Abstract;

namespace YesilEvCodeFirst.Logs.Concrete
{
    public class JsonLogger<T> : ILogger<T> where T : class
    {
        private readonly string _fileName;

        public JsonLogger(string fileName)
        {
            _fileName = fileName;   
        }

        string filePath = "C:\\MyLogs";

        public void Log(T alinacakLog)
        {
            string strJson = JsonConvert.SerializeObject(alinacakLog);
            string fullPath = Path.Combine(filePath, _fileName);
            File.AppendAllText(fullPath, strJson + Environment.NewLine);
        }
    }
}
