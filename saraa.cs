using System;
namespace task_project;
public class task_project {
	// private static void Main(){
	// 	var size=Convert.ToInt32(Console.ReadLine()); 
	// 	var arr=new int[size];
	// 	var min=arr[0];
	// 	for(var i=0;i<size ;i++){
	// 		arr[i]=Convert.ToInt32(Console.ReadLine());
	// 		if (arr[i]<min)	min=arr[i];
	// 	}Console.WriteLine(min);
	// }
}
////////////////////////
// public class task1 {
// 	private static void Main() {
// 		string str =Console.ReadLine();
// 		string str1="";
// 		for(var i=str.Length-1;i>=0 ;i--){
// 			str1+=str[i];
// 		}Console.WriteLine(str1);
// 	}
// }
///////////////////////
// public class task2 {
// 	private static void Main() {
// 		string str =Console.ReadLine();
// 		var count=0;
// 		for(var i=0;i<str.Length ;i++){
// 			if (str[i]=='a'){
// 				count++;
// 			}
// 		}Console.WriteLine(count);
// 	}
// }
// ///////////////////////
// public class task3{
// 	private static void Main() {
// 		string str =Console.ReadLine();
// 		var d=0;
// 		for(var i=0;i<str.Length ;i++){
// 			if (str[i]=='a'){
// 				d=i;
// 			}
// 		}Console.WriteLine(d);
// 	}
// }
// ///////////////////////
// public class task4{
// 	private static void Main(){
// 		string str =Console.ReadLine();
// 		string str1="";
// 		for(var i=0;i<str.Length ;i++){
// 	        if (str[i]!='a'){
// 				str1+=str[i];
// 			}
// 		}Console.WriteLine(str1);
// 	}
//  }	
// ///////////////////////
// public class task5{
// 	private static void Main(){
// 		string str =Console.ReadLine();
// 		string str1="";
// 		for(var i=0;i<str.Length ;i++){
// 	        if (str[i]=='a'){
// 				str1+=str[i]+"0";
//             }else{
// 			    str1+=str[i];
// 			}
// 		}Console.WriteLine(str1);
// 	}
// }
// ///////////////////////
// public class task6 {
//  	private static void Main() {
// 		string str =Console.ReadLine();
// 		string str1="sara";
// 		var count=0;
// 		for(var i=0;i<str.Length ;i++){
// 			if(char.IsNumber(str[i])){
// 				count++;
// 			}
// 		}Console.WriteLine(count);
// 		Console.WriteLine(str1.Equals('s'));
// 	}
// }
/////////////////////
// public class task7 {
//  	private static void Main() {
// 		string str =Console.ReadLine();
// 		string str1="";
// 		for(var i=str.Length-1;i>=0 ;i--){
// 			str1+=str[i];
// 		}Console.WriteLine(str1.Equals(str));
// 	}
// }
/////////////////////
// public class task8 {
//  	private static void Main() {
// 		string str =Console.ReadLine();
// 		string str1="";
// 		for(var i=0;i<str.Length ;i++){
// 			if(!str1.Contains (str[i])){
// 				str1+=str[i] ;
// 			}
// 		}Console.WriteLine(str1);
// 	}
// }
//////////////////////////////
// public class task9 {
//  	private static void Main() {
// 		var size=Convert.ToInt32(Console.ReadLine()); 
// 		var arr=new int[size];
// 		var sum=0;
// 		for(var i=0;i<size ;i++){
// 			arr[i]=Convert.ToInt32(Console.ReadLine());
// 			sum+=arr[i];
// 		}
// 		var avg=sum/size;
// 	    var minDiff= arr[0]-avg;
// 		if (minDiff<0) minDiff=minDiff*(-1);
// 		var min=arr[0];
// 		for(var i=1;i<size ;i++){
// 			var res=arr[i]-avg;
// 			if (res<0) res=res*(-1);
// 			if (res<minDiff){
// 				minDiff=res;
// 				min=arr[i];
// 			}

// 		}Console.WriteLine(min);
		
// 	}
// }
// //////////////////////
// public class task10 {
//  	private static void Main() {
// 		var size=Convert.ToInt32(Console.ReadLine()); 
// 		var arr=new int[size];
// 		for(var i=0;i<size ;i++){
// 			arr[i]=Convert.ToInt32(Console.ReadLine());
// 		}
// 		int min=arr[0];
// 		int max=arr[0];
// 		for(var i=1 ;i<size ;i++){
// 			if(arr[i]<min){
// 				min=arr[i];
// 			}
// 		}for(var i=1 ;i<size ;i++){	
// 			if(arr[i]>max){
// 				max=arr[i];
// 			}
// 		}Console.WriteLine((max+min)/2);
// 	}
// }
//////////////////////
// public class task11 {
//  	private static void Main() {
// 		var size=Convert.ToInt32(Console.ReadLine()); 
// 		var arr=new int[size];
// 		for(var i=0;i<size ;i++){
// 			arr[i]=Convert.ToInt32(Console.ReadLine());
// 		}
// 		var r =arr[0];
// 		for(var i=1;i<size ;i++){
// 			if(arr[i]==(r+1)){
// 				r=arr[i];
// 			}else{
// 				Console.WriteLine(r+1);
// 				break;	
// 			}
// 			}
// 		}
// }
///////////////////////////////
// public class task12 {
//  	private static void Main() {
// 		var size=Convert.ToInt32(Console.ReadLine()); 
// 		var arr=new int[size];
// 		var sum=0;
// 		var avg=0;
// 		var count1=0;
// 		for(var i=0;i<size ;i++){
// 			arr[i]=Convert.ToInt32(Console.ReadLine());
// 			sum+=arr[i];
// 		}
// 		avg=sum/size;
// 		for(var i=0;i<size ;i++){
// 			if(arr[i]<avg){
// 				count1++;
// 			}
// 		}Console.WriteLine(count1);	
// 	}
// }
///////////////////////////////

// public class task13 {
//  	private static void Main() {
// 		var size=Convert.ToInt32(Console.ReadLine()); 
// 		var arr=new int[size];
// 		var sum=0;
// 		var avg=0;
// 		for(var i=0;i<size ;i++){
// 			arr[i]=Convert.ToInt32(Console.ReadLine());
// 			sum+=arr[i];
// 		}
// 		avg=sum/size;
// 		for(var i=0;i<size ;i++){
// 			if(arr[i]>avg){
// 				Console.WriteLine(arr[i]);
// 				break;
// 			}
// 		}
// 	}
// }
/////////////////////
// public class task {
//  	private static void Main() {
// 		var size=Convert.ToInt32(Console.ReadLine()); 
// 		var arr=new int[size];
// 		for(var i=0;i<size ;i++){
// 			arr[i]=Convert.ToInt32(Console.ReadLine());
// 		}
// 		for(var i=0;i<size ;i++){
// 			if(arr[i]>avg){
// 			}
// 		}
// 		Console.WriteLine(arr[i]);
// 	}
// }
public abstract class person {
 	public string name ;
	public int age;
	public person( string name , int age){
		name=my_name;
		age=g;

	}
	public abstract void print();
}
public class staff : person{
	public double salary;
	public int joinyear;
	public staff(string name , int age, double salary, int joinyear ):base (name ,age){
		salary = ssalary;
		jionyear =jjoinyear;
	}
	public override void print(){
		Console.WriteLine($"my name is {my_name},my age is {g},and my salary {ssalary}");
	}
}
public class student : person{
	public float gpa;
	public student(string name , int age, float gpa):base (name ,age){
		gpa=ggpa;
	}
	public override void print(){
		Console.WriteLine($"my name is {my_name},my age is {g},and my gpa {ggpa}");
	}
}
public class database{
	private int _currentindex;
	public person[] people = new person[20];
	public void addstaff(Staff staff){
		people[_currentindex]=staff;
	}
	public void addstudent(Student student){
		people[_currentindex]=student;
	}
}
public class program : person {
	private static void Main()
	{ 

		program obj=new program();
		var database=new database();
		while (true){

		
			Console.WriteLine("1->student  , 2->staff   , 3->person   , 4->print all");

			var option = Convert.ToInt32(Console.ReadLine());
			switch (option){
				case 1:
					Console.WriteLine("name: ");
					var my_name=Console.ReadLine();
					Console.WriteLine("age: ");
					var g=Console.ToInt32(Console.ReadLine());
					Console.WriteLine("gpa ");
					var ggpa=Console.ToInt32(Console.ReadLine());
					var student=new student(my_name,g,ggpa);
					break;
				case 2:
					Console.WriteLine("name: ");
					var my_name=Console.ReadLine();
					Console.WriteLine("age: ");
					var g=Console.ToInt32(Console.ReadLine());
					Console.WriteLine("sallary: ");
					var ssalary=Console.ToInt32(Console.ReadLine());
					var staff=new staff(my_name,g,ssalary);
					break;
				case 3:
					Console.WriteLine("name: ");
					var my_name=Console.ReadLine();
					Console.WriteLine("age: ");
					var g=Console.ToInt32(Console.ReadLine());
					obj.person();
					break;
				case 4:
					database.addstaff(staff);
					database.addstudent(student);
					break;
			} 
		}
	}
}

