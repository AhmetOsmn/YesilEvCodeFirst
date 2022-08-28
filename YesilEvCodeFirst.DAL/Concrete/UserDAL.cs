using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DAL.Abstract;

namespace YesilEvCodeFirst.DAL.Concrete
{
    public class UserDAL : EfRepoBase<YesilEvDbContext, User>, IUserDAL
    {
        public UserDAL()
        {

        }

        public UserDAL(YesilEvDbContext context) : base(context)
        {

        }
    }
}
