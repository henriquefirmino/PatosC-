namespace engsoft.jogo.patos
{
	public class Voaveis_Asa : Padrao_Voaveis
	{

		private double velocidade;

		public Voaveis_Asa()
		{
			velocidade = 10;
		}

		public virtual string voar()
		{
			return "Voando como um p�ssaro que voa. Velocidade: " + Velocidade;
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