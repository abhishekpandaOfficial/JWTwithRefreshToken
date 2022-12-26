namespace JWTRefreshToken.NET6._0.Auth.Model.Interfaces
{
    public interface IBlobStorage
    {
        public Task<List<string>> GetAllDocuments(string connectionString, string containerName);
        Task<string> UploadDocument(string connectionString, string containerName, string fileName, Stream fileContent);
        Task<Stream> GetDocument(string connectionString, string containerName, string fileName);
        Task<bool> DeleteDocument(string connectionString, string containerName, string fileName);

    }
}
