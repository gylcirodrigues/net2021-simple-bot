using MongoDB.Driver;

namespace SimpleBotCore.Repositories
{
    public interface IMongoHelper
    {
        IMongoDatabase GetDatabase();
        IMongoCollection<T> GetCollection<T>(string name);
    }
}