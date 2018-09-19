using Store.DAL.EF;
using Store.DAL.Entities;
using Store.DAL.Interfaces;
using System;
using System.Threading.Tasks;

namespace Store.DAL.Repositories
{
    internal class UnitOfWork : IUnitOfWork
    {
        private StoreContext context ;
        private GenericRepository<Publisher> publisherRepository;
        private GenericRepository<Game> gameRepository;
        private GenericRepository<Comment> commentRepository;
        private GenericRepository<Genre> genreRepository;
        private GenericRepository<PlatformType> platformTypeRepository;

        public UnitOfWork()
        {
            context = new StoreContext();
        }

        public IRepository<Publisher> PublisherRepository
        {
            get
            {
                if (publisherRepository == null)
                {
                    publisherRepository = new GenericRepository<Publisher>(context);
                }
                return publisherRepository;
            }
        }

        public IRepository<Game> GameRepository
        {
            get
            {
                if (gameRepository == null)
                {
                    gameRepository = new GenericRepository<Game>(context);
                }
                return gameRepository;
            }
        }

        public IRepository<Comment> CommentRepository
        {
            get
            {
                if (commentRepository == null)
                {
                    commentRepository = new GenericRepository<Comment>(context);
                }
                return commentRepository;
            }
        }

        public IRepository<Genre> GenreRepository
        {
            get
            {
                if (genreRepository == null)
                {
                    genreRepository = new GenericRepository<Genre>(context);
                }
                return genreRepository
;
            }
        }

        public IRepository<PlatformType> PlatformTypeRepository
        {
            get
            {
                if (platformTypeRepository == null)
                {
                    platformTypeRepository = new GenericRepository<PlatformType>(context);
                }
                return platformTypeRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }
    }
}
