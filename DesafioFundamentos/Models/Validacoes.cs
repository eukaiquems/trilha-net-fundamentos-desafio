namespace DesafioFundamentos.Models
{
    public class Validacoes
    {
        public static bool ValidarPlaca(string placa)
        {
            bool placaValida = true;
            int totalDigitos = 7;

            if (string.IsNullOrWhiteSpace(placa))
            {
                Console.WriteLine("Nenhum valor informado! Tente novamente");
                placaValida = false;
            }
            else if (placa.Length > totalDigitos)
            {
                Console.WriteLine($"Placa inválida! Confira se digitou a placa corretamente, uma placa válida contem {totalDigitos} digitos");
                placaValida = false;
            }

            return placaValida;
        }
    }
}
