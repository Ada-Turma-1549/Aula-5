namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var compras = new List<string>();
            
            compras.Add("Sabão");       // Posição 0 (item 1)
            compras.Add("Detergente");  // Posição 1 (item 2)
            compras.Add("Leite");       // Posição 2 (item 3)
            compras.Add("Ovos");        // Posição 3 (item 4)

            //var sair = false;
            //while (!sair) //O usuário não digitou SAIR
            //{
            //    Console.WriteLine("Digite o Nome do Produto ou 'sair' para encerrar:");
            //    var entrada = Console.ReadLine();

            //    if (entrada == "sair")
            //    {
            //        sair = true;
            //    }
            //    else
            //    {
            //        compras.Add(entrada);
            //    }
            //}

            var sair = false;
            do
            {
                Console.WriteLine("Digite o Nome do Produto ou 'sair' para encerrar:");
                var entrada = Console.ReadLine();

                if (entrada == "sair")
                {
                    sair = true;
                }
                else
                {
                    compras.Add(entrada);
                }
            }
            while (!sair);



            for (int i = 0; i < compras.Count; i++)
            {
                Console.WriteLine($"Item na posição {i}: {compras[i]}");
            }
        }
    }
}
