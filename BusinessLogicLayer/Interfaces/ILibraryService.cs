using EntitiesLayer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interfaces
{
    public interface ILibraryService
    {
        Task<IEnumerable<Genre>> GetAllGenre();
        Task CreateBook(Book book); 
    }

  
   
}
