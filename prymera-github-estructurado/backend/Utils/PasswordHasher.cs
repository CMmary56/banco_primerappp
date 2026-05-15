using System.Security.Cryptography;
using System.Text;

namespace PrymeraApi.Utils
{
    public static class PasswordHasher
    {
        public static string Hash(string password)
        {
            using SHA256 sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToHexString(bytes);
        }
    }
}
