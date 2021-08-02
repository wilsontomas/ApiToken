using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace ApiJWT.Models
{
    public class TokenProvider : ITokenProvider
    {
        private readonly string _issuer;
        private readonly string _audience;
        private readonly string _secretKey;
        private string _algorit;
        private readonly SymmetricSecurityKey _signingkey;

        public TokenProvider(string issuer, string audience, string secretKey)
        {
            _issuer = issuer;
            _audience = audience;
            _secretKey = secretKey;
            _algorit = SecurityAlgorithms.HmacSha256Signature;
            _signingkey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(secretKey));
        }
        public string createtoken(Usuario usuario, DateTime expirationDate)
        {
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.NameIdentifier,usuario.NombreUsuario));
            claims.Add(new Claim(ClaimTypes.Name,usuario.NombreUsuario));
            ClaimsIdentity identity = new ClaimsIdentity(claims);
            SecurityToken securityToken = tokenHandler.CreateJwtSecurityToken(new SecurityTokenDescriptor
            {
                Audience = _audience,
                Issuer = _issuer,
                SigningCredentials = new SigningCredentials(_signingkey, _algorit),
                Expires = expirationDate.ToUniversalTime(),
                Subject=identity
            }); ;
            return tokenHandler.WriteToken(securityToken);
        }

        public TokenValidationParameters getValidationParameters()
        {
            return new TokenValidationParameters
            {
                IssuerSigningKey = _signingkey,
                ValidAudience = _audience,
                ValidIssuer = _issuer,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.FromSeconds(0)
            };
        }
    }
}
