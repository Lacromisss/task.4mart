using System;

namespace ConsoleApp36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MeetingSchedule musiMeet = new MeetingSchedule();
            try
            {
                musiMeet.SetMeeting("rezerv meeting falan", new DateTime(1941, 05, 3, 10, 05, 06), new DateTime(1945, 09, 9, 20, 05, 06));
               
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

           
        }
    }
}