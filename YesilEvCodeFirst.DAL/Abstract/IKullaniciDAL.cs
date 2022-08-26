using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Interfaces;

namespace YesilEvCodeFirst.DAL.Abstract
{
    public interface IKullaniciDAL :
        IInsertableRepo<Kullanici>,
        ISelectableRepo<Kullanici>,
        IDeletableRepo<Kullanici>,
        IUpdatableRepo<Kullanici>
    {
    }
}
