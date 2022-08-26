using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DAL.Abstract;

namespace YesilEvCodeFirst.DAL.Concrete
{
    public class UreticiDAL : EfRepoBase<YesilEvDbContext, Uretici>, IUreticiDAL
    {
        public UreticiDAL()
        {

        }

        public UreticiDAL(YesilEvDbContext context) : base(context)
        {

        }
    }
}
