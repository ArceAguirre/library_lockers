using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace FCFM_Registro_Alumnos
{
    class Encrypting
    {
        private Byte[] KEY_64 = new Byte[8] {28, 234, 195, 44, 23, 150, 168, 15};
        private Byte[] IV_64 = new Byte[8] { 23, 191, 10, 180, 150, 185, 8, 30 };

        //Genera un hash para el texto recibido y retorna el resultado en una cadena
        //base64encoded. Antes de calcular el hash, un salt alearorio es generaod
        //y anexado al texto plano, este salt es almacenado al final del valor del hash
        //de manera que pueda ser utilizado posteriormente para la comparacion
        public String ComputeHash(string plainText, string hashAlgorithm, Byte[] saltBytes)
        {
            //Si no se recibe un hash, generar uno en el momento
            if (saltBytes == null)
	        {
                //Variables para definir la longitud maxima y minima del hash
                int minSaltSize = 4;
                int maxSaltSize = 8;
                //Generar un numero aleatorio del tamaño del Salt
                Random random = new Random();
                int saltSize = random.Next(minSaltSize, maxSaltSize);
                //saltBytes = new Byte[saltSize - 1] { };
                saltBytes = new Byte[saltSize - 1];
                //saltBytes = Enumerable.Repeat((Byte)0x20, saltSize - 1).ToArray();
                //saltBytes = saltSize - 1;

                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                rng.GetNonZeroBytes(saltBytes);
	        }
            //Convertimos el texto plano en un arreglo de bytes
            Byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            //declaramos el arreglo de bytes que contendra el texto con el salt
            Byte[] plainTextwithSaltBytes = new Byte[plainTextBytes.Length + (saltBytes.Length - 1)];
            //Byte[] plainTextwithSaltBytes = Enumerable.Repeat((Byte)0x20, plainTextBytes.Length + saltBytes.Length - 1).ToArray();

            //Copiamos los caracteres del texto al arreglo
            for (int i = 0; i < plainTextBytes.Length - 1; i++)
            {
                plainTextwithSaltBytes[i] = plainTextBytes[i];
            }

            //Añadimos los caracteres del salt
            for (int i = 0; i < saltBytes.Length - 1; i++)
            {
                plainTextwithSaltBytes[plainTextBytes.Length + i] = saltBytes[i];
            }

            HashAlgorithm hash;

            //Si no fue especificado un algoritmo de hash
            //entonces utilizaremos el SHA512
            if (hashAlgorithm == null)
            {
                hashAlgorithm = "SHA512";
            }

            switch (hashAlgorithm.ToUpper())
            {
                case "SHA1":
                    hash = new SHA1Managed();
                    break;
                case "SHA256":
                    hash = new SHA256Managed();
                    break;
                case "SHA384":
                    hash = new SHA384Managed();
                    break;
                case "SHA512":
                    hash = new SHA512Managed();
                    break;
                default:
                    hash = new MD5CryptoServiceProvider();
                    break;
            }

            Byte[] hashBytes = hash.ComputeHash(plainTextwithSaltBytes);

            //Creamos un arreglo de bytes donde almacenaremos el hash
            //adicionandole el salt
            Byte[] hashWithSaltBytes = new Byte[hashBytes.Length + (saltBytes.Length - 1)];
            //Byte[] hashWithSaltBytes = Enumerable.Repeat((Byte)0x20, hashBytes.Length + saltBytes.Length - 1).ToArray();

            for (int i = 0; i < hashBytes.Length - 1; i++)
            {
                hashWithSaltBytes[i] = hashBytes[i];
            }

            for (int i = 0; i < saltBytes.Length - 1; i++)
            {
                hashWithSaltBytes[hashBytes.Length + i] = saltBytes[i];
            }

            //Convertimos el resultado en un string base64
            String hashValue = Convert.ToBase64String(hashWithSaltBytes);

            return hashValue;
        }

        //Esta funcion verifica un texto plano contra un hash con base en un
        //algoritmo de hash
        public bool VerifyHash(string plainText, string hashAlgorithm, string hashValue)
        {

            //Convertimos el hash base64-encoded en un arreglo de bytes
            Byte[] hashWithSaltBytes = Convert.FromBase64String(hashValue);

            //Obtenemos la longitud del hash sin el salt anexo.
            int hashSizeInBits;
            int hashSizeInBytes;

            //Nos aseguramos de que el algortimo tenga valor
            if (hashAlgorithm == null)
            {
                hashAlgorithm = "SHA512";
            }

            //El tamaño del hash depende del algoritmo especificado
            switch (hashAlgorithm.ToUpper())
            {
                case "SHA1":
                    hashSizeInBits = 160;
                    break;
                case "SHA256":
                    hashSizeInBits = 256;
                    break;
                case "SHA384":
                    hashSizeInBits = 384;
                    break;
                case "SHA512":
                    hashSizeInBits = 512;
                    break;
                default:
                    hashSizeInBits = 128;
                    break;
            }

            //Convertimos el tamaño del hash de bits a bytes
            hashSizeInBytes = hashSizeInBits / 8;

            //Nos aseguramos de que la longitud del hash sea suficiente
            if (hashWithSaltBytes.Length < hashSizeInBytes)
            {
                return false;
            }

            //Declaramos el arreglo para almacenar el salt original onteniendolo del hash
            Byte[] saltBytes = new Byte[hashWithSaltBytes.Length - (hashSizeInBytes - 1)];
            //Byte[] saltBytes = Enumerable.Repeat((Byte)0x20, hashWithSaltBytes.Length - hashSizeInBytes - 1).ToArray();

            //Copiamos el salt del final del hash al arreglo
            for (int i = 0; i < saltBytes.Length - 1; i++)
            {
                saltBytes[i] = hashWithSaltBytes[hashSizeInBytes + i];
            }

            //Calculamos el hash
            String expectedHashString = ComputeHash(plainText, hashAlgorithm, saltBytes);

            //Si el hash calculado es igual al recibido entonces devolvemos
            //true, en otro caso regresamos false

            return (hashValue == expectedHashString);
        }

    }
}
