namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Estruturas de Dados

            // Coleções
            // COllections

            //Listas
            // Permite acesso rápido via índice/posição
            // Quem está na posição 0? -> Lista é eficiente para leituras posicionais
            // O número 25 está na lista? -> Lista é ineficiente para buscas por um determinado valor

            // Uma coleção genérica supota qualquer tipo de dado
            // Lista de strings, Lista de Alunos, Lista de Inteiros
            
            var compras = new List<string>();
            
            compras.Add("Sabão");       // Posição 0 (item 1)
            compras.Add("Detergente");  // Posição 1 (item 2)
            compras.Add("Leite");       // Posição 2 (item 3)
            compras.Add("Ovos");        // Posição 3 (item 4)

            // Perguntar par ao usuario se ele deseja adicionar um item na lista de compras?
            // se sim, perguntar qual o nome do item e adicionar na lista
            // senão, continua para a exibição da lista completa


            // Colocar isso em um laço de repetição
            string resposta = "";
            do
            {
                Console.Write("Deseja adicionar um item na lista de compras? (s/n): ");
                resposta = Console.ReadLine();

                if (resposta == "s" || resposta == "S")
                {
                    Console.Write("Digite o item:");
                    string novoItem = Console.ReadLine();
                    compras.Add(novoItem);
                }
            }
            while (resposta == "s" || resposta == "S");


            for (int i = 0; i < compras.Count; i++)
            {
                Console.WriteLine($"Item na posição {i}: {compras[i]}");
            }
        }
    }
}
