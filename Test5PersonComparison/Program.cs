namespace Test5PersonComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            

            string cmd = Console.ReadLine();

            while (!cmd.Equals("END"))
            {
                string[] info = cmd.Split();
                Person person = new Person(info[0], int.Parse(info[1]), info[2]);
                people.Add(person);

                cmd = Console.ReadLine();
            }

            int n = int.Parse(Console.ReadLine());

            Person p = people[n - 1];
            int equalsPeopleCount = 0;
            int notEqualsPeoplesCount = 0;

            for (int i = 0; i < people.Count; i++)
            {
                if (i == n - 1)
                {
                    continue;
                }
                if (people[i].CompareTo(p) == 0)
                {
                    equalsPeopleCount++;
                }
                else
                {
                    notEqualsPeoplesCount++;
                }
            }

            Console.WriteLine(equalsPeopleCount == 0 ? "No matches!" : $"{equalsPeopleCount} {notEqualsPeoplesCount} {people.Count}");
        }
    }
}
