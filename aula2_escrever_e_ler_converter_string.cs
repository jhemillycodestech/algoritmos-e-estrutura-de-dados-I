using System;
class HelloWorld {
  static void Main() {
      
    //comando para escrever uma mensagem em unica linha  
    Console.WriteLine("Olá Mundo!");
    Console.WriteLine("Lorem ipsum bla bla tres");
    
       
    //comando para escrever várias mensagens na mesma linha
    //até que eu quebre a linha com um Console.WriteLine
        Console.Write("My ");
        Console.Write("Brother ");
        Console.Write("Was Really ");
        Console.Write("Sad ");
        Console.WriteLine("That made me happy");
        Console.WriteLine();
        Console.WriteLine("Informe seu nome");
        
    //Console.ReadLine lê entrada do usuário
    string nome; //variavel do tipo string
    nome = Console.ReadLine().ToString(); 
    //está convertendo a entrada do usário para string
    Console.WriteLine(nome);
    
  
    
  }
}
