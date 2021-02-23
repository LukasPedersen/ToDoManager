using ToDoManager.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ToDoManager.Data
{
    public interface IRepository
    {
        // Hent alle personer
        List<ToDo> GetAll();
        // Hent person ud fra Id
        ToDo GetItemById(int? id);
        // Indsæt en ny person i listen
        void Insert(ToDo todo);
        // Opdatere en eksisterende person i listen
        void Update(ToDo todo);
        // Fjern en person fra listen
        void Remove(int id);
    }
}
