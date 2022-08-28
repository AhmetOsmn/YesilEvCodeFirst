using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Interfaces;

namespace YesilEvCodeFirst.DAL.Abstract
{
    public interface IUserDAL :
        IInsertableRepo<User>,
        ISelectableRepo<User>,
        IDeletableRepo<User>,
        IUpdatableRepo<User>
    {
    }
}
