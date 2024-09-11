namespace Calculadora.Services
{
    public class CalculadoraServico
    {
        private List<string> historico = new List<string>();

        public int Somar(int num1, int num2)
        {
            historico.Insert(0, $"{DateTime.Now}: {num1 + num2}");
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            historico.Insert(0, $"{DateTime.Now}: {num1 - num2}");

            return num1 - num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            historico.Insert(0, $"{DateTime.Now}: {num1 * num2}");

            return num1 * num2;
        }

        public int Dividir(int num1, int num2)
        {
            historico.Insert(0, $"{DateTime.Now}: {num1 / num2}");

            return num1 / num2;
        }

        public List<string> RetornaHistorico()
        {
            historico.RemoveRange(3, historico.Count - 3);
            return historico;
        }
    }
}