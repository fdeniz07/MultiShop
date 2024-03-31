using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MultiShop.Catalog.Entities
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CategoryId { get; set; } //MongoDB de ID'ler string formatta tutulurlar.
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }
}