namespace YesilEvCodeFirst.Logs.Abstract
{
    public interface ILogger<T> where T : class
    {
        void Log(T alinacakLog);
    }
}
