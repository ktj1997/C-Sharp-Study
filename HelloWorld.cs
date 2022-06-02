using System; //System namespace를 사용. 없으면 System.Console.WriteLine이 된다.

/**
 * namespace
 * 유사한 것 들을 모아 둘 수 있다.
 * class, interface등 namespace로 구분 지으면, 같은 네이밍을 가져도 오류가 발생하지 않는다.
*/
namespace HelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
    }
}