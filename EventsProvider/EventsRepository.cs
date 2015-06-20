using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace EventsProvider
{
    public class EventsRepository
    {
        private const string DatabaseName = "EventsDatabase";

        private const string CollectionName = "FbEvents";

        private readonly IMongoCollection<FbEvent> fbEvents =
            new MongoClient().GetDatabase(DatabaseName).GetCollection<FbEvent>(CollectionName);

        public List<FbEvent> GetByCategory(FbCategory category)
        { 
            return fbEvents.Find(e => e.Category == category).ToListAsync().Result;
        }


        public void InsertFbEvent(FbEvent fb)
        {
            
        }


    }
}
