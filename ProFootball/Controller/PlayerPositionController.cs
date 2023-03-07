using ProFootball.Handler;
using ProFootball.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProFootball.Controller
{
    public class PlayerPositionController
    {
        public static List<PlayerPosition> ViewPlayerPosition()
        {
            List<PlayerPosition> plyPos = PlayerPositionHandler.ViewPlayerPosition();
            return plyPos;
        }
    }
}