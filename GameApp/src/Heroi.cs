namespace GameApp
{
    public abstract class Heroi

    {
        public enum tipoHeroi {Mago, Guerreiro, Arqueiro};
        private string nome;
        private int forca = 10;
        private double vida = 100;
        private int agilidade= 10;
        private int inteligencia= 10;
        private int nivel = 1;
        internal tipoHeroi TipoHeroi;
        public string Nome { get => nome; set => nome = value; }
        public int Forca { get => forca; set => forca = value; }
        public double Vida { get => vida; set => vida = value; }
        public int Agilidade { get => agilidade; set => agilidade = value; }
        public int Inteligencia { get => inteligencia; set => inteligencia = value; }
        public int Nivel { get => nivel; set => nivel = value; }

        public virtual string Atacar(Heroi heroi)
        {
            return $"{this.Nome} atacou {heroi.Nome}";
        }
        public virtual string Defender(Heroi heroi)
        {
            return heroi.Defender(this);
        }
        public virtual string TentaDarDano(Heroi heroi)
        {
            Console.WriteLine(Atacar(heroi));
            Random random = new Random();
            int dano = random.Next(1, this.Forca*3);
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
    }
}