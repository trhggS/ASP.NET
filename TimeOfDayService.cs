namespace lr3
{
    public class TimeOfDayService
    {
        public string GetTimeOfDay()
        {
            var currentTime = DateTime.Now;
            if (currentTime.Hour >= 6 && currentTime.Hour < 12)
            {
                return "зараз ранок";
            }
            else if (currentTime.Hour >= 12 && currentTime.Hour < 18)
            {
                return "зараз день";
            }
            else if (currentTime.Hour >= 18 && currentTime.Hour < 24)
            {
                return "зараз вечір";
            }
            else
            {
                return "зараз ніч";
            }
        }
    }
}
