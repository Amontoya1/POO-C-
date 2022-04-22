namespace JogoC.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string type) : base(name, level, type)
        {
        }

        public override string Attack()
        {
            return  this.Name + " Attacking with " + this.HeroType + "!";
        }

        public string Attack(int Bonus){
            if (Bonus > 6){
                return this.Name + " Attacking with strong " + this.HeroType + "!" + " with bonus " + Bonus + "!";
            } else
            {
                return this.Name + " Attacking with weack" + this.HeroType + "!" + " with bonus " + Bonus;
            }
        }
    }
}