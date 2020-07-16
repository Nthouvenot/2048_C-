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
            this.dateCreation = _dateCreation;
            this.lastLogged = _lastLogged;
            this.isLogged = _isLogged;
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
        /// property of the password attribute
        /// </summary>
        public string Password 
        { 
            get => password;
            set
            {
                this.SetPassword(value);
            }
        }

        /// <summary>
        /// property of the email attribute
        /// </summary>
        public string Email 
        {
            get => email;
            set
            {
                this.SetEmail(value);
            }
        }

        /// <summary>
        /// property of the totalGame attribute
        /// </summary>
        public int TotalGame
        { 
            get => totalGame; 
            set
            {
                this.SetTotalGame(value);
            } 
        }

        /// <summary>
        /// property of the totalScore attribute
        /// </summary>
        public int TotalScore 
        {
            get => totalScore;
            set 
            {
                this.SetTotalScore(value);
            }
        }

        /// <summary>
        /// property of the dateCreation attribute
        /// </summary>
        public DateTime DateCreation 
        {
            get => dateCreation; 
            set => dateCreation = value;
        }

        /// <summary>
        /// property of the lasLogged attribute
        /// </summary>
        public DateTime LastLogged 
        { 
            get => lastLogged; 
            set => lastLogged = value;
        }

        /// <summary>
        /// property of the isLogged attribute
        /// </summary>
        public bool IsLogged1 
        { 
            get => isLogged; 
            set => isLogged = value; 
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
        /// setter of the password attribute
        /// accept the parameter if he contains minimum 8 characters and respect the rules of password
        /// </summary>
        /// <param name="_password"></param>
        private void SetPassword(string _password)
        {
            if(Regex.Match(_password, "^(?=.*[a-zA-Z])(?=.*[0-9])(?=.*[!@#$%^&*])(?=.{8,})").Success)
            {
                this.password = _password;
            }
        }

        /// <summary>
        /// setter of the email atribute
        /// </summary>
        /// <param name="_email"></param>
        private void SetEmail(string _email)
        {
            if (Regex.Match(_email, "^[a-z0-9._-]+@[a-z0-9._-]+.[a-z]{2,6}$").Success)
            {
                this.email = _email;
            }
        }

        /// <summary>
        /// setter of the totalGame attribute
        /// </summary>
        /// <param name="_totalGame"></param>
        private void SetTotalGame(int _totalGame)
        {
            //ToDo test the range of the parameter or what else ?
            this.totalGame = _totalGame;
        }

        /// <summary>
        /// setter of the totalScore attribute
        /// </summary>
        /// <param name="_totalScore"></param>
        private void SetTotalScore(int _totalScore)
        {
            //ToDo test the range of the parameter or what else ?
            this.totalScore = _totalScore;
        }

    }

}