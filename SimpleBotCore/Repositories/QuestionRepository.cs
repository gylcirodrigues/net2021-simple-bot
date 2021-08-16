using Microsoft.Extensions.Options;
using MongoDB.Driver;
using SimpleBotCore.Config;
using SimpleBotCore.Models;
using System.Threading.Tasks;

namespace SimpleBotCore.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly IMongoHelper mongo;

        public QuestionRepository(IMongoHelper mongo)
        {
            this.mongo = mongo;
        }

        public async Task CreateAsync(string text, string userId)
        {
            var question = new Question
            {
                Content = text,
                UserId = userId
            };

            await this.mongo.GetCollection<Question>("questions").InsertOneAsync(question);
        }
    }
}