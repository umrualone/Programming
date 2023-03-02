public class Discipline
{
    private string nameDiscipline;
    private string nameTeacher;
    private int semesterNumber;
    private int semesterGrade;

    public Discipline(string nameDiscipline, string nameTeacher, int semesterNumber, int semesterGrade)
    {
        NameDiscipline = nameDiscipline;
        NameTeacher = nameTeacher;
        SemesterNumber = semesterNumber;
        SemesterGrade = semesterGrade;
    }

    public Discipline()
    {
        NameDiscipline = null;
        nameTeacher = null;
        SemesterNumber = 1;
        SemesterGrade = 2;
    }
    public string NameDiscipline
    {
        get => nameDiscipline;
        set => nameDiscipline = value;
    }
    
    public string NameTeacher
    {
        get => nameTeacher;
        set => nameTeacher = value;
    }

    public int SemesterNumber
    {
        get => semesterNumber;
        set
        {
            if (value <= 0 || value > 8)
                throw new System.ArgumentException("Номер семастра от 1 до 8");
            else
                semesterNumber = value;
        }
    }

    public int SemesterGrade
    {
        get => semesterGrade;
        set
        {
            if (value < 2 || value > 5)
                throw new System.ArgumentException("Оценка от 2 до 5");
            else
                semesterGrade = value;
        }
    }
}
