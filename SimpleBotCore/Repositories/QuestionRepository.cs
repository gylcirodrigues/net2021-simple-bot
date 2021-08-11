using MongoDB.Bson;
using MongoDB.Driver;

namespace SimpleBotCore.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly MongoClient mongoClient;
        private readonly IMongoDatabase db;
        private readonly IMongoCollection<BsonDocument> coll;

        public QuestionRepository()
        {
            this.mongoClient = new MongoClient();
            this.db = this.mongoClient.GetDatabase("bot");
            this.coll = this.db.GetCollection<BsonDocument>("questions");
        }


        public void AddQuestion(string question)
        {
            var value = new BsonDocument()
            {
                { "Question", question }
            };
            this.coll.InsertOne(value);
        }
    }
}
