using MongoDB.Bson;
using MongoDB.Driver;
using Shared.Models;
using System.Threading.Tasks;

namespace DataService.src.Repository
{
    public class MongoDbRepository : IDbRepository<ExternalObjectModel>
    {
        MongoClient client;
        IMongoDatabase db;

        private static readonly string _connection = System.Configuration.ConfigurationManager.ConnectionStrings["mongoDb"].ConnectionString;
        public MongoDbRepository()
        {

            client = new MongoClient(_connection);
            db = client.GetDatabase("documentsRecognition");
        }

        public async Task<bool> IsDocumentExists(string documentNumber)
        {
            var collection = db.GetCollection<ExternalObjectModel>("docs");
            var filter = new BsonDocument("number",documentNumber);
            var document = await collection.Find(filter).FirstOrDefaultAsync();
            return document != null;
        }
    }
}
