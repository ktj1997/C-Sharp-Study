
namespace Class
{
    /**
			*  접근 제어자
			*  1. public: 외부에서 호출 가능
			*  2. internal: 같은 어셈블리(C# 컴파일의 결과물) 에서 public으로 접근 가능
			*  3. protected: 파생 클래스에서만 접근 가능
			*  4. private: 클래스 내부에서만 호출 가능
			*  5. protected internal: 같은 에셈블리에서 protected로 접근 가능
			*/
    /**
			* Class는 참조형식이다.
			* 값 형식이 아니기 때문에, 주소만 참조하는 형태이다.
			*/
    public class Class
    {
        /**
		 * static: 정적 특성
		 * 해당 클래스의 모든 곳에서 공유해서 사용 할 수 있다.
		 */
        static void Main(string[] args)
        {
            Console.WriteLine("========== Make Person Class ==========");
            Person p = new Person(age: 10, name: "kim");

            Console.WriteLine("========== Make Parent Class ==========");
            Parent p1 = new Parent(age: 40, name: "lee");

            Console.WriteLine("========== Make Child Class ==========");
            Child c1 = new Child(age: 5, name: "lee");

            /**
											* 상속관계에서의 타입 검증
											*/

            if (c1 is Person)
            {
                Console.WriteLine("c1 is Person");
            }
            if (c1 is Parent)
            {
                Console.WriteLine("c1 is Parent");
            }

            Console.WriteLine($"c1 = age: {c1.age} & name: {c1.name}");
        }
    }
    /**
			* 외부에서 접근하기 위해서는 Member도 모두 public 접근자를 가지고 있어야 한다.
			* 클래스 멤버의 Default 접근 제어는 private이다.
			*/
    public class Person
    {
        /** 
			* readonly 키워드는 말 그대로 읽기전용 필드이다.
			*/
        public readonly string name;
        public int age;



        public Person(int age)
        {
            this.name = null;
            this.age = age;
        }

        /**
			* 생성자 오버로딩이 가능하다.
				* 생성자가 없다면 컴파일러가 기본적으로 Default Constructor를 제공해준다.
				* 존재한다면, Default Constructor는 제공되지 않는다.
				*/
        public Person(string name, int age) : this(age)
        {
            this.name = name;
            Console.WriteLine("Person Is Generated");
        }
    }
    public class Parent : Person
    {
        /**
				* 부모 생성자를 불러오려면 base 키워드를 사용한다.
				*/
        public Parent(string name, int age) : base(name, age)
        {
            Console.WriteLine("Parent Is Generated");
        }
    }

    public class Child : Parent
    {
        public Child(string name, int age) : base(name, age)
        {
            Console.WriteLine("Child Is Generated");
        }
    }
}