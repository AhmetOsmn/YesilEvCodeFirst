using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Interfaces;

namespace YesilEvCodeFirst.DAL.Abstract
{
    public interface IUrunDAL : 
        IInsertableRepo<Urun>,
        IUpdatableRepo<Urun>,
        ISelectableRepo<Urun>,
        IDeletableRepo<Urun>
        // hangi interface'ler eklenecek?
    {
    }
}
