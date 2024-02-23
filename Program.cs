using GenericDemo;

//BetterList<int> betterNumber = new BetterList<int>();
//betterNumber.AddToList(5);

//BetterList<PersonRecord> people = new BetterList<PersonRecord>();
//people.AddToList(new("Khai", "truong"));

//SampleClass<PersonModel, int> test = new SampleClass<PersonModel, int>();

var intMath = new MathOperations<int>();
Console.WriteLine(intMath.Add(1, 5));


var doubleMath = new MathOperations<double>();
Console.WriteLine(doubleMath.Add(5.5, 5.5));

record PersonRecord(string firstName, string lastName);

class PersonModel
{
    public int Id { get; set; }

    public PersonModel()
    {

    }
}