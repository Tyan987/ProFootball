using ProFootball.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProFootball.Repository
{
    public class PlayerPositionRepository
    {
        public static List<PlayerPosition> PlayerPositionList()
        {
            ProFootballDatabaseEntities db = new ProFootballDatabaseEntities();
            return (from plyPos in db.PlayerPositions select plyPos).ToList();
        }

        public static bool FindPosById(int Id)
        {
            ProFootballDatabaseEntities db = new ProFootballDatabaseEntities();
            PlayerPosition check = (from plyPos in db.PlayerPositions where plyPos.PositionID == Id select plyPos).FirstOrDefault();

            if (check == null) return true;
            else return false;
        }
    }
}