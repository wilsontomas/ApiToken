using Microsoft.IdentityModel.Tokens;
using System;

namespace ApiJWT.Models
{
    public interface ITokenProvider
    {
        string createtoken(Usuario usuario, DateTime expirationDate);
        TokenValidationParameters getValidationParameters();
    }
}