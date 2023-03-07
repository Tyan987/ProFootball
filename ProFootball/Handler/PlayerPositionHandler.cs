using ProFootball.Model;
using ProFootball.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProFootball.Handler
{
    public class PlayerPositionHandler
    {
        public static List<PlayerPosition> ViewPlayerPosition()
        {
            List<PlayerPosition> playerPos = PlayerPositionRepository.PlayerPositionList();
            return playerPos;
        }
    }
}