using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1_Dedok
{
    //for task 2
    class Tvarina
    {
        public string Name { get; set; }
        public string Habitat { get; set; }
        public string Diet { get; set; }
        public Tvarina(string name, string habitat, string diet)
        {
            Name = name;
            Habitat = habitat;
            Diet = diet;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Ім'я: {Name}");
            Console.WriteLine($"Місце проживання: {Habitat}");
            Console.WriteLine($"Тип харчування: {Diet}");
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Habitat.GetHashCode() ^ Diet.GetHashCode();
        }
    }
    class Tygr : Tvarina
    {
        public int Speed { get; set; }
        public Tygr(string name, string habitat, string diet, int speed)
            : base(name, habitat, diet)
        {
            Speed = speed;
        }
        public virtual void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Швидкість: {Speed} км/год");
        }
        public override int GetHashCode()
        {
            return base.GetHashCode() ^ Speed.GetHashCode();
        }
    }
    class Krokodyl : Tvarina
    {
        public int Length { get; set; }
        public Krokodyl(string name, string habitat, string diet, int length)
            : base(name, habitat, diet)
        {
            Length = length;
        }
        public virtual void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Довжина: {Length} метрів");
        }
        public override int GetHashCode()
        {
            return base.GetHashCode() ^ Length.GetHashCode();
        }
    }
    class Kenguru : Tvarina
    {
        public int JumpHeight { get; set; }
        public Kenguru(string name, string habitat, string diet, int jumpHeight)
            : base(name, habitat, diet)
        {
            JumpHeight = jumpHeight;
        }
        public virtual void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Висота стрибка: {JumpHeight} метрів");
        }
        public override int GetHashCode()
        {
            return base.GetHashCode() ^ JumpHeight.GetHashCode();
        }
    }
}
