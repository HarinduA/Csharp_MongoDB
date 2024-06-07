using MongoDB.Bson;
using MongoDB.Driver;

class Program
{
    static void Main(string[] args)
    {
        // Connection string for MongoDB
        string connectionString = "mongodb://localhost:27017";

        // Create a MongoClient object to connect to MongoDB server
        var client = new MongoClient(connectionString);

        // Get a reference to the database
        var database = client.GetDatabase("mydatabase");

        // Get a reference to the collection
        var collection = database.GetCollection<BsonDocument>("mycollection");

        // Create a document to insert into the collection
        var document = new BsonDocument
        {
            { "name", "John Doe" },
            { "age", 30 },
            { "city", "New York" }
        };

        // Insert the document into the collection
        collection.InsertOne(document);

        // Inform the user that data has been added successfully
        Console.WriteLine("Data added successfully.");

        // Close the connection to the MongoDB server
        client = null;
    }
}
