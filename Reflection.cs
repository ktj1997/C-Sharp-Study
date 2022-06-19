using System.Reflection;
using System.Runtime.CompilerServices;

namespace Reflection
{   
    /**
     * MetaData에 대한 정보를 Type형태로 리턴해 줄 수 있다.
     * 런타임에 객체를 생성하고 메소드를 실행 시키는 등의 작업이 가능하다.
     * Runtime 예외에 취약하다.
     */
    public class Reflection
    {
        static void Main(string[] args)
        {
            /**
             * Assembly 클래스를 이용하여 특정 정보를 얻어낼 수 있다.
             */
            Assembly stringAssembly = typeof(string).Assembly;
            Console.WriteLine(stringAssembly);

            /**
             * Member 목록 가져오기
             */
            var stringType = typeof(string);
            foreach (var member in stringType.GetMembers())
            {
                Console.WriteLine(member);
            }

            /**
             *  public이거나 static 인 메소드 가져오기
             */
            MemberInfo[] memberInfos = stringType.GetMembers(BindingFlags.Public | BindingFlags.Static);


            /**
             * 메소드 가져오기
             */
            MethodInfo[] methodInfos = stringType.GetMethods();

            foreach (var method in methodInfos)
            {
                Console.WriteLine(method.Name);
            }

            /**
             * invoke로 실행하기
             */
            var caller = "hi";
            MethodInfo? toStringMethod = stringType.GetMethods().Where(it => it.Name == "ToString").First();
            Console.WriteLine(toStringMethod?.Invoke(caller, null));

            /**
             * 멤버에 적용된 Attibute보기
             */

            var reflectionExampleType = typeof(ReflectionExample);
            foreach (var token in reflectionExampleType.GetProperties())
            {
                Console.WriteLine(token);
            }

            PropertyInfo propertyInfo = reflectionExampleType.GetProperty("Property");
            object[] attribues = propertyInfo.GetCustomAttributes(false);

            foreach (var attribute in attribues)
            {
                Console.WriteLine(attribute);
            }
            /**
             * 인스턴스 동적 생성하기
             * Activator를 사용하여 인스턴스를 생성 할 수 있다.
             * dynamic 키워드가 사용된다.
             */ 
            dynamic dynamicCreationInstance = Activator.CreateInstance(reflectionExampleType);
            Console.WriteLine(dynamicCreationInstance);
        }
    }

    public class ReflectionExample
    {
        [Obsolete]
        public int Property { get; set; }
    }
}