using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExam_200545944
{
    internal class Program
    {
        public static void Main(string[] args)
        {//student id 200545944
            Student student = new Student();
            Standard standard = new Standard();
            student.SchoolId = 1;
            //student card number declaration
            student.SchoolCardNbr = "B584565415";
            //postal code
            standard.PostCode = "L4M7C2";
            //library card number 
            standard.LibraryCardNbr = "571582158263";
            Borrowing borrowing = new Borrowing();
            Borrowing borrowing = new Borrowing("1", borrowing.Resources);
            borrowing.StartDate = DateTime.Now;
            borrowing.EndDate = borrowing.StartDate.AddDays(10);
        }
    }
}
