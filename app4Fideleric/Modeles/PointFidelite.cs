using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace app4Fideleric.Modeles
{
    public class PointFidelite
    {
        #region Attributs

        private int _id;
        private string _nomPoint;
        private int _points;
        private List<Recompenses> _recompenses;

        #endregion

        #region Constructeurs

        public PointFidelite(int id, string nomPoint, int points, List<Recompenses> recompenses)
        {
            _id = id;
            _nomPoint = nomPoint;
            _points = points;
            _recompenses = recompenses;
        }

        #endregion

        #region Getters/Setters

        [JsonProperty("id")]
        public int Id { get => _id; set => _id = value; }

        [JsonProperty("nomPoint")]
        public string NomPoint { get => _nomPoint; set => _nomPoint = value; }

        [JsonProperty("points")]
        public int Points { get => _points; set => _points = value; }

        [JsonProperty("recompenses")]
        public List<Recompenses> Recompenses { get => _recompenses; set => _recompenses = value; }

        #endregion

        #region Methodes

        public string Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static PointFidelite Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<PointFidelite>(json);
        }

        #endregion
    }
}
