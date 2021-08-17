using System;


namespace StructureAndEnum
{
    class EnumDemo
    {
        //  This program demo. how to use Enum
        static void Main()
        {
            Console.WriteLine("State={0} and Code={1}",gstStateCodes.MH,gstStateCodes.MH.GetHashCode());
            Console.WriteLine("State={0} and Code={1}", gstStateCodes.AP, gstStateCodes.AP.GetHashCode());
            
            foreach(var state in Enum.GetValues(typeof(gstStateCodes)))
            {
                Console.WriteLine("State={0} and Code={1}",state,state.GetHashCode());
            }

            // How to pass enum  as param. for functions
            Employee emp = new Employee(101,"Scott",Gender.Male);
            Console.WriteLine(emp.Display());
            Console.ReadLine();
        }
    }
}
