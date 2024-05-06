using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace app4Fideleric.Modeles
{
    public class User
    {
        #region Attributs

        private int _id;
        private string _email;
        private string _nom;
        private string _prenom;
        private string _passwordHash;
        private string _telephone;
        private DateTime _dateNaissance;

        #endregion

        #region Constructeurs

        public User() { }

        public User(int id, string email, string nom, string prenom, string password, string telephone, DateTime dateNaissance)
        {
            _id = id;
            _email = email;
            _nom = nom;
            _prenom = prenom;
            _passwordHash = HashPassword(password);
            _telephone = telephone;
            _dateNaissance = dateNaissance;
        }

        #endregion

        #region Getters/Setters

        [JsonProperty("id")]
        public int Id { get => _id; set => _id = value; }

        [JsonProperty("email")]
        public string Email { get => _email; set => _email = value; }

        [JsonProperty("nom")]
        public string Nom { get => _nom; set => _nom = value; }

        [JsonProperty("prenom")]
        public string Prenom { get => _prenom; set => _prenom = value; }

        [JsonProperty("password")]
        public string Password
        {
            get { return _passwordHash; }
            set { _passwordHash = HashPassword(value); }
        }

        [JsonProperty("telephone")]
        public string Telephone { get => _telephone; set => _telephone = value; }

        [JsonProperty("dateNaissance")]
        public DateTime DateNaissance { get => _dateNaissance; set => _dateNaissance = value; }

        #endregion

        #region Methodes

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        public string Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static User Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<User>(json);
        }

        #endregion
    }
}