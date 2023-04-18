namespace EnumImplementation
{
    // Without dataType
       enum Days
        {
            Monday = 1, Tuesday = 11, Wednesday = 112, Thursday = 123, Friday = 132, Saturday = 143
        }

    

    // Without dataType
        /*enum Days : byte
        {
            Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday
        }*/
    class Program
    {
        public static Days MeetingDay { get; set; } = Days.Monday; // This is default like MeetingDay is monday...
        static void Main(string[] args)
        {
            /*Console.WriteLine(MeetingDay);

            MeetingDay = Days.Wednesday; // Updating the meetingDay.....

            Console.WriteLine(MeetingDay);*/
            // Inside foreach loop defined the datatype of the enum if you defined explicitly while creating the enum..
            foreach (string day in Enum.GetNames(typeof(Days)))
            {
                Console.WriteLine(day);
            }

            /* foreach (int i in Enum.GetValues(typeof(Days)))
             {
                 Console.WriteLine(i);
             }

             foreach (int i in Enum.GetValues(typeof(Days)))
             {
                 Console.WriteLine($"{i} : {(Days)i} ");
             }*/
            /*Days days = 0;
            Console.WriteLine(days);*/
        }
    }
}