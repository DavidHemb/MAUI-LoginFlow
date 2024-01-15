using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiLoginFlow.Services
{
    public class AuthService
    {
        private string username;
        private string password;
        private const string AuthStateKey = "AuthState";
        public string Username
        {
            get { return username; }
        }
        public string Password
        {
            get { return password; }
        }
        public void SetUsername(string Username)
        {
            username = Username;
        }
        public void SetPassword(string newPassword)
        {
            password = newPassword;
        }
        public async Task<bool> IsAuthorizedAsync()
        {
            await Task.Delay(1000);
            var authState = Preferences.Default.Get<bool>(AuthStateKey, false);
            return authState;
        }
        public bool Login(string username, string password)
        {
            if (username == "david" && password == "password")
            {
                SetUsername(username);
                SetPassword(password);
                var authState = Preferences.Default.Get<bool>(AuthStateKey, true);
                return authState;
            }
            else
                return false;
        }
        public void Logout()
        {
            Preferences.Default.Remove(AuthStateKey);
        }
        public bool Register(string username, string password)
        {
            if(username != null && password != null)
            {
                SetUsername(username);
                SetPassword(password);
                return true;
            }  
            else 
                return false;
        }
    }
}
