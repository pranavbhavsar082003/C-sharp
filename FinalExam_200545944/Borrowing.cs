using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExam_200545944
{
    public class Borrowing : IDownloadable
    {
        public Borrowing()
        {

        }
        public Borrowing(string UserId, List<string> resources)
        {

        }

        public static void ReturnResources(DateTime date)
        {
            Borrowing borrowing = new Borrowing();

            if (date > borrowing.EndDate)
            {
                Console.WriteLine("User must pay fine");
                borrowing.PickedUp = true;
            }
            else
            {
                Console.WriteLine("Thaks");

                borrowing.PickedUp = true;
            }


        }

        public DateTime StartDate;
        public string UserId;
        public int ReferenceNumber;
        public bool PickedUp;
        public List<string> Resources;
        public DateTime EndDate;

        public string GenerateAccessLink()
        {
            return "link is here....";
        }

    }
}
