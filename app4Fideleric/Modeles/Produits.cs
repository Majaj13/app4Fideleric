using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app4Fideleric.Modeles
{
    public class Produit
    {
        #region Attributs

        private int _id;
        private string _nomProduit;
        private float _prixProduit;
        private int _pointsFidelite;
         private string _imageUrl;

        #endregion

        #region Constructeurs

        public Produit(int id, string nomProduit, float prixProduit, int pointsFidelite, string imageUrl)
        {
            _id = id;
            _nomProduit = nomProduit;
            _prixProduit = prixProduit;
            _pointsFidelite = pointsFidelite;
            _imageUrl = imageUrl;
        }

        public Produit()
        {
        }

        #endregion

        #region Getters/Setters

        [JsonProperty("UserID")]
        public int Id { get => _id; set => _id = value; }

        [JsonProperty("nomProduit")]
        public string NomProduit { get => _nomProduit; set => _nomProduit = value; }

        [JsonProperty("prixProduit")]
        public float PrixProduit { get => _prixProduit; set => _prixProduit = value; }

        [JsonProperty("pointsFidelite")]
        public int PointsFidelite { get => _pointsFidelite; set => _pointsFidelite = value; }

        [JsonProperty("imageUrl")]
        public string imageUrl { get => _imageUrl; set => _imageUrl = value; }

        #endregion

        #region Methodes

        public string Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static Produit Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<Produit>(json);
        }

        #endregion
    }
}