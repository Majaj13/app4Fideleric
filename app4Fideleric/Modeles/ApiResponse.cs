using System;
using System.Text;
using Newtonsoft.Json;

namespace app4Fideleric.Modeles
{
    public class ApiResponse
    {
        #region Attributs

        [JsonProperty("success")]
        private bool _success;

        [JsonProperty("message")]
        private string _message;

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        private object _data;

        #endregion

        #region Constructeurs

        public ApiResponse(bool success, string message, object data = null)
        {
            _success = success;
            _message = message;
            _data = data;
        }

        #endregion

        #region Getters/Setters

        public bool Success { get => _success; set => _success = value; }

        public string Message { get => _message; set => _message = value; }

        public object Data { get => _data; set => _data = value; }

        #endregion

        #region Methodes

        public string Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static ApiResponse Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<ApiResponse>(json);
        }

        #endregion
    }
}
