namespace GameApp
{
    public class HeroiMago : Heroi
    {
        public HeroiMago(string nome)
        {
            this.Nome = nome;
            this.Inteligencia *= 10;
            this.TipoHeroi = tipoHeroi.Mago;
        }

        public override string TentaDarDano(Heroi heroi)
        {
            Console.WriteLine(Atacar(heroi));
            Random random = new Random();
            int dano = random.Next(1, this.Inteligencia);
            if (dano > heroi.Agilidade)
            {
               heroi.Vida -= dano;
                return $"{this.Nome} causou {dano} de dano mágico em {heroi.Nome}";
            }
            else
            {
                return heroi.Defender(this);
            }
        }
        public override string Defender(Heroi heroi)
        {
            return $"{this.Nome} conseguiu defender o ataque de {heroi.Nome} com seu feitiço de defesa";
        }
        public override string Atacar(Heroi heroi)
        {
            return $"{this.Nome} atacou {heroi.Nome} com seu feitiço de bola de fogo";
        }
    }
}