using System;
namespace prac1c{
class prac1c{
struct student{
public string sid,sname,cname;
public int dd,mm,yy;
}
public static void Main(){
int i;
Console.Write("enter how many students data you want to store");
int nos=int.Parse(Console.ReadLine());
student[] s=new student[nos];
for( i =0;i<nos;i++){
Console.WriteLine("ENTER DATA OF STUDENT"+i+":");
Console.WriteLine("enter id of student"+i+":");
s[i].sid=Console.ReadLine();
Console.WriteLine("enter name of student"+i+":");
s[i].sname=Console.ReadLine();
Console.WriteLine("enter course name of student"+i+":");
s[i].cname=Console.ReadLine();
Console.WriteLine("enter dob(day(1-31)) of student"+i+":");
s[i].dd=int.Parse(Console.ReadLine());
Console.WriteLine("enter dob(month(1-12)) of student"+i+":");
s[i].mm=int.Parse(Console.ReadLine());
Console.WriteLine("enter dob(year) of student"+i+":");
s[i].yy=int.Parse(Console.ReadLine());



}
for (i=0;i<nos;i++){
Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("details of student "+i+"is:");
Console.WriteLine("student id of student"+i+"is:"+s[i].sid);
Console.WriteLine("student name of student"+i+"is:"+s[i].sname);
Console.WriteLine("student course name of student"+i+"is:"+s[i].cname);
Console.WriteLine("student dob(day(1-31))  of student"+i+"is:"+s[i].dd);
Console.WriteLine("student dob(month(1-12)) of student"+i+"is:"+s[i].mm);
Console.WriteLine("student dob(year) of student"+i+"is:"+s[i].yy);
}
}
}
}