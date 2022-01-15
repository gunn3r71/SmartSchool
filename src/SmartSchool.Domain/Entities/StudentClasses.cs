namespace SmartSchool.Domain.Entities
{
    public class StudentClasses : Entity
    {
        protected StudentClasses()
        {
        }

        public StudentClasses(int studentId, 
                              int classId)
        {
            StudentId = studentId;
            ClassId = classId;
        }

        public int StudentId { get; private set; }
        public int ClassId { get; private set; }
        public Student Student { get; private set; }
        public Class Class { get; private set; }
    }
}