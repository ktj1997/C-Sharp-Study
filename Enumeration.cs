namespace Enumeration
{
    class Enumeration
    {
        static void Main(string[] args)
        {
            /**
			  * int로 출력하면 상수값 출력
			  * string으로 출력하면 Enum 값 그대로 출력
			  */
            Console.WriteLine(Priority.HIGH);
            Console.WriteLine((int)Priority.LOW);

            /**
			  * Enum 열거형을 통해서 메타데이터를 불러 올 수 있다.
			  */
            Type type = typeof(Priority);
            string[] names = Enum.GetNames(type);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            /**
			  * String 값을 Enum으로 파싱
			  */
            string priorityString = "HIGH";
            Priority priority = (Priority)Enum.Parse(typeof(Priority), priorityString);

            Console.WriteLine(priority);

        }
    }
    /**
	  * 상수 값을 주는 것도 가능하다.
	  * 기본적으로 상수값은 순서대로 0부터 시작한다.
	  */
    enum Priority
    {
        HIGH = 3,
        NORMAL = 2,
        LOW = 1
    }
}