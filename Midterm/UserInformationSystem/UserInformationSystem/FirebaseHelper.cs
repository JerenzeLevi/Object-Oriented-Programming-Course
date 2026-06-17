using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace UserInformationSystem
{
    class FirebaseHelper
    {
        private static readonly HttpClient httpClient = new HttpClient();
        //REPLACE THIS LINK BELOW, DON'T YA THINK OF DOING SMTH WEIRD OR I SLAP YO BUTTCHEEKS WHEN I CATCH YOU
        private static readonly string baseUrl = "https://oopdatabase-671fc-default-rtdb.firebaseio.com/";

        //save Data

        public static async Task SaveDataAsync(string path, object data)
        {
            string json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync(baseUrl + path + ".json", content);
            response.EnsureSuccessStatusCode();
        }

        //get Data


    }
}
