using System;
using NUnit.Framework;
using _2048Game;

namespace _2048GameTest
{
    public class PlayerTest
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test()
        {
            Player player1 = new Player("Xgamer", "5j87p2n5k@", "xgamer@gmail.com", 0, 0, DateTime.Now, DateTime.Now, true);
            Player player2 = new Player("Gamer2048", "2#23cv6cqx", "gamer2048@outlook.fr", 0, 0, DateTime.Now, DateTime.Now, true);

            //we update the data of the player
            player1.Username = "GameMaster";
            player1.Email = "gamemaster@gmail.com";
            player1.TotalGame = 12;
            player1.TotalScore = 1200;
            player1.LastLogged = DateTime.Now;
            
            //we check if we have the waited result in player1
            StringAssert.Contains(player1.Username, "GameMaster");
            StringAssert.Contains(player1.Email, "gamemaster@gmail.com");
            StringAssert.Contains(player1.Password, "5j87p2n5k@");

            //we check if we have the waited result in player2
            StringAssert.Contains(player2.Username, "Gamer2048");
            StringAssert.Contains(player2.Email, "gamer2048@outlook.fr");
            StringAssert.Contains(player2.Password, "2#23cv6cqx");
        }
    }
}