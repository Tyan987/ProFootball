using ProFootball.Handler;
using ProFootball.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProFootball.Controller
{
    public class PlayerController
    {
        public static List<Player> ViewPlayer()
        {
            List<Player> ply = PlayerHandler.ViewPlayer();
            return ply;
        }

        public static List<Player> ViewPlayerByUser(string email)
        {
            List<Player> ply = PlayerHandler.ViewPlayerByUser(email);
            return ply;
        }

        public static Player FindById(int Id)
        {
            return PlayerHandler.FindById(Id);
        }

        public static string InsertPlayer(string name, string image, string nationality, string club, string age, string price, string playerPosID, string extension)
        {
            int ageInt = 0;
            int priceInt = 0;
            int posInt = 0;

            if (name.Equals("") || nationality.Equals("") || club.Equals("") || image.Equals("") || age.Equals("") || playerPosID.Equals(""))
            {
                return "All fields must be filled";
            }

            if (name.Length < 4)
            {
                return " Name must be more than 4 characters ";
            }

            if (!int.TryParse(age, out ageInt))
            {
                return "Age number must be numeric ";
            }

            else if (ageInt < 17)
            {
                return "Player age must be more than 17 years old";
            }

            if (!int.TryParse(price, out priceInt))
            {
                return "Price number must be numeric ";
            }

            else if (priceInt < 100000 && priceInt > 10000000)
            {
                return "Price must between 100000 and 10000000";
            }

            if (!int.TryParse(playerPosID, out posInt))
            {
                return "Player Position ID number must be numeric ";
            }

            if (!extension.Equals(".jpg"))
            {
                return "Image extension must be .jpg";
            }
            return PlayerHandler.InsertPlayer(name, image, nationality, club, ageInt, priceInt, posInt);
        }

        public static string UpdatePlayer(int Id, string name, string image, string nationality, string club, string age, string price, string playerPosID, string extension)
        {
            int ageInt = int.Parse(age);
            int priceInt = int.Parse(price);
            int posInt = int.Parse(playerPosID);

            if (name.Equals("") || nationality.Equals("") || club.Equals("") || image.Equals("") || age.Equals("") || playerPosID.Equals(""))
            {
                return "All fields must be filled";
            }

            if (name.Length < 4)
            {
                return " Name must be more than 4 characters ";
            }

            if (ageInt < 17)
            {
                return "Player age must be more than 17 years old";
            }

            if (priceInt < 100000 && priceInt > 10000000)
            {
                return "Price must between 100000 and 10000000";
            }

            if (!extension.Equals(".jpg"))
            {
                return "Image extension must be .jpg";
            }
            return PlayerHandler.UpdatePlayer(Id, name, image, nationality, club, ageInt, priceInt, posInt);
        }

        public static string DeletePlayer(int Id)
        {
            return PlayerHandler.DeletePlayer(Id);
        }
    }
}