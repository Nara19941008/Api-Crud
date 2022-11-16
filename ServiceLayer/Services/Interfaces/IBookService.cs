using DomainLayer.Entities;
using ServiceLayer.DTOs.Book;
using ServiceLayer.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IBookService
    {
        Task CreateAsync(BookCreateDto book); 
        Task UpdateAsync(int id, BookUpdateDto book); 
        Task DeleteAsync(int id); 
        Task SoftDeleteAsync(int id);
        Task<List<BookListDto>> GetAllAsync();
        Task<Book> GetByIdAsync(int id);
        Task<List<BookListDto>> SearchAsync(string? searchText);     
    }
}
