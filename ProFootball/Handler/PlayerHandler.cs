using ProFootball.Factory;
using ProFootball.Model;
using ProFootball.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProFootball.Handler
{
    public class PlayerHandler
    {
        public static List<Player> ViewPlayer()
        {
            List<Player> players = PlayerRepository.PlayerList();
            return players;
        }

        public static List<Player> ViewPlayerByUser(string email)
        {
            List<Player> players = PlayerRepository.PlayerListByUser(email);
            return players;
        }

        public static string InsertPlayer(string name, string image, string nationality, string club, int age, int price, int playerPosID)
        {
            bool checkPosId = PlayerPositionRepository.FindPosById(playerPosID);
            if (checkPosId == true)
            {
                return "Position not found";
            }

            Player ply = PlayerFactory.CreatePlayer(name, image, nationality, club, age, price, playerPosID);
            PlayerRepository.InsertPlayer(ply);

            return "";
        }

        public static Player FindById(int Id)
        {
            return PlayerRepository.FindById(Id);
        }

        public static string UpdatePlayer(int Id, string name, string image, string nationality, string club, int age, int price, int playerPosID)
        {
            PlayerRepository.UpdatePlayer(Id, name, image, nationality, club, age, price, playerPosID);

            return "";
        }

        public static string DeletePlayer(int Id)
        {
            bool checkPlayer = PlayerRepository.CheckPlayer(Id);

            if (checkPlayer == true)
            {
                return "Player Can not delete";
            }

            PlayerRepository.DeletePlayer(Id);

            return "";
        }
    }
}