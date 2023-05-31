var students = new List<string> {"Sam Andrews", "Betty Lake", "Stewart Small"};
var courses = new List<string> {"Maths", "Science", "English", "Computer Science"};

var samAndrews = new List<string> {"Maths", "English"};
var bettyLake = new List<string> {"Maths", "Computer Science"};
var stewartSmall = new List<string> {"Science", "English", "Computer Science"};

var notExit = true;

while (notExit) {
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1 = List all students");
    Console.WriteLine("2 = List all courses");
    Console.WriteLine("3 = Enrol a new student");
    Console.WriteLine("4 = exit");
    var input = Console.ReadLine();
    if (input == "1") {
        foreach (var student in students) {
            Console.WriteLine(student);
        }
    }
    else if (input == "2") {
        foreach (var course in courses) {
            Console.WriteLine(course);
        }
    }
    else if (input == "3") {
        Console.WriteLine("What is the name of the new student?");
        var newName = Console.ReadLine();
        students.Add(newName);
    }
    else if (input == "4") {
        notExit = false;
    }
}
