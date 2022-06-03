namespace Struct
{
    /**
      * 구조체를 통해서 연관 있는 데이터를 묶어서 관리할 수 있다.
      * C# 에서는 구조체를 확장한 Class 기능을 제공한다.
      * Class를 주로 사용하도록 하자.
      */
    class Struct
    {
        /**
          * 구조체는 값 타입 이다.
          *  참조가 아니다
          *  1. GC를 타지 않는다. (대용량 처리 특화)
          *  2. VO로 사용가능하다. (하지만 주로 Class를 사용한다고 한다.)
          *  3. 값 타입이기 떄문에 깊은복사가 가능하다.          
          * 
          * Class로 성능상의 이슈가 나는 것들을 튜닝 할 때 struct로 바꿔보자.
          */
        struct People
        {
            /**  
              * 멤버들에 public을 붙여서 외부에서도 사용 가능하게 한다.
              */
            public string name;
            public int age;

            /**
              * 생성자를 통해 생성도 가능하다.
              * 매개변수가 없는 생성자는 만들 수 없다.
              * 생성자로 생성한다면 모든 필드가 초기화 되어있어야 한다.
              */
            public People(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }
        static void Main(string[] args)
        {
            /**
              * 생성자 없이 프로퍼티에 직접 접근해 값을 할당 해 줄 수 있다.
              */
            People p1;
            People p2 = new People(name: "dori", age: 26);

            p1.name = "dori";
            p1.age = 26;

            Console.WriteLine($"{p1.name} : {p1.age}");
            Console.WriteLine($"{p2.name} : {p2.age}");



            /**
              * 구조체 배열
              */
            People[] arrayP = new People[5];



            /**
              * 내장 구조체
              * 닷넷에서 기본적으로 제공해주는 Build-in 구조체
              *
              * 1. DateTime: 시간
              * 2. TimeSpan: 시간 간격
              * 3. Char: 문자관련 모든 정보
              * 4. Guid: 중복되지 않는 유일한 문자열을 생성
              */


            /**
              * DateTime
              */
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Millisecond);

            /**
              * TimeSpan
              */
            TimeSpan diff1 = (Convert.ToDateTime("2022-12-25") - DateTime.Now);
            TimeSpan diff2 = (DateTime.Now - Convert.ToDateTime("1997-12-26"));

            Console.WriteLine($"2022년 크리스마스 까지 D-{(int)diff1.TotalDays}");
            Console.WriteLine($"태어난지 {(int)diff2.TotalDays}일 째");

            /**
              * Char
              */
            string password = "1q2w3e4r!!";

            foreach (char token in password)
            {
                if (Char.IsDigit(token))
                {
                    Console.WriteLine($"{token} is Number");
                }
                else if (Char.IsLetter(token))
                {
                    Console.WriteLine($"{token} is Letter");
                }
                else
                {
                    Console.WriteLine($"{token} is Special Character");
                }
            }

            /**
              * Guid
              */
            Console.WriteLine(Guid.NewGuid().ToString());
        }
    }
}