using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace EventsProvider
{
    public class EventsRepository
    {
        private const string DatabaseName = "fbEvents";

        private const string CollectionName = "fbEvents";

        private readonly IMongoCollection<FbEvent> fbEvents =
            new MongoClient("mongodb://localhost:27017").GetDatabase(DatabaseName).GetCollection<FbEvent>(CollectionName);

        public List<FbEvent> GetByCategory(FbCategory category)
        {
            var documents = fbEvents.Find(e => e.Category == category).ToListAsync().Result;
            return documents;
        }
    }
}
