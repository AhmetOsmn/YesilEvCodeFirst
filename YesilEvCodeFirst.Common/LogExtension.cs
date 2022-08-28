using System;
using YesilEvCodeFirst.DTOs;
using YesilEvCodeFirst.Logs.Concrete;

namespace YesilEvCodeFirst.Common
{
    public static class LogExtension
    {
        public static void LogFunc(JsonLogger<LogDTO> myLog, string dataID, string kisi, string not, string tablo, Islem islem)
        {
            myLog.Log(new LogDTO()
            {
                DataID = dataID,
                Islem = islem,
                Kisi = kisi,
                Not = not,
                Tablo = tablo,
                IslemTarihi = DateTime.Now.ToString()
            });
        }
    }
}
