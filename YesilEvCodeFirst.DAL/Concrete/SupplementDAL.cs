using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DAL.Abstract;

namespace YesilEvCodeFirst.DAL.Concrete
{
    public class SupplementDAL : EfRepoBase<YesilEvDbContext, Supplement>, ISupplementDAL
    {
        public SupplementDAL()
        {

        }

        public SupplementDAL(YesilEvDbContext context) : base(context)
        {

        }
    }
}
