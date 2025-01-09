using System.Text;
using CB.Application.Dtos;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using CB.Application.Features.Mediator.Results.AppUserResults;

namespace CB.Application.Tools
{
    public class JwtTokenGenerator
    {
        public static TokenReponseDto GenerateToken(GetCheckAppUserQueryResult result)
        {
            // Kullanıcı bilgileriyle ilişkilendirilecek claim listesi oluşturulur
            var claims = new List<Claim>();

            // Eğer kullanıcının rolü mevcutsa, Role claim'i eklenir
            if (!string.IsNullOrWhiteSpace(result.Role))
                claims.Add(new Claim(ClaimTypes.Role, result.Role));

            // Kullanıcının unique kimliği NameIdentifier iddiası olarak eklenir
            claims.Add(new Claim(ClaimTypes.NameIdentifier, result.AppUserId.ToString()));

            // Eğer kullanıcı adı mevcutsa, Username claim'i eklenir
            if (!string.IsNullOrWhiteSpace(result.Username))
                claims.Add(new Claim("Username", result.Username));

            // Anahtar ve imzalama bilgilerini oluşturulur
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenDefaults.Key));

            // Anahtarı kullanarak imzalama bilgileri hazırlama
            var signInCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // Token'ın ne kadar süre geçerli olacağını belirleme
            var expireDate = DateTime.UtcNow.AddDays(JwtTokenDefaults.Expire);

            // JWT oluşturma
            JwtSecurityToken token = new JwtSecurityToken(
                issuer: JwtTokenDefaults.ValidIssuer,       // Token'ı oluşturan sunucunun bilgisi
                audience: JwtTokenDefaults.ValidAudience,   // Token'ın geçerli olduğu hedef kitle
                claims: claims,                             // Kullanıcıyla ilişkilendirilmiş iddialar
                notBefore: DateTime.UtcNow,                 // Token'ın geçerli olmaya başlayacağı zaman
                expires: expireDate,                        // Token'ın geçerliliğinin biteceği zaman
                signingCredentials: signInCredentials       // İmzalama bilgileri
                );

            // Token'ı string olarak yazdırmak için handler oluşturulur
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();

            // Oluşturulan token'ı ve geçerlilik süresi döndürülur
            return new TokenReponseDto(tokenHandler.WriteToken(token), expireDate);
        }
    }
}
