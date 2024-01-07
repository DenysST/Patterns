namespace Builder;

public class Human
{
    private readonly string? _firstName;
    private readonly string? _lastName;
    private readonly int _age;
    private readonly Gender _gender;
    private readonly string[]? _citizenship;

    private Human(Builder builder)
    {
        _firstName = builder.FirstName;
        _lastName = builder.LastName;
        _age = builder.Age;
        _gender = builder.Gender;
        _citizenship = builder.Citizenship;
    }

    public class Builder
    {
        public string? FirstName { get; private set; }
        public string? LastName { get; private set; }
        public int Age { get; private set; }
        public Gender Gender { get; private set; }
        public string[]? Citizenship { get; private set; }

        public Builder SetFirstName(string firstName)
        {
            FirstName = firstName.Trim();
            return this;
        }

        public Builder SetLastName(string lastName)
        {
            LastName = lastName.Trim();
            return this;
        }

        public Builder SetAge(int age)
        {
            Age = age;
            return this;
        }

        public Builder SetGender(Gender gender)
        {
            Gender = gender;
            return this;
        }

        public Builder SetCitizenship(string[]? citizenship)
        {
            Citizenship = citizenship;
            return this;
        }

        public Human Build()
        {
            Validate(this);
            return new Human(this);
        }

        private static void Validate(Builder builder)
        {
            if (string.IsNullOrWhiteSpace(builder.FirstName))
            {
                throw new InvalidOperationException("First name cannot be empty");
            }

            if (builder.Age <= 0)
            {
                throw new InvalidOperationException("Age cannot be less than or equal to 0");
            }
        }
    }
    
    public override string ToString()
    {
        return $"Human: {{firstName: {_firstName}, lastName: {_lastName}, age: {_age}, gender: {_gender}, citizenship: {string.Join(", ", _citizenship)}}}";
    }

    public enum Gender
    {
        MALE, FEMALE, OTHER
    }
}