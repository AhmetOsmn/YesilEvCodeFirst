using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DAL.Abstract;

namespace YesilEvCodeFirst.DAL.Concrete
{
    public class RoleDAL : EfRepoBase<YesilEvDbContext, Role>, IRoleDAL
    {
        public RoleDAL()
        {

        }

        public RoleDAL(YesilEvDbContext context) : base(context)
        {

        }
    }
}
