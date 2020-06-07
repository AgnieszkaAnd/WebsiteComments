namespace WebsiteComments.Models
{
    public interface ISqlDataAccess
    {
        void LoadData();
        void SaveData();
    }
}