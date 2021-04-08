namespace InheritanceTask
{
    public abstract class Manager:Employee
    {
        private decimal baseSalary;
        private decimal bonus;
        
        public Manager(string name, decimal baseSalary, decimal bonus): base(name)
        {
            BaseSalary = baseSalary;
            Bonus = bonus;
        }
        public decimal Bonus
        {
            get { return bonus; }
            set { 
                if(value>0){
                    bonus = value;
                }
                }
        }
        public decimal BaseSalary
        {
            get { return baseSalary; }
            set { 
                if(value > 0)
                {
                    baseSalary = value;
                }
                }
        }
        public override decimal Salary()
        {
            return BaseSalary + Bonus;
        }

        // public override string ToString()
        // {
        //     return $"{base.ToString()}:\nBase Salary:{BaseSalary}\nBonus:{Bonus}";
        // }
    }
}