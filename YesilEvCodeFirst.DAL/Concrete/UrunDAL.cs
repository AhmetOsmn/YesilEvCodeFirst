using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DAL.Abstract;

namespace YesilEvCodeFirst.DAL.Concrete
{
    public class UrunDAL : EfRepoBase<YesilEvDbContext,Urun>, IUrunDAL
    {
        public UrunDAL()
        {

        }

        public UrunDAL(YesilEvDbContext context) : base(context)
        {

        }
    }
}
