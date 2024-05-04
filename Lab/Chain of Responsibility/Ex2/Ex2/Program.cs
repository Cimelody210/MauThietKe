using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Reflection.Metadata;

namespace Ex2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var goblin = new Creature { Name = "Goblin", Attack = 2, Defense = 2 };
            var keystone  = new Creature { Name ="godzilla", Attack = 3, Defense = 3 };
            var godxilla = new Creature { Name = "God", Attack = 1, Defense = 4 };

            var phongthu = new Creature { Name = "Krixi", Attack = 1, Defense = 20 };

            Console.WriteLine(goblin);
            Console.WriteLine(keystone);
            Console.WriteLine(godxilla);

            var root = new CreatureModifier(goblin);
            root.Add(new DoubleAttackModifier(goblin));
            root.Add(new DoubleAttackModifier(goblin));

            // Câu 2
            var defnese = new DoubleDefenseModifier(phongthu);
            defnese.Add(new DoubleDefenseModifier(phongthu));
            defnese.Add(new DoubleDefenseModifier(phongthu));

            root.Handle();
            Console.WriteLine(goblin);
        }
        public class Creature
        {
            public string Name {  get; set; }
            public int Attack {  get; set; }
            public int Defense {  get; set; }

            // Sample code
            public override string ToString()
            {
                return $"{nameof(Name)}: {Name}, {nameof(Attack)}: {Attack}, {nameof(Defense)}: {Defense}";
            }
        }
        public class CreatureModifier
        {
            protected Creature Creature;
            protected CreatureModifier Next;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
            public CreatureModifier(Creature creature)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
            {
                
            }
            public void Add(CreatureModifier cm)
            {
                if(Next != null)
                {
                    Next.Add(cm);
                }
                else
                {
                    Next = cm;
                }
            }
            // Add thêm key void
            public virtual void Handle()
            {
                Next?.Handle();
            }
        }
        public class DoubleAttackModifier: CreatureModifier
        {
            public DoubleAttackModifier(Creature creature): base(creature)
            {

            }
            public override void Handle()
            {
                Console.WriteLine($"Doubling {this.Creature.Name}'s attack");
                this.Creature.Attack *= 2;
                base.Handle();
            }
        }
        // Add new modifier named DoubleDefenseModifier. Update the code in the Program to utilize this newly added modifier
        public class DoubleDefenseModifier: CreatureModifier
        {
            public DoubleDefenseModifier(Creature creature): base(creature) { }
            public override void Handle()
            {
                this.Creature.Defense -= 4;
                Console.WriteLine($"defense in the range of  ( 0; {this.Creature.Defense})");
                base.Handle();
            }

        }
    }
}
