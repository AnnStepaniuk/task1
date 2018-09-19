using Store.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Publisher> PublisherRepository { get; }
        IRepository<Game> GameRepository { get; }
        IRepository<Comment> CommentRepository { get; }
        IRepository<Genre> GenreRepository { get; }
        IRepository<PlatformType> PlatformTypeRepository { get; }

        void Save();
        Task SaveAsync();
    }
}
