namespace Variable{
class Variable{
		static void Main(string[] args){
				/**
					*  정수형과 실수형으로 나뉜다.
					*  정수형: byte(1) -> short(2) -> int(4) -> long(8)
					*  실수형: float(4) -> double(8) -> decimal(32)
					*/
				int integerNumber = 5;
				string str = "hello";
				char chr = 'a';
				bool flag = false;
				double doubleNumber = 3.5;
				long longNumber = (long)(int.MaxValue)+1;

				 /**
					* C계열 답게 UnSigned가 존재한다.
					* 앞에 Prefix로 U를 붙이면 된다.
					* 부호가 없는만큼, 부호가 있는 자료형 * 2 만큼이다.
					*/
				uint unsignedInteger = 5;
				ulong unsignedLong  = 5;

				/**
					* 상수 키워드는 const이다.
					*/


				const int max = int.MaxValue;

				Console.WriteLine("chr : {0} || int : {1} || string: {2} || bool : {3} double: {4}, longNumber: {5}",chr,integerNumber,str,flag,doubleNumber,longNumber);
				
				/**
					* Primitive
					*/


				Console.WriteLine("is int Primitive? {0}",typeof(int).IsPrimitive);
				Console.WriteLine("is str Primitive? {0}",typeof(string).IsPrimitive);
				Console.WriteLine("is double Primitive? {0}",typeof(bool).IsPrimitive);
				Console.WriteLine("is bool Primitive? {0}",typeof(double).IsPrimitive);   
		
				/**
					* Refrence
					*/

				Console.WriteLine("is str Primitive? {0}",typeof(string).IsPrimitive);
				/**
					* Const Variable
					*/
				Console.WriteLine("{0}",max);
				
		}
}
}