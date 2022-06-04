namespace ExceptionHandling
{
    class ExceptionHandling
    {
        static void Main(string[] args)
        {
            try
            {
                int[] a = { 1, 2, 3, 4 };
                a[100] = 10;
            }
            catch (Exception e)
            {
                Console.WriteLine("Catch!");
                Console.WriteLine(e.Message);
            }
            finally
            {
                /**
                  * 리소스 소멸 등의 로직 처리
                  * 에러 발생 유무와 별개로 무조건 실행된다.
                  */
            }
            /**
              * throw를 통해서 에러를 던진다.
              */
            throw new ArgumentException("ArgumentException");
        }
    }
}