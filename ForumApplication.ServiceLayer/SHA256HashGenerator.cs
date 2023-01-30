﻿using System.Security.Cryptography;
using System.Text;

namespace ForumApplication.ServiceLayer
{
    public class SHA256HashGenerator
    {
        public static string GenerateHash(string inputData)
        {
            using (SHA256 sha256hash = SHA256.Create())
            {
                byte[] bytes = sha256hash.ComputeHash(Encoding.UTF8.GetBytes(inputData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
