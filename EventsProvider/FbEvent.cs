using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace EventsProvider
{
    using System.ComponentModel;
      [BsonIgnoreExtraElements]
    public class FbEvent
    {
        public ObjectId Id { get; set; }

        [BsonElement("event_category")]
        public string Category { get; set; }

        [BsonElement("event_id")]
        public string  EventId { get; set; }

        [BsonElement("event_name")]
        public string Name { get; set; }


        [BsonElement("start_time")]
        [DisplayName("Data rozpoczęcia")]
        public DateTime? StartDate { get; set; }

        [BsonElement("event_description")]
        public string Description { get; set; }
        [BsonElement("picture_url")]
        public string  PicSmallUrl { get; set; }

        [DisplayName("Miejsce")]
        [BsonElement("location_place")]
        public string Location { get; set; }

        [DisplayName("Organizator")]
        [BsonElement("event_owner")]
        public string OwnerId { get; set; }
      
        
    }
}