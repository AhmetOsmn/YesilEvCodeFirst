using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DAL.Abstract;

namespace YesilEvCodeFirst.DAL.Concrete
{
    public class MaddeDAL : EfRepoBase<YesilEvDbContext, Madde>, IMaddeDAL
    {
        public MaddeDAL()
        {

        }

        public MaddeDAL(YesilEvDbContext context) : base(context)
        {

        }
    }
}
