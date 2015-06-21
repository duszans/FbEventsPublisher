using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace EventsProvider
{
    using MongoDB.Bson.Serialization.Attributes;

  
    public class EventsRepository
    {
        private const string DatabaseName = "facebookevent";

        private const string CollectionName = "event";

        private readonly IMongoCollection<FbEvent> fbEvents =
            new MongoClient("mongodb://admin:d41d8cd98f00b204e9800998ecf8427e@ds036648.mongolab.com:36648/facebookevent").GetDatabase(DatabaseName).GetCollection<FbEvent>(CollectionName);
//            new MongoClient("mongodb://172.16.101.218:27017").GetDatabase(DatabaseName).GetCollection<FbEvent>(CollectionName);

        public List<FbEvent> GetByCategory(FbCategory category)
        {
            string categoryString = category.ToString();
            var documents = this.fbEvents.Find(e => e.Category == categoryString).ToListAsync().Result;
            return documents;
        }
    }
}
