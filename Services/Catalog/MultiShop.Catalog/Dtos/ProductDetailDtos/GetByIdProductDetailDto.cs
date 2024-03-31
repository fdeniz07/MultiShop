using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MultiShop.Catalog.Entities;

namespace MultiShop.Catalog.Dtos.ProductDetailDtos
{
    public class GetByIdProductDetailDto
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string Info { get; set; }
        public string ProductId { get; set; }
    }
}
