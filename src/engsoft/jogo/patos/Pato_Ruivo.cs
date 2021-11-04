namespace engsoft.jogo.patos
{
	public class Pato_Ruivo : Pato, Padrao_Grasnar
	{

		public Pato_Ruivo()
		{
			Comportamento = new Voaveis_Asa();
		}

		public override string mostrar()
		{
			return "Eu sou o Pato Ruivo.";
		}

		public virtual string grasnar()
		{
			// TODO Auto-generated method stub
			return "Que-Que.";

		}

	}

}