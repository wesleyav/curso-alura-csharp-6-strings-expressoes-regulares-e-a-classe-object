using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, mundo!");
            Console.WriteLine(123);
            Console.WriteLine(10.5);
            Console.WriteLine(true);

            object conta = new ContaCorrente(456, 687876);
            object desenvolvedor = new Desenvolvedor("4564654");

            Console.WriteLine(conta);

            Console.ReadLine();
        }

        public static void TestaString()
        {
            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string textoDeTeste = "Meu nome é Guilherme, me ligueem 94784-4546";

            Match resultado = Regex.Match(textoDeTeste, padrao);

            Console.WriteLine(resultado.Value);
            Console.ReadLine();


            string urlTeste = "https://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");

            Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
            Console.WriteLine(urlTeste.EndsWith("cambio"));

            Console.WriteLine(urlTeste.Contains("bytebank"));


            Console.ReadLine();


            string urlParametros = "http://www.bytebank.com.br/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratoValorDeArgumentosURL extratorDeValores = new ExtratoValorDeArgumentosURL(urlParametros);

            string valorMoedaOrigem = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + valorMoedaOrigem);

            string valorMoedaDestino = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valorMoedaDestino);

            Console.WriteLine(extratorDeValores.GetValor("valor"));


            Console.ReadLine();

            // Testando o metodo Remove
            string testeRemocao = "primeiraParte&123456789";
            int indiceEComercial = testeRemocao.IndexOf('&');
            Console.WriteLine(testeRemocao.Remove(indiceEComercial, 4));
            Console.ReadLine();



            string palavra = "moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino=";



            int indice = palavra.IndexOf("moedaDestino");
            Console.WriteLine(indice);

            Console.WriteLine("Tamanho da string nomeArgumento: " + nomeArgumento.Length);

            Console.WriteLine(palavra);
            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length));
            Console.ReadLine();

                                                               

            // Testando o IsNullOrEmpty
            string textoVazio = "";
            string textoNulo = null;
            string textoQualquer = "texto qualquer";
            Console.WriteLine(String.IsNullOrEmpty(textoVazio));
            Console.WriteLine(String.IsNullOrEmpty(textoNulo));
            Console.WriteLine(String.IsNullOrEmpty(textoQualquer));



            ExtratoValorDeArgumentosURL extrato = new ExtratoValorDeArgumentosURL("");

            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            int indiceInterrogacao = url.IndexOf('?');

            Console.WriteLine(indiceInterrogacao);

            Console.WriteLine(url);
            string argumentos = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(argumentos);
        }


    }
}

