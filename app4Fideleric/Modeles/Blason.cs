using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app4Fideleric.Modeles
{
    public class Blason
    {
        #region Attributs

        private string _nomBlason;
        private double _montantAchats;

        #endregion

        #region Constructeurs

        public Blason(string leNomBlason, double leMontantAchats)
        {
            _montantAchats = leMontantAchats;
            _nomBlason = leNomBlason;
        }
        public Blason() { }


        #endregion

        #region Getters/Setters

        [JsonProperty("nomBlason")]
        public string NomBlason { get => _nomBlason; set => _nomBlason = value; }

        [JsonProperty("montantAchats")]
        public double MontantAchats { get => _montantAchats; set => _montantAchats = value; }

        #endregion

        #region Methodes

        #endregion
    }

}

