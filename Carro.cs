public class Carro : Veiculo
{
    private int numeroDePortas;

    public Carro(string marca, string modelo, int ano, int numeroDePortas) : base(marca, modelo, ano)
    {
        this.numeroDePortas = numeroDePortas;
    }

    public void AbriPortaMala()
    {
        Console.WriteLine($"O {modelo} esta com o porta mala abaerto");
    }

    public void ExbirInformacoes() 
    {
        Console.WriteLine($" Marca: {marca}, Modelo: {modelo}, Ano: {ano}, Numero de portas: {numeroDePortas}");
    }
}