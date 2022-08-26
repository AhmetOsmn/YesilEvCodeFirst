namespace YesilEvCodeFirst.Core.Interfaces
{
    public interface IRepo<T> where T : class
    {
        void MySaveChanges();
    }
}
