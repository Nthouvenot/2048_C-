using System;
using System.Text.RegularExpressions;

namespace _2048Game {

    class Player
    {
        private string username;
        private string password;
        private string email;
        private int totalGame;
        private int totalScore;
        private DateTime dateCreation;
        private DateTime lastLogged;
        private bool isLogged;

        /// <summary>
        /// constructor with all the attribute of the class in parameters
        /// </summary>
        /// <param name="_userName">string</param>
        /// <param name="_password">string</param>
        /// <param name="_email">string</param>
        /// <param name="_totalGame">int</param>
        /// <param name="_totalScore">int</param>
        /// <param name="_dateCreation"">DateTime</param>
        /// <param name="_lastLogged">DateTime</param>
        /// <param name="_isLogged">bool</param>
        public Player(string _userName, string _password, string _email, int _totalGame, int _totalScore, DateTime _dateCreation, DateTime _lastLogged, bool _isLogged)
        {
            this.SetUsername(_userName);
            this.SetPassword(_password);
            this.SetEmail(_email);
            this.SetTotalGame(_totalGame);
            this.SetTotalScore(_totalScore);
            this.SetDateCreation(_dateCreation);
            this.SetLastLogged(_lastLogged);
            this.SetIsLogged(_isLogged);
        }

        /// <summary>
        /// property of the username attribute
        /// </summary>
        public string Username 
        {
            get => username;
            set
            {
                this.SetUsername(value);
            }
        }

        /// <summary>
        /// setter of the userName attribute
        /// accept the paramater if the username contains only letter betwen 4 to 10 characters
        /// </summary>
        /// <param name="_userName"></param>
        private void SetUsername(string _userName)
        {
            if(Regex.Match(_userName, "^[a - zA - Z]{ 4, 10 }").Success)
            {
                this.username = _userName;
            }
        }

        /// <summary>
        /// getter of the password attribute
        /// </summary>
        /// <returns>string</returns>
        public string GetPassword()
        {
            return this.password;
        }

        /// <summary>
        /// setter of the password attribute
        /// accept the parameter if he contains minimum 8 characters and respect the rules of password
        /// </summary>
        /// <param name="_password"></param>
        public void SetPassword(string _password)
        {
            if(Regex.Match(_password, "^(?=.*[a-zA-Z])(?=.*[0-9])(?=.*[!@#$%^&*])(?=.{8,})").Success)
            {
                this.password = _password;
            }
        }

        /// getter of the email attribute
        /// </summary>
        /// <returns>string</returns>
        public string GetEmail()
        {
            return this.email;
        }

        /// <summary>
        /// setter of the email atribute
        /// </summary>
        /// <param name="_email"></param>
        public void SetEmail(string _email)
        {
            if (Regex.Match(_email, "^[a-z0-9._-]+@[a-z0-9._-]+.[a-z]{2,6}$").Success)
            {
                this.email = _email;
            }
        }

        /// <summary>
        /// getter of the totalGame attribute
        /// </summary>
        /// <returns>int</returns>
        public int GetTotalGame()
        {
            return this.totalGame;
        }

        /// <summary>
        /// setter of the totalGame attribute
        /// </summary>
        /// <param name="_totalGame"></param>
        public void SetTotalGame(int _totalGame)
        {
            //ToDo test the range of the parameter or what else ?
            this.totalGame = _totalGame;
        }

        /// <summary>
        /// getter of the totalScore attribute
        /// </summary>
        /// <returns>int</returns>
        public int GetTotalScore()
        {
            return this.totalScore;
        }

        /// <summary>
        /// setter of the totalScore attribute
        /// </summary>
        /// <param name="_totalScore"></param>
        public void SetTotalScore(int _totalScore)
        {
            //ToDo test the range of the parameter or what else ?
            this.totalScore = _totalScore;
        }

        /// <summary>
        /// getter of the dateCreation attribute
        /// </summary>
        /// <returns>DateTime</returns>
        public DateTime GetDateCreation()
        {
            return this.dateCreation;
        }

        /// <summary>
        /// setter of the dateCreation attribute
        /// </summary>
        /// <param name="_dateCreation"></param>
        public void SetDateCreation(DateTime _dateCreation)
        {
            this.dateCreation = _dateCreation;
        }

        /// <summary>
        /// getter of the lastLogged attribute
        /// </summary>
        /// <returns></returns>
        public DateTime GetLastLogged()
        {
            return this.lastLogged;
        }

        /// <summary>
        /// setter of the lastLogged attribute
        /// </summary>
        /// <param name="_lastLogged"></param>
        public void SetLastLogged(DateTime _lastLogged)
        {
            this.lastLogged = _lastLogged;
        }

        /// <summary>
        /// return true if the player is logged
        /// </summary>
        /// <returns>bool</returns>
        public bool IsLogged()
        {
            return this.isLogged;
        }

        /// <summary>
        /// setter of the islogged attribute
        /// </summary>
        /// <param name="_isLogged"></param>
        public void SetIsLogged(bool _isLogged)
        {
            this.isLogged = _isLogged;
        }
    }

}