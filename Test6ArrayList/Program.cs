namespace Test6ArrayList
{

    class Program

    {

        static void Main(string[] args)

        {

            CustomList<string> list = new CustomList<string>();

            list.Add("Pesho");

            list.Add("Gosho");

            list.Add("Tosho");

            Console.WriteLine(list.Length);

            Console.WriteLine(list.Capacity);

            try
            {
                Console.WriteLine(list.Get(-2)); //
            }

            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

            list.Set(2, "Geri");
            Console.WriteLine(list.Get(2));

            try
            {
                list.RemoveAt(-1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }




            foreach (var item in list)

            {

                Console.WriteLine(item);

            }

        }


    }
}