
namespace Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
           
        }
    }

    public class Plant
    {
        public string Name { get; set; }
        public int ApproxLife { get; set; }
        public int Age { get; set; }

        public virtual void GrowPlant() {
            Console.WriteLine("Plant is growing.");
        }
    }

    public class Tree : Plant
    {
        public bool FruitTree {  get; set; }
        public bool WildTree { get; set; }
        public override void GrowPlant()
        {
            Console.WriteLine("Tree is growing.");
        }
    }

    public class Flower : Plant
    {
        private bool _isPrickly;
        public bool IsPrickly { get; set; }
        public override void GrowPlant()
        {
            Console.WriteLine($"{Name} is growing. Is prickly?: {_isPrickly}");
        }
    }


    public class AppleTree : Tree
    {
        private bool _isSour;
        public bool IsSour { get; set; }
        public override void GrowPlant()
        {
            Console.WriteLine($"Apple tree is growing. Is sour?: {_isSour} ");
        }

    }
}
