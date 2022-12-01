using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace GasAndWaterSupply.Data
{
    public class User
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id;
        [Required]
        public string Login { get; set; }
        [Required]
        public string FullName { get; set; }
        public string Role { get; set; }
        public string Department { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [BsonIgnoreIfNull]
        public string Developer { get; set; }
        [BsonIgnoreIfNull]
        public string Organization { get; set; }
        [BsonIgnoreIfNull]
        public string OGRN { get; set; }
        [BsonIgnoreIfNull]
        public string INN { get; set; }
        [BsonIgnoreIfNull]
        public string KPP { get; set; }
        [BsonIgnoreIfNull]
        public string Address { get; set; }
        [BsonIgnoreIfNull]
        public string Supervisor { get; set; }
        [BsonIgnoreIfNull]
        public string Director { get; set; }
        [BsonIgnoreIfNull]
        public string ChiefEngineer { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [BsonIgnore]
        public string ConfirmPassword { get; set; }
    }
}
