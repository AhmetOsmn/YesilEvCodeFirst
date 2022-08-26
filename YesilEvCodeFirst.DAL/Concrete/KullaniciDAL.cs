using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DAL.Abstract;

namespace YesilEvCodeFirst.DAL.Concrete
{
    public class KullaniciDAL : EfRepoBase<YesilEvDbContext, Kullanici>, IKullaniciDAL
    {
        public KullaniciDAL()
        {

        }

        public KullaniciDAL(YesilEvDbContext context) : base(context)
        {

        }
    }
}
