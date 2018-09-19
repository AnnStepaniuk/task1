using Store.BLL.DTO;
using Store.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.BLL.Services
{
    class GamesService : IGamesService
    {
        public void AddComentToGame(CommentDTO comment)
        {
            throw new NotImplementedException();
        }

        public void CreateGame(GameDTO game)
        {
            throw new NotImplementedException();
        }

        public void DeleteGame(int id)
        {
            throw new NotImplementedException();
        }

        public void EditGame(GameDTO game)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CommentDTO> GetAllCommentsByGameId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GameDTO> GetAllGames()
        {
            throw new NotImplementedException();
        }

        public GameDTO GetGameByKey(int id)
        {
            throw new NotImplementedException();
        }
    }
}
