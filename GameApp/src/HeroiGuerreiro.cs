namespace GameApp
{
    public class HeroiGuerreiro : Heroi
    {
        public HeroiGuerreiro(string nome)
        {
            this.Nome = nome;
            this.Forca *= 5;
            this.TipoHeroi = tipoHeroi.Guerreiro;
        }
        public override string Defender(Heroi heroi)
        {
            return $"{this.Nome} conseguiu defender o ataque de {heroi.Nome} com seu escudo de madeira";
        }
        public override string Atacar(Heroi heroi)
        {
            return $"{this.Nome} atacou {heroi.Nome} com seu machado gigante";
        }
    }
}