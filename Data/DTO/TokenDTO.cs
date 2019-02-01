namespace POS.APIs.Models.DTO
{
    public class TokenDTO
    {
        public string token { get; set; }
        public int expiration { get; set; }
        public string refresh_token { get; set; }
    }
}
