using System;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            Member recruit = new Member();

            Console.WriteLine("Enter a team member's name: ");
            recruit.Name = Console.ReadLine();

            Console.WriteLine("Enter a team member's skill level: ");
            recruit.SkillLevel = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a team member's courage factor: ");
            recruit.CourageFactor = float.Parse(Console.ReadLine());

            recruit.ListMember();
        }
    }
}
