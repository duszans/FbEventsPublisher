using System;
using MongoDB.Bson;

namespace EventsProvider
{
    public class FbEvent
    {
        public ObjectId Id { get; set; }

        public FbCategory Category { get; set; }

        public string  EventId { get; set; }
        public string Name { get; set; }

        public DateTime? StartDate { get; set; }

        public string Description { get; set; }

        public string  PicSmall { get; set; }

        public string Location { get; set; }

        public string Owner { get; set; }
        public string Venue { get; set; }


        
    }
}