public class Veiculo
{
    
        protected string marca;
        protected string modelo ;
        protected int ano;


     public Veiculo(string marca, string modelo, int ano)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.ano = ano;
    }

    public void Ligar()
    {
        Console.WriteLine($"O {modelo} esta ligado");
    }

     public void Desliigado()
    {
        Console.WriteLine($"O {modelo} esta deligado");
    }
}
