namespace engsoft.jogo.patos
{
	public class Pato_Borracha : Pato
	{

		public Pato_Borracha()
		{
			Comportamento = new Nao_Voa();
		}

		public override string mostrar()
		{
			return "Ol�, eu sou de Boarracha.";
		}

	}

}