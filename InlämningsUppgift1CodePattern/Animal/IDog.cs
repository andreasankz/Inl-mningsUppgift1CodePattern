using InlämningsUppgift1CodePattern.Customer;

namespace InlämningsUppgift1CodePattern.Animal
{
    public interface IDog : IAnimal
    {
        public string TypeOfDog { get; set; }
        public ICustomer Owner { get; set; }
    }
}
