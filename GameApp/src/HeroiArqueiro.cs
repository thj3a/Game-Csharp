namespace GameApp
{
    public class HeroiArqueiro : Heroi
    {
        public HeroiArqueiro(string nome)
        {
            this.Nome = nome;
            this.Agilidade *= 5;
            this.Inteligencia *= 2;
            this.TipoHeroi = tipoHeroi.Arqueiro;
        }
        public override string TentaDarDano(Heroi heroi)
        {
            Console.WriteLine(Atacar(heroi));
            Random random = new Random();
            int dano = random.Next(1, this.Inteligencia*3+this.Agilidade);
            if (dano > heroi.Agilidade)
            {
               heroi.Vida -= dano;
                return $"{this.Nome} causou {dano} de dano em {heroi.Nome}";
            }
            else
            {
                return heroi.Defender(this);
            }
        }
        public string TentaDarDano(Heroi heroi, int bonus)
        {
            Console.WriteLine(Atacar(heroi));
            Random random = new Random();
            int dano = random.Next(1, this.Inteligencia*3+this.Agilidade+bonus);
            if (dano > heroi.Agilidade)
            {
               heroi.Vida -= dano;
                return $"{this.Nome} causou {dano} de dano em {heroi.Nome}";
            }
            else
            {
                return heroi.Defender(this);
            }
        }
        public override string Atacar(Heroi heroi)
        {
            return $"{this.Nome} atacou {heroi.Nome} com uma rajada de flechas";
        }
        public override string Defender(Heroi heroi)
        {
            return $"{this.Nome} conseguiu defender o ataque de {heroi.Nome} com seu arco";
        }
    }
}