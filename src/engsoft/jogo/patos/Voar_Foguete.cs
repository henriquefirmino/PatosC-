namespace engsoft.jogo.patos
{
	public class Voar_Foguete : Padrao_Voaveis
	{

		private double velocidade;

		public Voar_Foguete()
		{
			velocidade = 1000;
		}

		public virtual string voar()
		{
			return "Voando como um foguete. Velocidade: " + Velocidade;
		}

		public virtual double Velocidade
		{
			get
			{
				return velocidade;
			}
		}
	}

}