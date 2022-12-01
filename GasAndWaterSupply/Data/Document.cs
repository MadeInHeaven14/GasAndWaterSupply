using MongoDB.Bson.Serialization.Attributes;

namespace GasAndWaterSupply.Data
{
    [BsonIgnoreExtraElements]
    public class Document
    {
        public string Name { get; set; }
        public string Employee { get; set; }
        public string Department { get; set; }
    }
}
