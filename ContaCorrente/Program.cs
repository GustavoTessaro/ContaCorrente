using System.Threading;

class Program
{

    static void Main(string[] args)
    {

        Conta conta1 = new Conta("Gustavo", 123, 1000);
        Conta conta2 = new Conta("Tiago", 456, 1000);

        int opcao = 0;

        do
        {
            Console.Clear();
            Console.WriteLine("1 - Saque");
            Console.WriteLine("2 - Depósito");
            Console.WriteLine("3 - Consultar Saldos das contas");
            Console.WriteLine("4 - Consultar Extrato");
            Console.WriteLine("5 - Transferência");
            Console.WriteLine("6 - Sair");
            opcao = (int)char.GetNumericValue(Console.ReadKey(true).KeyChar);

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite o valor do saque:");
                    double valorSaque = Convert.ToDouble(Console.ReadLine());
                    conta1.Sacar(valorSaque);
                    break;
                case 2:
                    Console.WriteLine("Digite o valor do depósito:");
                    double valorDeposito = Convert.ToDouble(Console.ReadLine());
                    conta1.Depositar(valorDeposito);
                    break;
                case 3:
                    Console.WriteLine($"Saldo atual da conta {conta1.GetTitular()}: {conta1.GetSaldo()}");
                    Console.WriteLine($"Saldo atual da conta {conta2.GetTitular()}: {conta2.GetSaldo()}");
                    Thread.Sleep(3000);
                    while (Console.KeyAvailable) Console.ReadKey(true);
                    break;
                case 4:
                    conta1.ExibirExtrato();
                    Thread.Sleep(3000);
                    while (Console.KeyAvailable) Console.ReadKey(true);
                    break;
                case 5:
                    Console.WriteLine("Digite o valor da transferência:");
                    double valorTransferencia = Convert.ToDouble(Console.ReadLine());
                    conta1.Transferir(conta2, valorTransferencia);
                    Thread.Sleep(3000);
                    while (Console.KeyAvailable) Console.ReadKey(true);
                    break;
                case 6:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    Thread.Sleep(1000);
                    while (Console.KeyAvailable) Console.ReadKey(true);
                    break;
            }

        } while (opcao != 6);

    }

}