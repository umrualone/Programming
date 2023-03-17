namespace Programming.Model.Classes
{
    public class Discipline
    {
        private string _nameDiscipline;
        private string _nameTeacher;
        private int _semesterNumber;
        private int _semesterGrade;

        public Discipline(string nameDiscipline, string nameTeacher, int semesterNumber, int semesterGrade)
        {
            NameDiscipline = nameDiscipline;
            NameTeacher = nameTeacher;
            SemesterNumber = semesterNumber;
            SemesterGrade = semesterGrade;
        }

        public Discipline() { }
    
        public string NameDiscipline
        {
            get => _nameDiscipline;
            set => _nameDiscipline = value;  
        }
    
        public string NameTeacher
        {       
            get => _nameTeacher;
            set => _nameTeacher = value;
        }

        public int SemesterNumber
        {
            get => _semesterNumber;
            set
            {
                if (value <= 0 || value > 8)
                {
                    throw new System.ArgumentException("Номер семастра от 1 до 8");
                }
                else
                {
                    _semesterNumber = value;   
                }
            }
        }

        public int SemesterGrade
        {
            get => _semesterGrade;
            set
            {
                if (value < 2 || value > 5)
                {
                    throw new System.ArgumentException("Оценка от 2 до 5");   
                }
                else
                {
                    _semesterGrade = value;
                }
            }
        }
    }
}