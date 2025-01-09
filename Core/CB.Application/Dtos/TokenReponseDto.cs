namespace CB.Application.Dtos
{
    public class TokenReponseDto
    {
        public TokenReponseDto(string token, DateTime expireDate)
        {
            Token = token;
            ExpireDate = expireDate;
        }

        public string Token { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}
