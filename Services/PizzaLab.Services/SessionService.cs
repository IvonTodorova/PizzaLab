
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace PizzaLab.Services
{
    public class SessionService : ISessionService
    {
        public void Set<T>(ISession session, string key, T value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public bool TryGet(ISession session, string key)
        {
            var value = session.GetString(key);

            if (value == null)
            {
                return false;
            }

            return true;
        }

        public T Get<T>(ISession session, string key)
        {
            var value = session.GetString(key);

            if (value == null)
            {
                return default(T);
            }

            var data = JsonConvert.DeserializeObject<T>(value);
            return data;
        }
    }
}
