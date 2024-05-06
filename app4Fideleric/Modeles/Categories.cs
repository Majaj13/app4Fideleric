using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app4Fideleric.Modeles
{
    public class Categories
    {
        #region Attributs

        private int _id;
        private string _nomCategorie;
        private List<Produit> _produits;

        #endregion

        #region Constructeurs

        public Categories(int id, string nomCategorie, List<Produit> produits)
        {
            _id = id;
            _nomCategorie = nomCategorie;
            _produits = produits;
        }

        #endregion

        #region Getters/Setters

        [JsonProperty("id")]
        public int Id { get => _id; set => _id = value; }

        [JsonProperty("nomCategorie")]
        public string NomCategorie { get => _nomCategorie; set => _nomCategorie = value; }

        [JsonProperty("produits")]
        public List<Produit> Produits { get => _produits; set => _produits = value; }

        #endregion

        #region Methodes

        public string Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static Categories Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<Categories>(json);
        }

        #endregion
    }
}
