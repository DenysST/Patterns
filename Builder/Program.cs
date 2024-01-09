using Builder;

internal class Program {
    public static void Main(string[] args) {
        Human human = new Human.Builder()
            .SetFirstName("Test name")
            .SetLastName("test name")
            .SetAge(20)
            .SetGender(Human.Gender.MALE)
            .SetCitizenship(new [] {"test"})
            .Build();
        Console.WriteLine(human);
    }
}