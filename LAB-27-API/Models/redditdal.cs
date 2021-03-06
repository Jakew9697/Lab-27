﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace LAB_27_API.Models
{
    public class RedditDal
    {
        public string GetAPIJson()
        {
            string url = $"https://www.reddit.com/r/aww/.json";

            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // convert the response into something useable
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string output = reader.ReadToEnd();
            return output;
        }
        public Aww GetAww()
        {
            string data = GetAPIJson();
            Aww aww = JsonConvert.DeserializeObject<Aww>(data);
            return aww;
        }

    }
}
