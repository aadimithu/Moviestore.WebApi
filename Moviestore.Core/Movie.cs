using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moviestore.Core
{
    public class Movie
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string ID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Category { get; set; }
        public string Award { get; set; }
        public string Description { get; set; }
    }
}
