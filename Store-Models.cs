using System;
using LojaVirtual.Modelos;

class HelloWorld {
	static void Main() {
		Produto p1 = new Produto();

		double valorFinal = p1.CalcularValorComDesconto(9.90);
		Console.WriteLine(valorFinal);
	}
}
