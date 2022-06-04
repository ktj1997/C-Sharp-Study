namespace StringManipulation
{
    public class StringManipulation
    {
        static void Main(string[] args)
        {
            string message = "Hello world";
            Console.WriteLine($"Length = {message.Length}");
            Console.WriteLine($"Input's UpperCase = {message.ToUpper()}");
            Console.WriteLine($"Input's LowerCase =  {message.ToLower()}");

            /**
              * 체이닝도 가능하다.
              */
            message = message.ToUpper().Replace("HELLO", "Bye");
            Console.WriteLine(message);


            /**
              * String 클래스도 string과 같은 역할을 한다.
              * String 클래스의 Static Method를 사용 할 수 있다.
              */
            String a = String.Concat("Hello", " ", "World");
            Console.WriteLine(a);

            /**
              * C#에서는 문자열의 대소문자를 구분한다.
              * 기본적인 == 를 통해서도 판단 가능하다.
              */
            if (a == "Hello World")
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Different");
            }

            /**
              * String.Equals() 메소드에 추가옵션을 지정하는 방법으로도 비교 가능하다.
              */
            if (String.Equals(a, "hello world", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Different");
            }

            /**
              * ToCharArray로 문자 배열 받기 가능
              */

            char[] tokens = a.ToCharArray();

            foreach (char token in tokens)
            {
                Console.WriteLine(token);
            }
            /**
              * Split을 통해서 문자열을 분리 할 수 있다.
              */
            string[] str = a.Split(" ");
            foreach (string splitedString in str)
            {
                Console.WriteLine(splitedString);
            }


            /**
              * 유효성 검증 메소드
              */
            if (!String.IsNullOrEmpty(a))
            {
                Console.WriteLine("Not Null & Not Empty");
            }
            else
            {
                Console.WriteLine("Null || Empty");
            }
        }
    }
}