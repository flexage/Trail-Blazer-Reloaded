using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;
using System.Net;
using Newtonsoft.Json;

namespace TrailBlazerReloaded
{
    public class Trakt
    {
        public string title { get; set; }
        public string trailer { get; set; }

        public Trakt()
        {

        }

        public string GetMovieTrailer(string MovieID)
        {
            var client = new RestClient("http://api.trakt.tv/");

            var request = new RestRequest("movie/summary.json/{apikey}/{title}/", Method.GET);
            request.AddUrlSegment("apikey", "e2704bb0dc140899de955c25c3513541");
            request.AddUrlSegment("title", MovieID);

            var resp = client.Execute(request);

            if (resp.ResponseStatus == ResponseStatus.Completed)
            {
                Trakt traktObject = JsonConvert.DeserializeObject<Trakt>(resp.Content);
                return traktObject.trailer;
            }
            else
            {
                return null;
            }
        }
    }
}
