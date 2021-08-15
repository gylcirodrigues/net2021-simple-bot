using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SimpleBotCore.Models;

namespace SimpleBotCore.Repositories
{
    public class QuestionMockRepository : IQuestionRepository
    {
        private Dictionary<int, Question> _questions = new Dictionary<int, Question>();

        public Task CreateAsync(string question, string userId)
        {
            return Task.Factory.StartNew(() => SaveQuestion(question, userId));
        }



        private void SaveQuestion(string text, string userId)
        {
            Random random = new Random();

            _questions.Add(random.Next(int.MaxValue), new Question()
            {

                Content = text,
                UserId = userId
            });
        }
    }
}