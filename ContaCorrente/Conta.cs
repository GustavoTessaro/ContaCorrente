class Conta
{

    private string titular;
    private int ID;
    private double saldo;

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
    }

    public bool Sacar(double valor)
    {

        double pivo = saldo;

        pivo = saldo - valor;

        if (pivo >= -200)
        {
            saldo -= valor;
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
            Console.WriteLine("Transferência realizada com sucesso.");
        }
        else
        {
            Console.WriteLine("Transferência não realizada.");
        }
    }

}