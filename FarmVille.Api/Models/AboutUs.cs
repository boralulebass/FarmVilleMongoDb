using MongoDB.Bson.Serialization.Attributes;

namespace FarmVille.Api.Models
{
    public class AboutUs
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string AboutUsId { get; set; }
        public string? SubTitle { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Button { get; set; }
        public string? ImageTitle { get; set; }
        public string? ImageDescription { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageTitle2 { get; set; }
        public string? ImageDescription2 { get; set; }
        public string? ImageUrl2 { get; set; }
        public string? ImageTitle3 { get; set; }
        public string? ImageDescription3 { get; set; }
        public string? ImageUrl3 { get; set; }

    }
}
