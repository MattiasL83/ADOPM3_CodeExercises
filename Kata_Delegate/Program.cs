using System;

namespace Kata_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var hotelMembers = new MemberList(50);
            hotelMembers.Sort();

            hotelMembers.VerifiedOnly(RadissonVerified);
            
            Console.WriteLine(hotelMembers);
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
}
