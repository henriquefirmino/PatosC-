using System;

namespace engsoft.jogo.patos
{
	public class Main
	{

		public static void Main(string[] args)
		{
			Pato pt = new Pato_Ruivo();

			Console.WriteLine(pt.mostrar());
			Console.WriteLine(pt.nadar());
			Console.WriteLine(pt.comportamento_pato());

			pt.Comportamento = new Voar_Foguete();

			Console.WriteLine(pt.comportamento_pato());
		}

	}

}