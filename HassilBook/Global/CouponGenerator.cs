using System;
using System.Text;

namespace HassilBook
{
    public class CouponGenerator
    {
        /// <summary>
        /// Generates a new coupon
        /// </summary>
        /// <returns></returns>
        public string GenerateCoupon()
        {
            Random random = new Random();
            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            int length = 5;
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(characters[random.Next(characters.Length)]);
            }
            return $"{FrmLogin.m_client.Company.Substring(0,1).ToUpper()}{result.ToString().ToUpper()}";
        }
    }
}
