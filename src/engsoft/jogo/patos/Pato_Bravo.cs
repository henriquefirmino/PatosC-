namespace engsoft.jogo.patos
{
	public class Pato_Bravo : Pato, Padrao_Grasnar
	{

		public Pato_Bravo()
		{
			Comportamento = new Voaveis_Asa();
		}

		public override string mostrar()
		{
			return "Eu sou o Pato Bravo.";
		}

		public virtual string grasnar()
		{
			return "Que-Que. Grrrrrrrrr.";
		}

	}

}