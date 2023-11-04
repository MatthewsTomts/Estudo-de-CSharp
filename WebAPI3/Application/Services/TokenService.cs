using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebAPI3.Domain.Model.FuncionarioAggregate;

namespace WebAPI3.Application.Services;
public class TokenService
{
    public static object GenerateToken(Funcionario funcionario)
    {
        var key = Encoding.ASCII.GetBytes(ApiKey.Secret);
        var tokenConfig = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
                new Claim("funcionarioId", funcionario.id.ToString()),
            }),
            Expires = DateTime.UtcNow.AddHours(3),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha256Signature)
        };

        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.CreateToken(tokenConfig);
        var tokenString = tokenHandler.WriteToken(token);

        return new { token = tokenString };
    }
}
