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
public class Person {
	private string _myname;
 	public string name {
		get { return _myname;
		}
        set { 
			if(value == null || value == "" || value.Length >=32)
			{
			 	throw new Exception("Invalid Name");
			}
			_myname = value; 
    	}
	}        
	private int _g;
    public int age{
        get { return _g; }
        set { 
        	if(value <= 0 || value > 128)
            {
            throw new Exception("Invalid Age");
            }
            _g = value; 
        }
    }
	public Person( string myname , int g){
		name=myname;
		age=g;

	}
	public virtual void Print(){
		Console.WriteLine($"my name is {name},my age is {age}");
	}
}
public class Staff : Person{
	private double _ssalary;
	public double salary{
		get { return _ssalary; }
        set { 
            if(value < 0 || value > 120000)
            {
                throw new Exception("Invalid Salary");
            }
		    _ssalary = value; 
        }
	}
	private int _jjoinYear;
	public int joinyear{
		get { return _jjoinYear; }
        set { 
            var compare = 2022 - (2022-age);
            if(compare <= 21)
            {
               throw new Exception("Invalid JoinYear");
            }
            _jjoinYear = compare; 
        }
	}
	public Staff(string myname , int g, double ssalary, int jjoinyear ):base (myname ,g){
		salary = ssalary;
		joinyear =jjoinyear;
	}
	public override void Print(){
		Console.WriteLine($"my name is {name},my age is {age},and my salary {salary}");
	}
}
public class Student : Person{
	private float _ggpa;
	public float gpa{
		get { return _ggpa; }
        set { 
            if(value < 0 || value > 4)
            {
    	        throw new Exception("Invalid Gpa");
            }
            _ggpa = value; 
        }
	}
	public Student(string myname , int g, float ggpa):base (myname ,g){
		gpa=ggpa;
	}
	public override void Print(){
		Console.WriteLine($"my name is {name},my age is {age},and my gpa {gpa}");
	}
}
public class Database{
	private int _currentindex;
	public Person[] people = new Person[20];
	public void Addstaff(Staff staff){
		people[_currentindex]=staff;
		staff.Print();
	}
	public void Addstudent(Student student){
		people[_currentindex]=student;
		student.Print();
	}
	public void Addperson(Person person){
        people[_currentindex++] = person;
		person.Print();
    } 
	public void PrintAll(){
       for(int i = 0; i < _currentindex;i++){
            people[i].Print();
        }
	}
}
public class Program {
	private static void Main()
	{ 
		var database=new Database();
		while (true){
			Console.WriteLine("1->student  , 2->staff   , 3->person   , 4->print all");
 			try{
			var option = Convert.ToInt32(Console.ReadLine());
			switch (option){
				case 1:
					try{
						Console.WriteLine("name: ");
						string name=Console.ReadLine();
						Console.WriteLine("age: ");
						var g=Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("gpa ");
						var ggpa=Convert.ToInt32(Console.ReadLine());
						try{
							var student=new Student(name,g,ggpa);
							database.Addstudent(student);
						}catch(Exception e){
							Console.WriteLine(e.Message);
						}
					}catch{
                        Console.WriteLine("ENTER VALUE NUMBER");
                    }
					break;
				case 2:
				try{
					Console.WriteLine("name: ");
					string name=Console.ReadLine();
					Console.WriteLine("age: ");
					var g=Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("sallary: ");
					var ssalary=Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("joinyear: ");
					var jjoinyear=Convert.ToInt32(Console.ReadLine());
					try{
					    var staff=new Staff(name,g,ssalary,jjoinyear);
                        database.Addstaff(staff);
                    }catch(Exception e){
                        Console.WriteLine(e.Message);
                    }
				}catch{
                    Console.WriteLine("ENTER VALUE NUMBER");
                }
				break;
				case 3:
					Console.WriteLine("name: ");
					var myname=Console.ReadLine();		
					try{
                        Console.WriteLine("age : ");
						var g=Convert.ToInt32(Console.ReadLine());
                        try{
                            var person=new Person(myname,g);
                            database.Addperson(person);
                        }catch(Exception e){
                            Console.WriteLine(e.Message);
						}
                    }catch{
                        Console.WriteLine("ENTER VALUE NUMBER");
                    }
                break;
				case 4:
					database.PrintAll();
				break;
			}
			}catch{
                Console.WriteLine("ENTER VALUE NUMBER");

			}	
		}
	}
}

