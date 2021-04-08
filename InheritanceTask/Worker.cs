namespace InheritanceTask
{
    public class Worker: Employee
    {
        private int hoursPerMonth;
        private decimal amountPerHour;
        public Worker(string name, int hours, decimal amount): base(name)
        {
            HoursPerMonth = hours;
            AmountPerHour = amount;   
        }
        public decimal AmountPerHour
        {
            get { return amountPerHour; }
            set { amountPerHour = value; }
        }
        
        public int HoursPerMonth
        {
            get { return hoursPerMonth; }
            set { 
                if(value > 0){
                hoursPerMonth = value;
                }
                }
        }

        public override decimal Salary()
        {
            return HoursPerMonth * AmountPerHour;
        }

        public override string ToString()
        {
            return $"{base.ToString()}:\nHours Worked:{HoursPerMonth}\nAmount Per Hour:{AmountPerHour:C}";
        }

    }
}