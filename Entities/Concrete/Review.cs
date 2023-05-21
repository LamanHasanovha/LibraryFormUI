using Entities.Abstract;
using Entities.Constants;
using System;

namespace Entities.Concrete
{
    public class Review : IEntity
    {
        public Review() { }

        public Review(int id, int accountId, DateTime date, string text, int recordId, RatingTypes type)
        {
            Id = id;
            AccountId = accountId;
            Date = date;
            Text = text;
            RecordId = recordId;
            Type = type;
        }

        public int Id { get; set; }
        public int AccountId { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public int RecordId { get; set; }
        public RatingTypes Type { get; set; }
    }
}
