namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о дисциплине.
    /// </summary>
    public class Discipline
    {
        /// <summary>
        /// Номер семестра.
        /// </summary>
        private int _semesterNumber;
        /// <summary>
        /// Оценка за семестр.
        /// </summary>
        private int _semesterGrade;

        /// <summary>
        /// Создает экземпляр класса Discipline.
        /// </summary>
        /// <param name="nameDiscipline">Название дисциплины.</param>
        /// <param name="nameTeacher">Имя преподавателя.</param>
        /// <param name="semesterNumber">Номер семестра. Должен быть в диапазоне от 1 до 8.</param>
        /// <param name="semesterGrade">Оценка за семестр. Должна быть в диапазоне от 2 до 5.</param>
        public Discipline(string nameDiscipline, string nameTeacher, int semesterNumber, int semesterGrade)
        {
            NameDiscipline = nameDiscipline;
            NameTeacher = nameTeacher;
            SemesterNumber = semesterNumber;
            SemesterGrade = semesterGrade;
        }
        
        /// <summary>
        /// Создает экземпляр класса Discipline.
        /// </summary>
        public Discipline() { }
    
        /// <summary>
        /// Возвращает и задает название дисциплины.
        /// </summary>
        public string NameDiscipline { get; set; }

        /// <summary>
        /// Возвращает и задает имя преподавателя.
        /// </summary>
        public string NameTeacher { get; set; }

        /// <summary>
        /// Возвращает и задает номер семестра. Должен быть в диапазоне от 1 до 8.
        /// </summary>
        public int SemesterNumber
        {
            get => _semesterNumber;
            set
            {
                Validator.AssertValueInRange(value, nameof(SemesterNumber), 1, 8);
                _semesterNumber = value;
            }
        }

        /// <summary>
        /// Возвращает и задает оценку за семестр. Должна быть в диапазоне от 2 до 5.
        /// </summary>
        public int SemesterGrade
        {
            get => _semesterGrade;
            set
            {
                Validator.AssertValueInRange(value, nameof(SemesterGrade), 2, 5);
                _semesterGrade = value;
            }
        }
    }
}