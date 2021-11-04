namespace engsoft.jogo.patos
{
	public class Nao_Voa : Padrao_Voaveis
	{


		public Nao_Voa()
		{

		}

		public virtual string voar()
		{
			return "Esse pato n�o Voa. Velocidade: " + Velocidade;
		}

		public virtual double Velocidade
		{
			get
			{
				return 0;
			}
		}

	}

}