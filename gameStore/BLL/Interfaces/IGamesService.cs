using Store.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.BLL.Interfaces
{
    public interface IGamesService
    {
        void CreateGame(GameDTO game);
        void EditGame(GameDTO game);
        void DeleteGame(int id);
        GameDTO GetGameByKey(int id);
        IEnumerable<GameDTO> GetAllGames();
        void AddComentToGame(CommentDTO comment);
        IEnumerable<CommentDTO> GetAllCommentsByGameId(int id);
    }
}
