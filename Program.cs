// See https://aka.ms/new-console-template for more information

using System.Reflection;
using System.Runtime.Loader;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyModel;
using Npgsql;
using Realms;

Console.WriteLine("Hello, World!");

try
{
    // Setup the Realm and PostgreSQL database contexts
    // var realm = Realm.GetInstance("path/to/your/realmfile.realm");
    // string connString = "Server=yourServer;Port=5432;Database=yourDatabase;User Id=yourUsername;Password=yourPassword;";
    // NpgsqlConnection conn = new NpgsqlConnection(connString);
    
    // Get all RealmObject classes in the current assembly
    Assembly mainAssembly = Assembly.GetExecutingAssembly();
    var modelClasses = mainAssembly.GetTypes()
        .Where(t => t.IsSubclassOf(typeof(RealmObject)) && !t.IsAbstract && t.Namespace == "corsano_realm_converter_csharp.models");

    foreach (var modelClass in modelClasses)
    {
        Console.WriteLine("Processing {0}...", modelClass.Name);
        // Read data from the Realm database
        // var realmObjects = realm.All(modelClass.Name).ToList();
    }
    
// 
//     // Process the data in smaller batches
//     const int batchSize = 1000;
//     for (int i = 0; i < realmObjects.Count; i += batchSize)
//     {
//         var batch = realmObjects.Skip(i).Take(batchSize);
// 
//         // Insert the data into the PostgreSQL database
//         foreach (var realmObject in batch)
//         {
//             var postgresObject = new MyPostgresObject
//             {
//                 // Perform data transformations or validations here
//                 Id = realmObject.Id,
//                 Name = realmObject.Name
//             };
// 
//             postgresDbContext.MyPostgresObjects.Add(postgresObject);
//         }
// 
//         // Save changes to the PostgreSQL database
//         postgresDbContext.SaveChanges();
//    }
}
catch (Exception ex)
{
    // Log the exception
    Console.WriteLine("An error occurred: {0}", ex.Message);
}