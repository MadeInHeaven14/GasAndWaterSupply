using Microsoft.AspNetCore.Components.Forms;
using MongoDB.Driver.GridFS;
using MongoDB.Driver;

namespace GasAndWaterSupply.Data
{
    public class FileSystemService
    {
        public string Employee = string.Empty;
        public string Department = string.Empty;
        public void UploadToDb(IBrowserFile browserFile, string path)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("UsersDB");
            var gridFS = new GridFSBucket(database);

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                gridFS.UploadFromStream(browserFile.Name, fs);
            }
        }

        public void UploadDocument(Document document)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("UsersDB");
            var collection = database.GetCollection<Document>("Documents");
            collection.InsertOne(document);
        }

        public void DownloadToLocal(string name)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("UsersDB");
            var gridFS = new GridFSBucket(database);
            using (FileStream fs = new FileStream($"{Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/DownloadFiles/")}{name}", FileMode.CreateNew))
            {
                gridFS.DownloadToStreamByName($"{name}", fs);
            }
        }
    }
}
