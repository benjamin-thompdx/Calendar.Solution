namespace Calendar
{
  public class LeapYear
  {
    public bool IsLeapYear(int year)
    {
      //Method that tests if a year is divisible by 400
      if (year % 400 == 0)
      {
        return true;
      }
      //Method that tests if a year is divisible by 100
      else if (year % 100 == 0)
      {
        return false;
      }
      else
      {
      //Method that tests if a year is divisible by 4
      return year % 4 == 0;
      }
    }
  }
}