using System;
using EventsProvider;

namespace EventsProviderConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            EventsRepository repo=new EventsRepository();
            repo.GetByCategory(FbCategory.It).ForEach(
                e => Console.WriteLine("Name {0}", e.Name));
            Console.ReadKey();
        }
    }
}
