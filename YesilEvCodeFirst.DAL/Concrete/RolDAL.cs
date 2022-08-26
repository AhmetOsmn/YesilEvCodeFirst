using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DAL.Abstract;

namespace YesilEvCodeFirst.DAL.Concrete
{
    public class RolDAL : EfRepoBase<YesilEvDbContext, Rol>, IRolDAL
    {
        public RolDAL()
        {

        }

        public RolDAL(YesilEvDbContext context) : base(context)
        {

        }
    }
}
