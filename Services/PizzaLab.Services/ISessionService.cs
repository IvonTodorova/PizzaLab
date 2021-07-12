namespace PizzaLab.Services
{
    using Microsoft.AspNetCore.Http;

    public interface ISessionService
    {
        void Set<T>(ISession session, string key, T value);

        bool TryGet(ISession session, string key);

        T Get<T>(ISession session, string key);
    }
}
