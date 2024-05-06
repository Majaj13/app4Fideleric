using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app4Fideleric.Modeles
{
    public class Recompenses
    {
        #region Attributs

        private int _id;
        private string _nomRecompense;
        private string _description;
        private int _pointsRequis;
        private List<Produit> _produits;

        #endregion

        #region Constructeurs

        public Recompenses(int id, string nomRecompense, string description, int pointsRequis, List<Produit> produits)
        {
            _id = id;
            _nomRecompense = nomRecompense;
            _description = description;
            _pointsRequis = pointsRequis;
            _produits = produits;
        }

        #endregion

        #region Getters/Setters

        [JsonProperty("id")]
        public int Id { get => _id; set => _id = value; }

        [JsonProperty("nomRecompense")]
        public string NomRecompense { get => _nomRecompense; set => _nomRecompense = value; }

        [JsonProperty("description")]
        public string Description { get => _description; set => _description = value; }

        [JsonProperty("pointsRequis")]
        public int PointsRequis { get => _pointsRequis; set => _pointsRequis = value; }

        [JsonProperty("produits")]
        public List<Produit> Produits { get => _produits; set => _produits = value; }

        #endregion

        #region Methodes

        public string Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static Recompenses Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<Recompenses>(json);
        }

        #endregion
    }
}
