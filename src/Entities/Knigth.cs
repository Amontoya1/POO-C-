namespace JogoC.src.Entities
{
    public class Knigth : Hero
    {
        public Knigth(string name, int level, string type) : base(name, level, type)
        {
        }

        public override string Attack()
        {
            return this.Name + " Attacking with " + this.HeroType + "!";
        }
    }
}