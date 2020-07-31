using System;
using NUnit.Framework;
using _2048Game;

namespace _2048GameTest
{
    public class PlayerTest
    {

        Player player1;
        Player player2;

        /// <summary>
        /// Constructor of the PlayerTest class
        /// Instantiate two object of the Player class
        /// </summary>
        public PlayerTest()
        {
            this.player1 = new Player("Xgamer", "5j87p2n5k@", "xgamer@gmail.com", 0, 0, DateTime.Now, DateTime.Now, true);
            this.player2 = new Player("Gamer2048", "2#23cv6cqx", "gamer2048@outlook.fr", 0, 0, DateTime.Now, DateTime.Now, true);
        }

        [SetUp]
        public void Setup()
        {
            
        }

        /// <summary>
        /// we check if we have the waited result in player1.username
        /// </summary>
        [Test]
        public void UsernameRegexTest()
        {
            player1.Username = "GameMaster";
            StringAssert.Contains(player1.Username, "GameMaster");
            StringAssert.Contains(player2.Username, "Gamer2048");
        }

        /// <summary>
        /// we check if we have the waited result in player1.email
        /// </summary>
        public void EmailRegexTest()
        {
            player1.Email = "gamemaster@gmail.com";
            StringAssert.Contains(player1.Email, "gamemaster@gmail.com");
            StringAssert.Contains(player2.Email, "gamer2048@outlook.fr");
            player2.Email = "ttoto@arfp.asso.fr";
            StringAssert.Contains(player2.Email, "ttoto@arfp.asso.fr");
        }

        /// <summary>
        /// we check if we have the waited result in player1.password
        /// </summary>
        public void PasswordRegexTest()
        {
            StringAssert.Contains(player1.Password, "5j87p2n5k@");
            StringAssert.Contains(player2.Password, "2#23cv6cqx");
        }
    
    }

}