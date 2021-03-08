using System;

namespace heist
{
    public class Member
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public float CourageFactor { get; set; }

        public void ListMember()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Skill Level: {SkillLevel}");
            Console.WriteLine($"Courage Factor: {CourageFactor}");
            Console.WriteLine("---------------------------------");

        }

    }
}