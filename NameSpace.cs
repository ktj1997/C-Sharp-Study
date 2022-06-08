using System; //System 네임스페이스를 사용하는 것이다.
using Custom = System; //별칭을 붙여서 접근도 가능하다.

namespace NameSpace
{
    /**
	  * NameSpace안에 NameSpace가 또 존재 할 수 있다.
	  */
    namespace InnerNameSpace1
    {

        /**
		  * Class이름이 충돌하는 것을 막기위해서 Class, Interface, Enum을 모아서 관리하는 개념이다.
		  * Java의 패키지와 유사하다.
		  * 1. 중복방지
		  * 2. 유사한 개념의 묶음
		  * 3. Class를 계층형으로 묶어서 관리 할 수 있다.
		  */
        class NameSpace
        {
            static void Main(string[] args)
            {

            }
        }
    }
    /**
	  * .으로 중첩을 표시 할 수 도 있다.
	  */
    namespace InnerNameSpace2.InnerNameSpace3 { }
}