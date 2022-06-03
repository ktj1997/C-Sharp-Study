namespace Function
{
    class Function
    {
        /**
          * 정적변수
          */
        static string NAME = "STATIC_VARIABLE";
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintArguments(input);
            PrintDefaultParameterFunction();

            /**
              * Argument에 Naming 붙여주기
              */
            PrintNamedParameterFunction(
                argument2: "myname",
                argument1: "hello"
            );

            ArraowFunction(
                argument1: "arg1",
                argument2: "arg2"
            );

            LocalFunction("Reusable");
        }
        /** /(슬래시) * 3개 작성 시 ,아래와 같은 함수설명 주석이 자동으로 생긴다.
          * XML 형태의 주석이라고 한다.
          */

        /// <summary>
        /// 인자를 출력하는 함수
        /// </summary>
        /// <param name="argument"></param>
        static void PrintArguments(string argument)
        {
            Console.WriteLine(argument);
        }


        /**
          * 오버로딩이 가능하다.
          * 호출 할 때 알맞은 시그니쳐를 찾아서 호출하게 된다.
          */
        static void PrintArguments(int argument)
        {
            Console.WriteLine(argument);
        }

        /**
          * 기본 매개변수 (선택적 매개변수)
          * 변수를 넘겨주지 않으면, 기본적으로 할당 된 값이 사용된다.
          */
        static void PrintDefaultParameterFunction(string argument = "default")
        {
            Console.WriteLine(argument);
        }

        /**
          * 메소드에 여러가지의 파라미터를 넘겨줄 수 있다.
          * 각각의 파라미터에 네이밍을 붙여 줄 수 있다.
          */
        static void PrintNamedParameterFunction(string argument1, string argument2)
        {
            Console.WriteLine($" argument1: {argument1} && argument2: {argument2}");
        }


        /**
          * 지역함수: 함수내에 재정의 되는 함수이다.
          * 재사용을 목적으로 사용된다.
          */
        static void LocalFunction(string argument)
        {
            void ReusableFunction()
            {
                Console.WriteLine(argument);
            }

            ReusableFunction();
            ReusableFunction();
        }

        /**
          * 함수를 축약하는 기능을 가지고 있다.
          */

        static void ArraowFunction(string argument1, string argument2) => Console.WriteLine($"{argument1} & {argument2}");
    }
}