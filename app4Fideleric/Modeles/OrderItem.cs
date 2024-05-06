using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app4Fideleric.Modeles
{
    public class OrderItem
    {
        #region Attributs

        private int _id;
        private Produit _produit;
        private int _quantity;
        private float _price;

        #endregion

        #region Constructeurs

        public OrderItem(int id, Produit produit, int quantity, float price)
        {
            _id = id;
            _produit = produit;
            _quantity = quantity;
            _price = price;
        }

        #endregion

        #region Getters/Setters

        [JsonProperty("id")]
        public int Id { get => _id; set => _id = value; }

        [JsonProperty("produit")]
        public Produit Produit { get => _produit; set => _produit = value; }

        [JsonProperty("quantity")]
        public int Quantity { get => _quantity; set => _quantity = value; }

        [JsonProperty("price")]
        public float Price { get => _price; set => _price = value; }

        #endregion

        #region Methodes

        public string Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static OrderItem Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<OrderItem>(json);
        }

        #endregion
    }
}
