using System;

namespace oopsprogramday2
{
    class StudentAndTeacherTest
    {
        static void Main()
        {

            //problem1
            //Create a Person and make it say hello
            //Person myPerson = new Person();
            //myPerson.Greet();

            /*Create a student, set his age to 21, 
              tell him to Greet and display his age*/
            //Student myStudent = new Student();
            //myStudent.SetAge(21);
            //myStudent.Greet();
            //myStudent.ShowAge();

            /*Create a teacher, 30 years old, 
             *ask him to say hello and then explain*/
            //Teacher myTeacher = new Teacher();
            //myTeacher.SetAge(30);
            // myTeacher.Greet();
            //myTeacher.Explain();


            //problem2

            PhotoAlbum album1 = new PhotoAlbum();
            Console.WriteLine("Album 1 pages: " + album1.GetNumberOfPages());

            PhotoAlbum album2 = new PhotoAlbum(24);
            Console.WriteLine("Album 2 pages: " + album2.GetNumberOfPages());

            BigPhotoAlbum album3 = new BigPhotoAlbum();
            Console.WriteLine("Album 3 pages: " + album3.GetNumberOfPages());

        }
    }
}