using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaService.Helpers
{
    public static class Md5Hasher
    {
		public static string GetMd5Hash(string input, string salt)
		{
			if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(salt))
			{
				throw new Exception("Empty value is not allowed for password! ");
			}
			var hasher = System.Security.Cryptography.MD5.Create();

			// Convert the input string to a byte array and compute the hash.
			byte[] data = hasher.ComputeHash(Encoding.Default.GetBytes(input + salt));

			// Create a new Stringbuilder to collect the bytes and create a string.
			var stringBuilder = new StringBuilder();

			// Loop through each byte of the hashed data 
			// and format each one as a hexadecimal string.
			for (int i = 0; i < data.Length; i++)
			{
				stringBuilder.Append(data[i].ToString("x2"));
			}

			return stringBuilder.ToString();
		}
	}
}
