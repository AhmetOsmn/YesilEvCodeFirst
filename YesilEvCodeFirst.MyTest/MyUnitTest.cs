using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.DAL;
using YesilEvCodeFirst.DTOs.Urun;

namespace YesilEvCodeFirst.MyTest
{
    [TestClass]
    public class MyUnitTest
    {
        [TestMethod]
        public void UrunEklemeTest()
        {
            UseUrunDAL dal = new UseUrunDAL();
            bool result = dal.UrunEkle(new UrunEkleDTO()
            {
                Aciklama = "TEST",
                BarkodNo = Guid.NewGuid(),
                KategoriID = 2,
                // todo: maddeler'in int ile ID leri verilecek
                Maddeler = new List<Madde> { new Madde { MaddeAdi = "Madde 1" }, new Madde { MaddeAdi = "Madde 2" }},
                MarkaID = 2,
                UreticiID = 3,
                UrunAdi = "TEST URUN 1",
                BackPicture = "back picture path",
                FrontPicture = "front picture path"
            });

            if (!result)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }
    }
}
