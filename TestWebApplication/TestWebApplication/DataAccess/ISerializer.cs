namespace TestWebApplication.DataAccess
{
    public interface ISerializer
    {
        void Serialize(object aObj, string aFilePath);
        TObj Deserialize<TObj>(string aStream);
    }
}