using Class;
namespace Cast
{
    class Cast
    {
        static void Main(string[] args)
        {
            /**
        * Boxing --> 값 형식의 데이터를 참조형식 데이터로 변경 하는 것.
        * 성능상의 오버헤드가 발생한다 --> stack영역에 저장되어 있던 것을 heap영역으로 옮기는 행위이기 때문
        */
            int i = 1234;
            object o = i;

            /**
              * is 를 사용하여, 개체의 Type에 대한 검사가 가능하다.
              * 강제 형변환 시에는 is키워드로 미리 검사를 하고 진행하자
              * 아닐 경우 Try-Catch를 통한 에러핸들링이 필요하다.
              */

            if (o is int)
            {
                Console.WriteLine("Integer Type");
            }
            else if (o is string)
            {
                Console.WriteLine("String Type");
            }
            else
            {
                Console.WriteLine("Wrong Type");
            }
            /**
              * as 형식으로 Type변환이 가능하다.
              * 변환하려는 데이터 형식이 아닌경우 NULL을 반환한다.
              * Reference Type의 경우 강제 형변환 보다는 as를 사용하자
              */
            Class.Class c = o as Class.Class;

            Console.WriteLine($"is C NULL ? {c == null}");

        }
    }
}