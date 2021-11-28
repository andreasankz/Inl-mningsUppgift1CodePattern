using System.Collections.Generic;

namespace InlämningsUppgift1CodePattern.Animal
{
    public interface IAnimalFactory
    {
        public List<IDog> ListOfDogs { get; set; }

        public void RegisterDog();

        public void ListAllDogs();

    }
}
