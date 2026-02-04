
//Console.WriteLine(Solucao(3));
Console.WriteLine(ConverterSegundos(62));
static int Solucao(int n)
{
    var lista = new Dictionary<int, int>();
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Escreva o ID do Prato");
        var idPrato = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Escreva a Avilação");
        var avalicao = int.Parse(Console.ReadLine()!);
        lista.Add(idPrato, avalicao);
    }
    var melhorPrato = lista.OrderByDescending(x => x.Value).First();
    return melhorPrato.Key;
}
static string ConverterSegundos(int seg)
{
    int horas = seg / 3600;
    int minutos = (seg % 3600) / 60;
    int segundos = seg % 60;
    return $"{horas:D2} Horas:{minutos:D2} Minutos:{segundos:D2} Segundos";
}