using ProFootball.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProFootball.Repository
{
    public class PlayerRepository
    {
        public static List<Player> PlayerList()
        {
            ProFootballDatabaseEntities db = new ProFootballDatabaseEntities();
            return (from ply in db.Players select ply).ToList();
        }

        public static List<Player> PlayerListByUser(string email)
        {
            ProFootballDatabaseEntities db = new ProFootballDatabaseEntities();
            return (from ply in db.Players join trnDet in db.TransactionDetails on ply.PlayerID equals trnDet.PlayerID join trn in db.Transactions on trnDet.TransactionID equals 
                    trn.TransactionID where trn.Email.Equals(email) select ply).ToList();
        }

        public static Player FindById(int Id)
        {
            ProFootballDatabaseEntities db = new ProFootballDatabaseEntities();
            return (from ply in db.Players where ply.PlayerID == Id select ply).FirstOrDefault();
        }

        public static bool CheckPlayer(int plyID)
        {
            ProFootballDatabaseEntities db = new ProFootballDatabaseEntities();
            Player check =  (from ply in db.Players join trnDet in db.TransactionDetails on ply.PlayerID equals trnDet.PlayerID where trnDet.PlayerID == plyID select ply).FirstOrDefault();

            if (check == null) return false;
            else return true;
        }

        public static void InsertPlayer(Player ply)
        {
            ProFootballDatabaseEntities db = new ProFootballDatabaseEntities();
            db.Players.Add(ply);
            db.SaveChanges();
        }

        public static void UpdatePlayer(int PlyId, string name, string image, string nationality, string club, int age, int price, int playerPosID)
        {
            ProFootballDatabaseEntities db = new ProFootballDatabaseEntities();
            Player update = (from ply in db.Players where ply.PlayerID == PlyId select ply).FirstOrDefault();

            update.PlayerID = PlyId;
            update.Name = name;
            update.Image = image;
            update.Nationality = nationality;
            update.Club = club;
            update.Age = age;
            update.Price = price;
            update.PositionID = playerPosID;

            db.SaveChanges();
        }

        public static void DeletePlayer(int Id)
        {
            ProFootballDatabaseEntities db = new ProFootballDatabaseEntities();
            Player delete = (from ply in db.Players where ply.PlayerID == Id select ply).FirstOrDefault();

            db.Players.Remove(delete);
            db.SaveChanges();
        }
    }
}