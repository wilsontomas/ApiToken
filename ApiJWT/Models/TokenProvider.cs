using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiJWT.Models
{
    public class TokenProvider
    {
        private readonly string _issuer;
        private readonly string _audience;
        private readonly string _secretKey;
        public string _algorit;
        private readonly SymmetricSecurityKey _signingkey;

        public TokenProvider(string issuer, string audience,string secretKey) {
            _issuer = issuer;
            _audience = audience;
            _secretKey = secretKey;
            _algorit = SecurityAlgorithms.HmacSha256Signature;
            _signingkey = new SymmetricSecurityKey(System.Text.Encoding.UTF8(secretKey));
        }
        public string createtoken(Usuario usuario, DateTime expirationDate) {
            return "";
        }

        public TokenValidationParameters getValidationParameters() {
            return new TokenValidationParameters {
                IssuerSigningKey = _signingkey,
                ValidAudience = _audience,
                ValidIssuer = _issuer,
                ValidateLifetime = true,
                ClockSkew=TimeSpan.FromSeconds(0)
            }
        }
    }
}
