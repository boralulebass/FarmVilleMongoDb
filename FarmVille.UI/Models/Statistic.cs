using MongoDB.Bson.Serialization.Attributes;

namespace FarmVille.UI.Models
{
    public class Statistic
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string StatisticId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Statisctic { get; set; }
        public string Icon { get; set; }
    }
}
