using ProFootball.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProFootball.Factory
{
    public class PlayerFactory
    {
        public static Player CreatePlayer(string name, string image, string nationality, string club, int age, int price, int playerPosID)
        {
            Player ply = new Player();
            ply.Name = name;
            ply.Image = image;
            ply.Nationality = nationality;
            ply.Club = club;
            ply.Age = age;
            ply.Price = price;
            ply.PositionID = playerPosID;

            return ply;
        }
    }
}