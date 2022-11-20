namespace ProgramingLangugesLab
{
    internal class Student
    {
        public string Name { get; set; } = string.Empty;
        public double Quiz { get; set; }
        public double Transactional { get; set; }
        public double Homework { get; set; }
        public double EndScoore
        {
            get
            {
                return
                    ((Quiz * 0.5) + (Transactional * 0.3) + (Homework * 0.2)) * 0.2;
            }
        }
    }
}