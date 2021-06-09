using System;
using System.Collections.Generic;
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

        public string GenerateEticketNo()
        {
            Random random = new Random();
            HashSet<string> ids = new HashSet<string>();
            long eticketNo = new long();
            string test = null;

            while (ids.Count < 25)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < 10; ++i)
                {
                    sb.Append(random.Next(10));
                }
                //ids.Add(sb.ToString());
                test = sb.ToString();
                //eticketNo = Convert.ToInt64(test.ToString());
            }
            return test;
        }
    }
}
