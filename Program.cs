
namespace Aula4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // while
            // for
            // do while 
            // foreach

            //WHILE
            //Enquanto uma condição for verdadeira, execute o bloco de código
            // Testa a condição antes de executar o bloc/corpinho de código
            //var sair = false;
            //while (!sair)
            //{
            //    Console.WriteLine("Deseja sair? Digite S para sim");
            //    var resposta = Console.ReadLine();

            //    if (resposta == "S" || resposta == "s")
            //        sair = true;
            //}


            // Quando o contador do laço começa em 0, a condição de parada deve ser "< número de execuções desejadas"
            // Escrever Olá Mundo 5 vezes na teusando while
            var contador = 5;
            while (contador < 5)
            {
                Console.WriteLine("Olá Mundo - While");
                contador++;
            }


            //FOR
            // ; separa as partes
            // , separa múltiplas instruções na mesma parte
            for (int i = 0, j = 5; i < 5 && j > 0; i++, j--)
            {
                Console.WriteLine($"Olá Mundo - For i={i} e j={j} (Soma = {i + j})");
            }

            // do => fazer
            // while => enquanto
            var contador2 = 5;
            do 
            {
                Console.WriteLine("Olá Mundo - Do While");
                contador2++;
            } while (contador2 < 5);
        }
    }
}
