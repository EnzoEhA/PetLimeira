using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace PetLimeira.Services
{
    // Serviço responsável por gerar e verificar o hash da senha
    // Usa SHA-256 (que já vem por padrão com o .NET)
    // Transforma a senha em uma sequência de 256 bits,
    // normalmente 64 caracteres hexadecimais
    public class HashSenha
    {


        //Método que recebe a senha informada e devolve o hash em texto
        public static string Gerar(string senha)
        {

            // Transforma a senha em bytes e calcula o hash
            byte[] bytes = Encoding.UTF8.GetBytes(senha);

            // Gera o hash usando o algoritimo SHA256
            byte[] hash = SHA256.HashData(bytes);

            // Converter o hash para uma string em hexadecimal 
            return Convert.ToHexString(hash);

        }

        // Método para conferir se a senha digitada corresponde ao hash do banco
        // Recebe a senha digitada, 
        public static bool Verificar(string senha, string hashArmazenado)
        {
            // Gera a senha, compara e retorna verdadeiro ou falso
            return Gerar(senha) == hashArmazenado;
        }



    }
}
