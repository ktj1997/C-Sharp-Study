namespace Interface
{
    class Interface
    {
        static void Main(string[] args)
        {
            /**
			  * 인터페이스를 통한 다형성
			  */
            IExample1 example = new Example();
            example.NeedToImplement();

            /**
			  * 다중상속 시에 실행 시킬 메소드 명확하게 지정
			  */
            Example ambigiousExample = new Example();
            ((IExample1)(ambigiousExample)).SameMethod();
            ((IExample2)(ambigiousExample)).SameMethod();

            using (DisposableExample disposable = new DisposableExample())
            {
                Console.WriteLine("Using 시작");
            }
            Console.WriteLine("Using 종료");
        }
    }
    /**
	  * C# 에서는 Interface앞에 I 키워드를 붙인다.
	  * 메소드, 속성, 인덱서 등을 미리 정의 할 수 있다.
	  * 인터페이스 또한 다중 상속 구조를 가질 수 있다.
	  */
    public interface IExample1
    {
        public void NeedToImplement();
        public void SameMethod();
    }

    public interface IExample2
    {
        public void SameMethod();
    }
    /**
	  * C#도 Java와 같이 다중상속을 금지한다. (,를 통해서 구분한다.)
	  * 인터페이스를 통한 다중상속을 사용할 수 있다.
	  */
    class Example : IExample1, IExample2
    {
        public void NeedToImplement()
        {
            Console.WriteLine("인터페이스의 메소드를 구현");
        }
        /**
		  * 다중상속 시에 인터페이스에 동일한 메소드가 여러개 존재한다면,
		  * 모두 구현해 주어야한다.
		  */
        void IExample1.SameMethod()
        {
            Console.WriteLine("I'm Example1");
        }

        void IExample2.SameMethod()
        {
            Console.WriteLine("I'm Example2");
        }
    }
    /**
	  * .NET에서 기본적으로 제공해주는 인터페이스
	  * 해당 Class의 개체를 다 사용하고 나서 실행할 메소드를 구현한다.
	  * using문을 통해서 사용한다.
	  * 주로 마지막 리소스 해제에 사용한다.
	  *  - GC가 관리하지 못하는 리소스에서 주로 사용한다.
	  *     - File, DB 연결 등
	  *  - GC가 자주 일어나는 것을 방지하기 위해서 미리 해제한다.
	  * using을 통해서 범위를 지정해 주면서 자주 사용한다.
	  * Dispose() 메소드를 구현해야 한다.
	  */
    class DisposableExample : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Done");
        }
    }
}