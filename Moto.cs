public class Moto : Veiculo
{
    private bool temBau;

    public Moto(string marca, string modelo, int ano, bool temBau ) : base(marca, modelo, ano)
    {
        this.temBau = temBau;
    }

    public void DarGrau()
    {
        Console.WriteLine("RANANANANA PÁPÁPÁ");
    }

      public void ExbirInformacoes() 
    {
        Console.WriteLine($" Marca: {marca}, Modelo: {modelo}, Ano: {ano}, Tem baú:{temBau}");
    }
}