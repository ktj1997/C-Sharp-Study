namespace Indexer
{
    class Indexer
    {
        /**
		  * 내부에 private 배열을 선언해놓고
		  * instance와 indexer로 참조하는 등의 문법으로 사용한다.
		  * 단순히 index가 아니라 string 값으로도 받을 수 있다.
		  */
        static void Main(string[] args)
        {
            Example example = new Example();
            Console.WriteLine(example[0]);
            Console.WriteLine(example[1]);

            example[0] = "key";
            example.printKeyword();

            foreach (string keyword in Repeat.GetNext())
            {
                Console.WriteLine(keyword);
            }

            IEnumerator<int> enumerator = Repeat.GetEnumeartor();

            Console.WriteLine(enumerator.Current);
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

        }

    }
    /**
	  * Indexer는 this 키워드를 사용한다.
	  * 배열 Index접근 같이 사용 가능하다.
	  */
    class Example
    {
        private string keyword;
        /**
		  * Set을 생략하면 읽기전용 Indexer 이다.
		  */
        public string this[int index]
        {
            get
            {
                return index % 2 == 0 ? "짝수" : "홀수";
            }
            /**
			  * 넘어온 Keyword는 value로 접근 가능하다.
			  */
            set
            {
                keyword = value;
            }
        }
        public void printKeyword()
        {
            Console.WriteLine(keyword);
        }
    }

    /**
	  * 반복되는 값의 리턴은
	  * IEnumerable과 yield 키워들르 사용한다.
	  * IEnumerable의 경우 내부적으로 IEnumerator를 사용한다.
	  */
    class Repeat
    {
        public static IEnumerable<string> GetNext()
        {
            yield return "Hello";
            yield return "C#";
            yield return "DotNet";
        }
        /**
		  * 반복자 (Enumerator) 또한 반복구문에 사용된다.
		  * Lazy Evaluation에 특화되어 있다.
		  */
        public static IEnumerator<int> GetEnumeartor()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return i;
            }
        }

        /**
		  * IEnumerable을 사용하면 List와 같은 임시 저장 Collection 없이 구현 가능하다.
		  * Lazy하기 떄문이다.
		  */
        static IEnumerable<int> Greater1(int[] numbers, int greater)
        {
            List<int> temp = new List<int>();
            foreach (var n in numbers)
            {
                if (n > greater)
                {
                    temp.Add(n);
                }
            }
            return temp;
        }

        //② yield 사용 후: 추가 클래스 사용 없이 여러 데이터를 yield return으로 반환
        static IEnumerable<int> Greater2(int[] numbers, int greater)
        {
            foreach (var n in numbers)
            {
                if (n > greater)
                {
                    yield return n;
                }
            }
        }
    }
}