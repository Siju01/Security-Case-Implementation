using System;
using ExpressEncription;

namespace Security
{
    class Program
    {
        private static void Main(string[] args)
        {
            //RSA Encryption

            //Generate a key pair
            ExpressEncription.RSAEncription.MakeKey(@"C:\Pens\Semester 5\Pemrograman Jaringan Komputer\Server\public.key", @"C:\Pens\Semester 5\Pemrograman Jaringan Komputer\Server\private.key");

            //Encrypt
            var plainText = "Hallo";
            var cypherText = ExpressEncription.RSAEncription.EncryptString(plainText, @"C:\Pens\Semester 5\Pemrograman Jaringan Komputer\Server\public.key");

            //decrypt
            var decyrptText = ExpressEncription.RSAEncription.DecryptString(cypherText, @"C:\Pens\Semester 5\Pemrograman Jaringan Komputer\Server\private.key");

        }
    }
}
