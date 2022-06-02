namespace For
{

    class For
    {
        static void Main(string[] args)
        {
            /**
			  * do-while, while 등도 존재한다.
			  */
            List<int> nums = new List<int>();
            string alphabets = "abcdefghijklmnopqrstuvwxyz";



            nums.Add(1);
            nums.Add(2);
            nums.Add(3);

            for (int i = 0; i < 3; i++)
            {

            }

            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }

            foreach (char alphabet in alphabets)
            {
                if (alphabet == 'y')
                    break;
                Console.WriteLine(alphabet);
            }




        }
    }
}