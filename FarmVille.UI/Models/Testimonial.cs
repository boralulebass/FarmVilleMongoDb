using MongoDB.Bson.Serialization.Attributes;

namespace FarmVille.UI.Models
{
    public class Testimonial
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string TestimonialId { get; set; }
        public string ClientName { get; set; }
        public string ClientCity { get; set; }
        public string ClientTestimonial { get; set; }
        public string ClientPhoto { get; set; }


    }
}
