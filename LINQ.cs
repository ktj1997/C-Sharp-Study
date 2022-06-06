using System.Globalization;
namespace LINQ
{   /**
	  *  Language INtegrated Query
	  *  Collection 형태의 데이터를 가공 할 때 유용한 메소드를 제공한다.
	  *  확장 메소드이다.
	  */
    class LINQ
    {
        static void Main(string[] args)
        {
            /**
			  * 기본적인 확장 메소드
			  * Sum(), Max(), Min(), Count(), Average() 등 이 있다.
			  */
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine($"sum: {numbers.Sum()}");
            Console.WriteLine($"average: {numbers.Average()}");
            Console.WriteLine($"elementCount: {numbers.Count()}");

            /**
			  * <<Method LINQ>>
			  * Lambda(람다)를 이용한 처리
			  * Where문과 Lambda식을 이용해서 여러가지 처리가 가능하다.
			  * Where문의 리턴 값은 IEnumerable이다.
			  * 체이닝이 가능하다.
			  */
            IEnumerable<int> enumberableNumbers = numbers.Where(it => it % 2 == 0); //IEnumerable도 루프를 돌 수 있다.
            List<int> newNumbers = enumberableNumbers.ToList();
            foreach (int num in newNumbers)
            {
                Console.WriteLine(num);
            }
            /**
			  * Take(int n): n개만 가져오기
			  */
            List<int> partialNumbers = enumberableNumbers.Take(3).ToList();
            foreach (int num in partialNumbers)
            {
                Console.WriteLine(num);
            }

            /**
			  * Skip(int n): n개의 데이터를 스킵하고 가져온다.
			  */
            List<int> skipNumbers = enumberableNumbers.Skip(2).ToList();

            foreach (int num in skipNumbers)
            {
                Console.WriteLine(num);
            }

            /**
			  * OrderBy: 정렬
			  */
            List<int> descList = enumberableNumbers.OrderByDescending(it => it).ToList();
            foreach (int num in descList)
            {
                Console.WriteLine(num);
            }
            List<int> ascList = descList.OrderBy(it => it).ToList();
            foreach (int num in ascList)
            {
                Console.WriteLine(num);
            }

            /**
			  * <<Query LINQ>>
			  * SQL과 비슷한 Query구문으로 원하는 결과를 얻을 수 있다.
			  */
            int evenSum = (from num in numbers where num % 2 == 0 select num).Sum();
            Console.WriteLine($"Even Sum = {evenSum}");

            List<int> evenList = (
                from num in numbers
                where num % 2 == 0
                select num
            ).ToList();

            foreach (int num in evenList)
            {
                Console.WriteLine(num);
            }

            /**
			  * Query LINQ를 이용한 정렬
			  */
            List<int> descEvenList = (
                from num in numbers
                where num % 2 == 0
                orderby num descending
                select num
            ).ToList();
            foreach (int num in descEvenList)
            {
                Console.WriteLine(num);
            }

            /**
			  *	Foreach: LINQ내에서 Loop를 돌 수 있디.
			  */
            descEvenList.ForEach(it => Console.WriteLine(it));
        }
    }
}