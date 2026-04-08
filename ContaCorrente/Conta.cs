class Conta
{

    private string titular;
    private int ID;
    private double saldo;

    private List<string> extrato = new List<string>();

    public Conta(string titular, int ID, double saldo)
    {
        this.titular = titular;
        this.ID = ID;
        this.saldo = saldo;
    }

    public string GetTitular()
    {
        return titular;
    }

    public int GetID()
    {
        return ID;
    }

    public double GetSaldo()
    {
        return saldo;
    }

    public void Depositar(double valor)
    {
        saldo += valor;

        extrato.Add($"Crédito de: R${valor}, Saldo atualizado: R${saldo}");

    }

    public void ExibirExtrato()
    {
        Console.WriteLine($"Extrato da conta de {titular}:");
        
        foreach (string operacao in extrato)
        {
            Console.WriteLine(operacao);
        }
    }

    public bool Sacar(double valor)
    {

        double pivo = saldo;

        pivo = saldo - valor;

        if (pivo >= -200)
        {
            saldo -= valor;

            extrato.Add($"Débito de: R${valor}, Saldo atualizado: R${saldo}");

            return true;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente / Limite Débito excedido.");
            return false;
        }
    }

    public void Transferir(Conta contaDestino, double valorTransferencia)
    {
        bool verifica = Sacar(valorTransferencia);
        if (verifica == true)
        {
            contaDestino.Depositar(valorTransferencia);

            extrato.Add($"Débito de: R${valorTransferencia}, Saldo atualizado: R${saldo}");

            Console.WriteLine("Transferência realizada com sucesso.");
        }
        else
        {
            Console.WriteLine("Transferência não realizada.");
        }
    }

}