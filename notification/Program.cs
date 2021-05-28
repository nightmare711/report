using System;

namespace notification
{
    class Program
    {
        static void Main(string[] args)
        {
            Account teacherAccount = new TeacherAccount(new TeacherNotification());
            Account studentAccount = new StudentAccount(new StudentNotification());
            teacherAccount.addNotification();
            studentAccount.addNotification();
        }
    }
}
