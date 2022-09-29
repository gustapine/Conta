Console.Clear();

Conta contaZeComeia = new Conta("123", "Zé Comeia", 500);
contaZeComeia.retirar(145, DateTime.Now, "Pagamento da conta de luz");
Console.WriteLine( contaZeComeia.mostrarDados() );
Console.WriteLine();
Console.ReadKey();
// cada objeto tem seu proprio conjunto de propriedades
Conta contaCatatau = new Conta("456", "Catatau", 340);
contaCatatau.retirar(45, DateTime.Now, "Camiseta do curso de engenharia de soft");
Console.WriteLine(contaCatatau.mostrarDados());
Console.WriteLine();
Console.ReadKey();

Conta contaZelele = new Conta("678", "Zelele", 470);

Console.WriteLine("Contas criadas : "+ Conta.quantContas); //cai na prova = o atributo não é da classe, mas do objeto
Console.ReadKey();
