namespace InheritanceTask
{
    public class JuniorManager:Manager
    {
        private int hoursWorked;
        public decimal Bonus = 300M;

        public JuniorManager(string name, decimal baseSalary, int hoursWorked): base(name, baseSalary)
        {
            HoursWorked = hoursWorked;
        }
        public int HoursWorked
        {
            get { return hoursWorked; }
            set { 
                if(value > 0){
                    hoursWorked = value;
                }
                }
        }

        public override decimal Salary()
        {
            if(HoursWorked > 180){
                return BaseSalary + Bonus;
            }else{
                return BaseSalary;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}:\nHours Worked:{HoursWorked}\nBase Salary:{BaseSalary:C}\nBonus:{Bonus:C}";
        }
    }
}