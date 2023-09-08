using System.Diagnostics.Metrics;

namespace DistanceTime
{
    class Program
    {
        static void Main(string[] args)
        {   
            //declared several single precision floating point variables distance , time and speed values
            float distance;
            float hour, min, sec;
            float timeSec;
            float mps;
            float kph, mph;
            //displays and prompts to enter input distance in meters
            Console.Write("Input distance(metres): ");
           //reads input and converts to single precision floating point number and stores in varibale distance
            distance = Convert.ToSingle(Console.ReadLine());

            Console.Write("Input timeSec(hour): ");
            hour = Convert.ToSingle(Console.ReadLine());

            Console.Write("Input timeSec(minutes): ");
            min = Convert.ToSingle(Console.ReadLine());

            Console.Write("Input timeSec(seconds): ");
            sec = Convert.ToSingle(Console.ReadLine());

          //calculate the total timesecs by converting input for hours and mintues into sec and adds them together
            timeSec = (hour * 3600) + (min * 60) + sec;

            //calculates the speed in meter per sec by dividing distance by total in timesec
            mps = distance / timeSec;

            //calculates the speed in kph by converting the distance from meters to kilometers
            // (divide by 1000)and dividing by the total time in hours(secs to hrs)
            kph = (distance / 1000.0f) / (timeSec / 3600.0f);

            //converting the speed from kilometer per hour to miles per hour by using conversation factor
            mph = kph / 1.609f;

           // displays calculated speed in meters per sec,kilometers per hours and miles per hour
           // and insert the calculated values
            Console.WriteLine("Your speed in metres/sec is {0}", mps);
            Console.WriteLine("Your speed in km/h is {0}", kph);
            Console.WriteLine("Your speed in miles/h is {0}", mph);
        }
    }
}