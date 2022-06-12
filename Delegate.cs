
namespace Delegate
{
    /**
	  * <<함수 포인터>> 라고 볼 수 있다.
	  * 1. delegate 키워드를 통해서 생성한다.
	  * 2. 메소드에 대한 참조를 나타낸다.
	  * 3. 다른메소드를 실행시켜주는 메소드이다.
	  * 4. 한번에 하나이상의 다른 메소드를 실행 시킬 수 있다.
	  * 5. 이미 있는 함수를 대신 호출하는 것이 목적이다.
	  */
    class Delegate
    {
        /**
		  * 대리자 생성
		  * 대리자 Type이라고 볼 수 있다.
		  */
        delegate void SayDelegate();
        delegate void ParameterizedDelegate(string msg);

        static void Printing() => Console.WriteLine("Hello");

        static void GoLeft() => Console.WriteLine("Go Left");
        static void GoRight() => Console.WriteLine("Go Right");
        static void GoStraight() => Console.WriteLine("Go Straight");

        static void StringLengthPrint(Func<string, int> stringLength, string message)
            => Console.WriteLine($"메시지의 크기는 {stringLength(message)}입니다.");

        static void Main(string[] args)
        {
            // 대리자 Type과 매개변수

            /**
			  * 이름으로 키워드 전달하기
			  */
            SayDelegate delegateFunc = Printing;
            delegateFunc(); //Hello
            /**
			  * new 키워드를 통한 전달
			  */
            delegateFunc = new SayDelegate(Printing);
            /**
			  * 1. 괄호를 통한 실행
			  * 2. Invoke()를 통한 실행
			  */
            delegateFunc();
            delegateFunc.Invoke();


            /**
			  * 메소드 체이닝을 통한 활용도 가능하다.
			  */

            SayDelegate chaningDelegater = GoLeft;
            chaningDelegater += GoRight;
            chaningDelegater += GoStraight;

            chaningDelegater.Invoke();

            /**
			  * 무명메소드로 사용
			  */
            SayDelegate annonymousDelegater = delegate ()
            {
                Console.WriteLine("Hello I'm AnnonyMous");
            };
            annonymousDelegater();

            /**
			  * 람다식으로 하면 훨씬 깔끔하다.
			  */
            SayDelegate lambda = () => Console.WriteLine("Lambda Function");
            lambda();

            ParameterizedDelegate parameterizedDelegater = (string msg) => Console.WriteLine($"msg: {msg}");
            parameterizedDelegater.Invoke("Input");



            /**
			  * 닷넷에서 제공하는 Delegate API
			  * 1. Action<T>: 반환값이 없는 메소드를 대신 호출 합니다.
			  * 2. Func<T,R>: 매개변수와 반환값이 있는 메소드를 호출한다.
			  * 3. Predicate<T> 매개변수 T에대한 bool값을 갖는 메소드를 호출한다.
			  */
            Action<string> actionDelegater = Console.WriteLine;
            actionDelegater("Action Delegater");

            /**
			  * Func의 마지막이 Return 값
			  * 그 전까지는 다 Parameter 값이다.
			  * Func는 메소드 자체를 메소드의 매개변수로 넘겨 줄 수 있다.
			  */
            Func<double, double, double> myPow = Math.Pow;

            Console.WriteLine(myPow(2, 3)); //8

            Func<string, int> stringLength = data => data.Length;
            StringLengthPrint(stringLength, "안녕하세요");


            /**
              * 파라미터에대한 boolean 조건을 탐색한다.
              */
            Predicate<int> isPositivePredicator = num => num > 0;
            Console.WriteLine(isPositivePredicator(-5)); //false

        }
    }
}