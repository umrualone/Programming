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
                Validator.AssertValueInRange(value, "SemesterNumber", 1, 8);
                _semesterNumber = value;
            }
        }

        public int SemesterGrade
        {
            get => _semesterGrade;
            set
            {
                Validator.AssertValueInRange(value, "SemesterGrade", 2, 5);
                _semesterGrade = value;
            }
        }
    }
}