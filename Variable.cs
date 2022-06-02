namespace Variable
{
    class Variable
    {
        static void Main(string[] args)
        {
            /**
				*  문자형, 정수형, 실수형으로 나뉜다.
				*  문자형: char(2) 
				*  정수형: byte(1) -> short(2) -> int(4) -> long(8)
				*  실수형: float(4) -> double(8) -> decimal(32)
				*/
            int integerNumber = 5;
            char chr = 'a';
            bool flag = false;
            double doubleNumber = 3.5;
            long longNumber = (long)(int.MaxValue) + 1;

            /**
			  * C계열 답게 UnSigned가 존재한다.
			  * 앞에 Prefix로 U를 붙이면 된다.
			  * 부호가 없는만큼, 부호가 있는 자료형 * 2 만큼이다.
			  */
            uint unsignedInteger = 5;
            ulong unsignedLong = 5;


            /**
			  * string은 ReferenceType이다.
			  * @키워드를 문자열 앞에 붙이면, Escape는 물론, 입력한 형식그대로 저장한다.
			  */
            string normalString = "hello";
            string multipleLines = @"
				안녕하세요.
				반갑습니다.
			";

            string templateString = $"{normalString} And {multipleLines}";

            /**
			  * 상수 키워드는 const이다.
			  */
            const int max = int.MaxValue;

            /**
			  * nullable Type은 ?을 붙이면 된다.
			  */
            int? nullableInteger = null;


            Console.WriteLine("chr : {0} || int : {1} || string: {2} || bool : {3} double: {4}, longNumber: {5}", chr, integerNumber, normalString, flag, doubleNumber, longNumber);

            /**
			  * Primitive
			*/


            Console.WriteLine("is int Primitive? {0}", typeof(int).IsPrimitive);
            Console.WriteLine("is str Primitive? {0}", typeof(string).IsPrimitive);
            Console.WriteLine("is double Primitive? {0}", typeof(bool).IsPrimitive);
            Console.WriteLine("is bool Primitive? {0}", typeof(double).IsPrimitive);

            /**
				* Refrence
				*/

            Console.WriteLine("is str Primitive? {0}", typeof(string).IsPrimitive);
            Console.WriteLine("this is multipleLine String :{0}", multipleLines);
            Console.WriteLine("this is templateString: {0}", templateString);
            /**
				* Const Variable
				*/
            Console.WriteLine("{0}", max);



            /**
			 * 암시적 형식 var
			 * 대입되는 값에 따라서 컴파일러가 알아서 타입 추론으로 결정한다.
			 * 편의성을위해서 만들어진 키워드이다. 
			 * 선언과 동시에 초기화 할 것
			 * 지역변수에서만 사용 할 것
			 */
            var implictedString = "hello";
            var implictedNumber = 5;

            Console.WriteLine(implictedNumber.GetType());
            Console.WriteLine(implictedString.GetType());

        }
    }
}