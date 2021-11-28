using InlämningsUppgift1CodePattern.Customer;

namespace InlämningsUppgift1CodePattern.Animal
{
    public class Dog : IDog
    {
        public string TypeOfDog { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }

        public ICustomer Owner { get; set; }
    }
}
