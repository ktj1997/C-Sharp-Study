using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace AttributeExample
{
    /**
     *  C#의 Attribute는 Java의 에노에이션, Python의 데코레이터와 같은 성격을 띈다.
     *  MetaData를 의미한다.
     *  다른 의미를 추가하는데 사용된다.
     *  대괄호([])를 사용해서 표시한다.
     *  .NET 기본 제공 특성, 사용자 지정 특성을 사용할 수 있다.
     *  Class혹은 Method에 붙일 수 있다.
     */
    public class AttributeExample

    {
    static void Main(string[] args)
    {
        //OldMethod(); 에러를 발생 시킨다.
        GetMethodInfo("Hello Attribute!");

    }

    /**
         *  obsolete는 .NET에서 내장된 특성이다.
         *  말 그대로, 구버전이라는 것을 의미한다.
         *  Message도 지정 할 수 있다.
         *  두 번째 인자인 true를 통해서 에러를 발생 시킬 수 있다.
         */
    [Obsolete("Use NewMethod", true)]
    public static void OldMethod()
    {
        Console.WriteLine("I'm Old Method");
    }

    public static void NewMethod()
    {
        Console.WriteLine("I'm New Method");
    }

    /**
         *  Conditional은 조건에 따라서 실행여부를 결정한다.
         */
    [Conditional("DEBUG")]
    public static void DebugMethod()
    {
        Console.WriteLine("Debug Method");
    }

    [Conditional("RELEASE")]
    public static void ReleaseMethod()
    {
        Console.WriteLine("Release Method");
    }

    /**
         * .NET 제공 특성을 통해서 Methd 정보 추출하기
         */
    public static void GetMethodInfo(
        string message,
        [CallerMemberName] string caller = "",
        [CallerFilePath] string filePath = "",
        [CallerLineNumber] int callerLineNum = 0
    )
    {
        Console.WriteLine($"실행내용: {message} \n 호출자: {caller} \n 파일경로: {filePath} \n 호출 위치: {callerLineNum}");
    }


    /**
         * 사용자 지정 특성 만들기
         * Attribute를 상속한다.
         * 호출 할 때는 뒤에붙은 Attribute를 생략 할 수 있다.
         * 아래의 Attribute는 [Custom] 혹은 [CustomAttribute]로 호출 할 수 있다.
         */
    public class CustomAttribute : Attribute
    {

    }

    [Custom]
    public static void CallCustomMethod()
    {

    }

    }
}