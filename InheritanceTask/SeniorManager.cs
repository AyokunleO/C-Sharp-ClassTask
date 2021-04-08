namespace InheritanceTask
{
    public class SeniorManager:Manager
    {
        private int perfEval;
        public SeniorManager(string name, decimal baseSalary, decimal bonus, int perfEval): base(name, baseSalary, bonus)
        {
            PerfEval = perfEval;
        }
        public int PerfEval
        {
            get { return perfEval; }
            set { 
                if(value >= 0){
                    perfEval = value;
                }
            }
        }

        public override decimal Salary()
        {
            if(PerfEval > 6){
                return BaseSalary + Bonus;
            }else{
                return BaseSalary;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}:\nPerformance Evaluation:{PerfEval}\nBase Salary:{BaseSalary:C}\nBonus:{Bonus:C}";
        }        
    }
}