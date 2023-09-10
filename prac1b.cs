using System;
namespace prac1b{
class prac1b{
public static void Main(){
string s1,s2;
Console.Write("enter your string");
s1=Console.ReadLine();


Console.WriteLine("make uppercase:"+s1.ToUpper());
Console.WriteLine("make lowercase:"+s1.ToLower());
Console.WriteLine("is string contains this letter shere:"+s1.Contains("shere"));
Console.WriteLine("return string length:"+s1.Length);
Console.WriteLine("remove starting space:"+s1.TrimStart());
Console.WriteLine("remove end space:"+s1.TrimEnd());

Console.WriteLine("compare with mahesh shere :"+s1.CompareTo("mahesh shere"));
Console.WriteLine("is ends with shere"+s1.EndsWith("shere"));
Console.WriteLine("is starts with mahesh"+s1.StartsWith("mahesh"));
Console.WriteLine("returns index of character or string(sin this case):"+s1.IndexOf('s'));
Console.WriteLine("returns the substring(1 to 4 in this case)"+s1.Substring(1,4));
Console.Write("enter your second string");
s2=Console.ReadLine();
Console.WriteLine("is string 1 ans 2 same:"+string.Compare(s1,s2));
Console.WriteLine("concat both:"+string.Concat(s1,s2));
Console.WriteLine("is string 1 and 2 is equal:"+s2.Equals(s1));
Console.WriteLine("insert string at given index(9 in this case):"+s2.Insert(9,"badlapur"));
Console.WriteLine("Replace mahesh with gahesh:"+s2.Replace('m','g'));
Console.WriteLine("removes from index 1 to 3:"+s2.Remove(1,3));







}
}
}