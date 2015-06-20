using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventsProvider;
using MongoDB.Driver;

namespace EventsProviderConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            EventsRepository repo=new EventsRepository();
            repo.GetByCategory(FbCategory.IT).ForEach(
                e => Console.WriteLine("{0}", e.Category));


        }


        public void Foo()
        {

            const string connectionString = "mongodb://localhost:27017";


            var client = new  MongoClient(connectionString);

            //Use the MongoClient to access the server
            var database = client.GetDatabase("test");
            





         ///   database.CreateCollectionAsync()

            //get mongodb collection
            //var collection = database.GetCollection<Entity>("entities");
            //await collection.InsertOneAsync(new Entity { Name = "Jack" });
        }
    }
}
