using _01_Classes;

// Creating an object of the Student class
Student student1 = new Student();
student1.No = 1;
student1.Name = "A";
student1.LastName = "AL";
student1.Age = 18;

student1.PrintStudentInfo();

Student student2 = new();
student2.No = 2;
student2.Name = "B";
student2.LastName = "BL";
student2.Age = 20;

student2.PrintStudentInfo();