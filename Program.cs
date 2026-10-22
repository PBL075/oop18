using System;

namespace proje
{
    class Program
    {
        static void Attack()
        {
            Console.WriteLine("Atac normal ai dat: 10 damage");
        }
        static void Attack(int criticalMultiplier)
        {
            int finalDamage = 10 * criticalMultiplier;
            Console.WriteLine("Atatc critic: Ai dat "+ finalDamage + " damage ");
        }
        static void Attack(string attackName , int bonus)
        {
            int finalDamage = 10+bonus;
            Console.WriteLine("Ales: "+ attackName + "Damage total: "+ finalDamage);


        }
        static void Main()
        {
            Attack();
            Attack(3);
            Attack("Super",50);

        }
    }
}