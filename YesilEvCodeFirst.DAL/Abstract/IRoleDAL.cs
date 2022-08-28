using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Interfaces;

namespace YesilEvCodeFirst.DAL.Abstract
{
    public interface IRoleDAL :
        ISelectableRepo<Role>,
        IUpdatableRepo<Role>,
        IDeletableRepo<Role>,
        IInsertableRepo<Role>
    {
    }
}
