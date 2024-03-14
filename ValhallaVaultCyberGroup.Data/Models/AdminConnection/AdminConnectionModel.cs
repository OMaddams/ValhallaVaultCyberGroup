namespace ValhallaVaultCyberGroup.Data.Models.AdminConnection
{
    public class AdminConnectionModel
    {
        public int Id { get; set; }
        public DateTime DateTimeConnected { get; set; }
        public string FromIp { get; set; } = null!;


    }
}
