using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Peca> pecas = new List<Peca>();
        string continuar;

        Console.WriteLine("=== CALCULADORA DE MDF ===");

        do
        {
            Peca peca = new Peca();

            Console.Write("Nome da peça: ");
            peca.Nome = Console.ReadLine();

            Console.Write("Largura (mm): ");
            peca.LarguraMm = double.Parse(Console.ReadLine());

            Console.Write("Altura (mm): ");
            peca.AlturaMm = double.Parse(Console.ReadLine());

            Console.Write("Quantidade: ");
            peca.Quantidade = int.Parse(Console.ReadLine());

            pecas.Add(peca);

            Console.Write("Deseja adicionar outra peça? (s/n): ");
            continuar = Console.ReadLine().ToLower();

            Console.WriteLine();
        }
        while (continuar == "s");

        Console.Write("Largura da chapa (mm): ");
        double larguraChapa = double.Parse(Console.ReadLine());

        Console.Write("Altura da chapa (mm): ");
        double alturaChapa = double.Parse(Console.ReadLine());

        Console.Write("Preço de uma chapa (R$): ");
        double precoChapa = double.Parse(Console.ReadLine());

        double areaChapaM2 = (larguraChapa * alturaChapa) / 1_000_000.0;
        double areaTotalPecasM2 = 0;

        Console.WriteLine("\n=== RESULTADO DAS PEÇAS ===");

        foreach (var peca in pecas)
        {
            double areaUnitaria = peca.AreaUnitariaM2();
            double areaTotal = peca.AreaTotalM2();
            areaTotalPecasM2 += areaTotal;

            Console.WriteLine($"Peça: {peca.Nome}");
            Console.WriteLine($"Área unitária: {areaUnitaria:F3} m²");
            Console.WriteLine($"Quantidade: {peca.Quantidade}");
            Console.WriteLine($"Área total: {areaTotal:F3} m²");
            Console.WriteLine("---------------------------");
        }

        int quantidadeChapas = (int)Math.Ceiling(areaTotalPecasM2 / areaChapaM2);
        double custoTotal = quantidadeChapas * precoChapa;

        Console.WriteLine("\n=== RESUMO FINAL ===");
        Console.WriteLine($"Área da chapa: {areaChapaM2:F3} m²");
        Console.WriteLine($"Área total das peças: {areaTotalPecasM2:F3} m²");
        Console.WriteLine($"Quantidade estimada de chapas: {quantidadeChapas}");
        Console.WriteLine($"Custo estimado: R$ {custoTotal:F2}");
    }
}