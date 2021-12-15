using System;

namespace Kata_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var RadissonMembers = new MemberList(50);
            RadissonMembers.Sort();
            RadissonMembers.VerifiedOnly(RadissonVerified);
            
            Console.WriteLine(RadissonMembers);
            Console.WriteLine();

            var HiltonMembers = new MemberList(50);
            HiltonMembers.Sort();
            HiltonMembers.VerifiedOnly(HiltonVerified);

            Console.WriteLine(HiltonMembers);
            Console.WriteLine();

        }

        static public bool HiltonVerified(Member member)
        {
            return member.Level == MemberLevel.Platinum;
        }
        static public bool RadissonVerified(Member member)
        {
            return member.Level == MemberLevel.Blue;
        }

    }
    //Exercise
    //1.    Make the VerifiedOny() call with a Lambda Expression Method as a parameter
}
