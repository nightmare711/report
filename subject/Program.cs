using System;

namespace subject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add subject with teacher's account!");
            Subject teacherAccount = SubjectFactory.getAccount(AccountType.TEACHER);
            teacherAccount.addSubject("Mathematics");
            Console.WriteLine("Added subject with student's account!");
            Subject studentAccount = SubjectFactory.getAccount(AccountType.STUDENT);
            studentAccount.addSubject("Mathematics");
        }
    }
    public enum AccountType
    {
        TEACHER, STUDENT
    }
}
