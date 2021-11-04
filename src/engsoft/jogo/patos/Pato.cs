namespace engsoft.jogo.patos
{
	public abstract class Pato
	{

//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods of the current type:
		protected internal Padrao_Voaveis comportamento_pato_Conflict;

		internal abstract string mostrar();

		public virtual string nadar()
		{
			return "Pato Nadando.";
		}

		public virtual Padrao_Voaveis Comportamento
		{
			set
			{
				comportamento_pato_Conflict = value;
			}
		}

		public virtual string comportamento_pato()
		{
			return comportamento_pato_Conflict.voar();
		}
	}

}