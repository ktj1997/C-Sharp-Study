namespace Null
{
    class Null
    {
        /**
          * ReferenceType이면서 아무것도 참조하지 않음을 의미한다.
          *  - ValueType은 Null을 받을 수 없다. (int,float,double ...)
          * 빈 값 (Empty) 와는 다르다.
          */
        static void Main(string[] args)
        {
            /**
              * ValueType에 Null 사용하기
              * Nullable<T>
              */

            Nullable<int> nullableInteger = null;
            Console.WriteLine(nullableInteger.HasValue);

            nullableInteger = 5;
            Console.WriteLine(nullableInteger.HasValue);


            /** 
              * Null 가능 형식
              * Nullable을 줄인 버전.
              * Compile을 한 결과물은 같다고 한다.
              */
            int? i = null;
            Console.WriteLine(i);

            /**
              * ??
              * Null 병합 연산자
              * Nulㅣ이 아니면 왼쪽을, Null이라면 오른쪽을 반환한다.
              */
            int? a = null;
            a = a ?? 5;
            Console.WriteLine(a == 5);

            /**
              * ?.
              * Null 조건부 연산자
              * Null이면 그대로 Null반환, 아니라면 로직 수행
              */
            int? b = null;
            Console.WriteLine(null == (b?.ToString()));

            b = 5;
            Console.WriteLine(null == (b?.ToString()));
        }
    }
}