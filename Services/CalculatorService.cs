using System;
using System.Collections.Generic;
using System.Linq;

public class CalculatorService
{
    public double CalcularAreaChapa(double larguraMm, double alturaMm)
    {
        return (larguraMm * alturaMm) / 1_000_000.0;
    }

    public double CalcularAreaTotalPecas(List<Peca> pecas)
    {
        return pecas.Sum(p => p.AreaTotalM2());
    }

    public int CalcularQuantidadeChapas(double areaTotalPecas, double areaChapa)
    {
        return (int)Math.Ceiling(areaTotalPecas / areaChapa);
    }

    public double CalcularCustoTotal(int quantidadeChapas, double precoChapa)
    {
        return quantidadeChapas * precoChapa;
    }
}