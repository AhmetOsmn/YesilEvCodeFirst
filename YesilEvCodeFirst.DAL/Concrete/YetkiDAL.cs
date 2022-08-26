using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DAL.Abstract;

namespace YesilEvCodeFirst.DAL.Concrete
{
    public class YetkiDAL : EfRepoBase<YesilEvDbContext, Yetki>, IYetkiDAL
    {
        public YetkiDAL()
        {

        }

        public YetkiDAL(YesilEvDbContext context) : base(context)
        {

        }
    }
}
