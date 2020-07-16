using System;
using System.Text.RegularExpressions;

namespace _2048Game {

    public class Player
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
            this.username = this.IsUsernameValid(_userName);
            this.password = this.IsPasswordValid(_password);
            this.email = _email;
            this.totalGame = _totalGame;
            this.totalScore = _totalScore;
            this.dateCreation = _dateCreation;
            this.lastLogged = _lastLogged;
            this.isLogged = _isLogged;
        }

        /// <summary>
        /// property of the username attribute
        /// </summary>
        public string Username 
        { 
            get => this.username;
            set => this.username = this.IsUsernameValid(value);
        }

        /// <summary>
        /// property of the password attribute
        /// </summary>
        public string Password 
        { 
            get => password;
            set => this.password = this.IsPasswordValid(value);
        }

        /// <summary>
        /// property of the email attribute
        /// </summary>
        public string Email 
        {
            get => email;
            set => this.email = this.IsEmailValid(value);
        }

        /// <summary>
        /// property of the totalGame attribute
        /// </summary>
        public int TotalGame
        { 
            get => this.totalGame;
            set => this.totalGame = value;
        }

        /// <summary>
        /// property of the totalScore attribute
        /// </summary>
        public int TotalScore 
        {
            get => this.totalScore;
            set => this.totalScore = value;
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
        /// accept the paramater if the username contains only letter betwen 4 to 10 characters
        /// </summary>
        /// <param name="_userName"></param>
        private string IsUsernameValid(string _userName)
        {
            Regex usernameRegex = new Regex(@"^[a-zA-Z]{4,10}");
            if(usernameRegex.IsMatch(_userName))
            {
                return _userName;
            }
            return " ";
        }

        /// <summary>
        /// accept the parameter if he contains minimum 8 characters and respect the rules of password
        /// </summary>
        /// <param name="_password"></param>
        private string IsPasswordValid(string _password)
        {
            //@"^(?=.*[a-zA-Z])(?=.*[0-9])(?=.*[!@#\$%\^&\*])(?=.{8,32})"
            Regex passwordRegex = new Regex(@"^(?=.*[a-zA-Z])(?=.*[0-9])(?=.*[!@#\$%\^&\*])(?=.{8,32})");
            if (passwordRegex.IsMatch(_password))
            {
                return _password;
            }
            return " ";
        }

        /// <summary>
        /// accept the parameter if he is formated in email format
        /// </summary>
        /// <param name="_email"></param>
        private string IsEmailValid(string _email)
        {
            Regex emailRegex = new Regex(@"^[a-z0-9._-]+@[a-z0-9._-]+.[a-z]{2,6}$");
            if (emailRegex.IsMatch(_email))
            {
                return _email;
            }
            return " ";
        }

    }

}