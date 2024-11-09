namespace _2._1;

public class Employee
{
   private string _name;
   private double _hourlyRate;
   private int _timeWork;

   public Employee(string name, double hourlyRate, int timeWork)
   {
      _name = name;
      _hourlyRate = hourlyRate;
      _timeWork = timeWork;
   }

   public string Name
   {
      get => _name;
      set => _name = value ?? throw new ArgumentNullException(nameof(value));
   }

   public double HourlyRate
   {
      get => _hourlyRate;
      set { if (value > 0) _hourlyRate = value; }
   }

   public int TimeWork
   {
      get => _timeWork;
      set { if (value > 0) _timeWork = value; }
   }
}