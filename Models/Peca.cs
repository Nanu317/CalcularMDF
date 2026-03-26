public class Peca
{
    public string Nome { get; set; }
    public double LarguraMm { get; set; }
    public double AlturaMm { get; set; }
    public int Quantidade { get; set; }

    public double AreaUnitariaM2()
    {
        return (LarguraMm * AlturaMm) / 1_000_000.0;
    }

    public double AreaTotalM2()
    {
        return AreaUnitariaM2() * Quantidade;
    }
}