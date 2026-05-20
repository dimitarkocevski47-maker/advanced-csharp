
using LinqMethods.Data;
using LinqMethods.Entities;

// LINQ with lambda
IEnumerable<Student> findBobsLambda = SEDC.Students
    .Where(s => s.FirstName.Equals("Bob", StringComparison.OrdinalIgnoreCase));

// SQL-like LINQ
IEnumerable<Student> findBobsSql = from s in SEDC.Students
                                   where s.FirstName == "Bob"
                                   select s;


IEnumerable<string> firstNames = SEDC.Students.Select(s => s.FirstName);

// EXAMPLE: GET STUDENTS WHICH ARE PART-TIME AND HAVE SUBJECTS FROM THE PROGRAMMING ACADEMY

// SQL like syntax complex example
IEnumerable<Student> programmingStudentsSqlLike = from student in SEDC.Students
                                                  where student.IsPartTime
                                                  && (from subject in student.Subjects
                                                      where subject.Type == Academy.Programming
                                                      select subject).Count() != 0
                                                  select student;

// Lambda complex example
List<Student> programmingStudentsLambda = SEDC.Students
    .Where(s => s.IsPartTime
    && s.Subjects.Any(sub => sub.Type == Academy.Programming))
    .ToList();

Student petko = SEDC.Students.FirstOrDefault(s => s.FirstName == "Petko");

Student bob = SEDC.Students.SingleOrDefault(s => s.FirstName == "Bob");