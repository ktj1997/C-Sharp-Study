namespace Collection
{
    class Collection
    {
        static void Main(string[] args)
        {
            /**
			  * 1차원 Array
			  */
            int len = 5;
            var array1 = new string[] { "Array", "List", "Dictionary" };
            var array2 = new string[len];

            array2[0] = "hello";
            array2[1] = "my";
            array2[2] = "name";
            array2[3] = "is";
            array2[4] = "xxx";

            Console.WriteLine($"Length = {array2.Length}");
            foreach (string token in array2)
            {
                Console.WriteLine(token);
            }

            /**
			  * 2차원 Array
			  * Length는 모든 dimension을 포함한 element의 개수를 의미한다.
			  * GetLength(dimension)을 통해서 해당 dimension의 길이를 구할 수 있다.
			  * ,(comma)로 dimension을 구분한다.
			  */
            var array3 = new int[2, 3]; // 2 x 3 배열 생성

            for (int i = 0; i < array3.GetLength(0); i++)
            {
                for (int j = 0; j < array3.GetLength(1); j++)
                {
                    array3[i, j] = i + j;
                    Console.Write(array3[i, j] + " ");
                }
                Console.WriteLine();
            }

            var array4 = new int[,] { { 1, 2 }, { 3, 4 } };

            Console.WriteLine($"Row = {array4.GetLength(0)}");
            Console.WriteLine($"Column = {array4.GetLength(1)}");


            /**
			  * List
			  */
            var list1 = new List<string> { "Array", "List", "Dictonary" };
            var list2 = new List<string>();

            list2.Add("hello");
            list2.Add("my");
            list2.Add("name");
            list2.Add("is");
            list2.Add("xxx");


            foreach (var token in list1)
            {
                Console.WriteLine(token);
            }

            foreach (var token in list2)
            {
                Console.WriteLine(token);
            }

            /**
			 * Dictionary
			 */
            var dictionary1 = new Dictionary<int, string>
            {
                {1,"Array"},{2,"List"},{3,"Dictionary"}
            };
            var dictionary2 = new Dictionary<int, string>();


            /**
			  * Key로 Value 얻기
			  */
            foreach (int key in dictionary1.Keys)
            {
                Console.WriteLine(dictionary1[key]);
            }
            /**
			  * KeyValuePair로 동시에 얻기
			  */
            foreach (KeyValuePair<int, string> pair in dictionary1)
            {
                Console.WriteLine($"key: {pair.Key} value: {pair.Value}");
            }
            /**
			  * Value만 얻기
			  */
            foreach (string value in dictionary1.Values)
            {
                Console.WriteLine(value);
            }


            dictionary2.Add(1, "hello");
            dictionary2.Add(2, "my");
            dictionary2.Add(3, "name");
        }
    }
}