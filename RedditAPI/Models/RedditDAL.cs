using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace RedditAPI.Models
{
    public class RedditDAL
    {

        public Child GetPost(int index)
        {
            string url = "https://www.reddit.com/r/aww/.json";
            //2 We need to create our request 
            HttpWebRequest request = WebRequest.CreateHttp(url);

            //3 If your API needs any kind of login or key, that may go here
            //SWAPI doesn't need anything sp we're good

            //Now we're ready to send off our request and grab the server's response
            //Inside our response, the resulting data lives 
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Pull the result into a stream reader which will then give us a string
            StreamReader rd = new StreamReader(response.GetResponseStream());

            //Grab our response string - read to end starts at the top of our file and returns each line
            //until it hits the end. 
            string result = rd.ReadToEnd();
            rd.Close(); 

            //Converts JSON string into a person object automatically
            SubReddit sr = JsonConvert.DeserializeObject<SubReddit>(result);

            return sr.data.children[index]; 
        }
    public List<Child> GetAllPosts()
    {
        string url = "https://www.reddit.com/r/aww/.json";
        //2 We need to create our request 
        HttpWebRequest request = WebRequest.CreateHttp(url);

        //3 If your API needs any kind of login or key, that may go here
        //SWAPI doesn't need anything sp we're good

        //Now we're ready to send off our request and grab the server's response
        //Inside our response, the resulting data lives 
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();

        //Pull the result into a stream reader which will then give us a string
        StreamReader rd = new StreamReader(response.GetResponseStream());

        //Grab our response string - read to end starts at the top of our file and returns each line
        //until it hits the end. 
        string result = rd.ReadToEnd();
        rd.Close(); 

        //Converts JSON string into a person object automatically
        SubReddit sr = JsonConvert.DeserializeObject<SubReddit>(result);
        List<Child> newList = new List<Child>(); 
        for(int i= 0; i<10; i++)
        {
            newList.Add(sr.data.children[i]);

        }
        return newList; 
    }
    }



}
