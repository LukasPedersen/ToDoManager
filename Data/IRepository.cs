using ToDoManager.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ToDoManager.Data
{
    public interface IRepository
    {
        // Hent alle personer
        List<Person> GetAll();
        // Hent person ud fra Id
        Person GetItemById(int? id);
        // Indsæt en ny person i listen
        void Insert(Person person);
        // Opdatere en eksisterende person i listen
        void Update(Person person);
        // Fjern en person fra listen
        void Remove(int id);
    }
}
