using System;

namespace StructureAndEnum
{
   //   Enum is list of constants,it can accept constant of type Int16,Int32 and Int64 only. 
    enum gstStateCodes
    {
        GJ=24,MH=27,AP,DL=7
    }

    enum Gender
    {
        Male,Female
    }

    class Employee
    {
        public int EmpCode { get; set; }
        public string EmpName { get; set; }
        public Gender EmpGender { get; set; }

        public Employee(int EmpCode,string EmpName,Gender EmpGender)
        {
            this.EmpCode = EmpCode;
            this.EmpName = EmpName;
            this.EmpGender = EmpGender;
        }

        public string Display()
        {
           return string.Format("Code={0} Name={1} Gender={2}",EmpCode,EmpName,EmpGender);
        }
    }
}
