using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace app4Fideleric.Modeles
{
    public class Commande
    {
        #region Attributs

        private int _id;
        private User _user;
        private DateTime _dateCommande;
        private List<OrderItem> _orderItems;
        private float _total;

        #endregion

        #region Constructeurs

        public Commande(int id, User user, DateTime dateCommande, List<OrderItem> orderItems, float total)
        {
            _id = id;
            _user = user;
            _dateCommande = dateCommande;
            _orderItems = orderItems;
            _total = total;
        }

        #endregion

        #region Getters/Setters

        [JsonProperty("id")]
        public int Id { get => _id; set => _id = value; }

        [JsonProperty("user")]
        public User User { get => _user; set => _user = value; }

        [JsonProperty("dateCommande")]
        public DateTime DateCommande { get => _dateCommande; set => _dateCommande = value; }

        [JsonProperty("orderItems")]
        public List<OrderItem> OrderItems { get => _orderItems; set => _orderItems = value; }

        [JsonProperty("total")]
        public float Total { get => _total; set => _total = value; }

        #endregion

        #region Methodes

        public string Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static Commande Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<Commande>(json);
        }

        #endregion
    }
}
