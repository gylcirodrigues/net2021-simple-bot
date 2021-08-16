using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using SimpleBotCore.Config;
using SimpleBotCore.Models;

namespace SimpleBotCore.Repositories
{
    public class MongoHelper : IMongoHelper
    {
        private readonly IMongoClient _client;
        private readonly IMongoDatabase _database;

        private readonly MongoDBConnection _config;
        private readonly MongoClientSettings _settings;

        public MongoHelper(IOptions<MongoDBConnection> options)
        {
            _config = options.Value;
            _settings = MongoClientSettings.FromConnectionString(_config.GetConnectionDefault());
            _client = new MongoClient(_settings);
            _database = _client.GetDatabase(_config.Database);
        }

        public IMongoDatabase GetDatabase()
        {
            return _database;
        }

        public IMongoCollection<T> GetCollection<T>(string name)
        {
            return this.GetDatabase().GetCollection<T>(name);
        }

    }
}
