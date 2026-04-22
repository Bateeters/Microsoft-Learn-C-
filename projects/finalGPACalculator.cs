/*
You're developing a Student GPA Calculator that will help calculate students' 
overall Grade Point Average. The parameters for your application are:

- You're given the student's name and class information.
- Each class has a name, the student's grade, and the number of credit hours for that class.
- Your application needs to perform basic math operations to calculate the GPA for the given student.
- Your application needs to output/display the student’s name, class information, and GPA.

To calculate the GPA:

- Multiply the grade value for a course by the number of credit hours for that course.
- Do this for each course, then add these results together.
- Divide the resulting sum by the total number of credit hours.

Student's grades for each course:

Course			    Grade		
English 101		     A
Algebra 101		     B
Biology 101		     B
Computer Science I	 B
Psychology 101	     A

You're provided with the following sample of a student's course information and GPA:

Expected Output

Student: Sophia Johnson

Course          Grade   Credit Hours	
English 101         4       3
Algebra 101         3       3
Biology 101         3       4
Computer Science I  3       4
Psychology 101      4       3

Final GPA:          3.35
*/

// Start of code ------------------

// Initializing course and student variables
string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Creadit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

// Initializing grade scale variables
int gradeA = 4;
int gradeB = 3;
int gradeC = 2;
int gradeD = 1;
int gradeF = 0;

// Initializing student's course grades
int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;