class Conta{
    //atributos estáticos
    
    public static int quantContas = 0;


    //atributos
    List<Transacao> movimentacao = new List<Transacao>();// nessa lista vai ter transação
    public string numero;
    public string titular;
    
    public decimal saldo{
        //programar como vai se comportar
       
        get{
            decimal valorFinal = 0;
            foreach(Transacao transacao in movimentacao){
                valorFinal += transacao.valor;
            }
            return valorFinal;
        }
    }
    //construtor
    public Conta(string num, string tit, decimal sal){
        this.numero = num;
        this.titular = tit;
        this.depositar(sal, DateTime.Now, "Deposito Incial");
        //propriedade estática não usa o this na frente
        quantContas++;
    }

    //métodos
    public string mostrarDados(){
        string texto ="";

        texto += "Conta " + this.numero;
        texto += " do correntista " + this.titular;
        texto += " com saldo de " + this.saldo.ToString();

        return texto;
    }

    public void depositar(decimal val, DateTime dat, string mot ){
        Transacao deposito = new(val, dat, mot);
        this.movimentacao.Add(deposito);
    }

    public void retirar(decimal val, DateTime dat, string mot){
        Transacao saque = new Transacao(-val, dat, mot);
        this.movimentacao.Add(saque);
    }
    
}