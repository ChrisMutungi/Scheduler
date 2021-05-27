using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TarmacSystem;

namespace Scheduling_Interviews.Login
{
    class CallServer
    {
        private ViewClass viewClass;
        public CallServer()
        {
            viewClass = new ViewClass();
        }
        public string CallHTTP(string email, string password)
        {
            WebRequest request = WebRequest.Create("http://192.168.137.83:4000/employer/desktopLogin");
            request.Method = "POST";
            string postData = "email=" + email + "&password=" + password;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            using (dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                if (responseFromServer == "Does not exist")
                {
                    return responseFromServer;
                }
                else if (responseFromServer == "incorrect")
                {
                    return responseFromServer;
                }
                else
                {

                    if (responseFromServer != "[]")
                    {
                        int count = 0;
                        var ValueList = JsonConvert.DeserializeObject<List<dynamic>>(responseFromServer);
                        for (int i = 0; i < ValueList.Count; i++)
                        {
                            int[] fyle = ValueList[i].file.data.ToObject<int[]>();
                            List<byte> bite = new List<byte>(fyle.GetUpperBound(0) * sizeof(byte));
                            foreach (int integer in fyle)
                            {
                                bite.Add(BitConverter.GetBytes(integer)[0]);
                            }
                            viewClass.InsertApplications((string)(ValueList[i].fname), (string)(ValueList[i].lname), (string)(ValueList[i].email), (string)(ValueList[i].phoneNo), (string)(ValueList[i].gender), (string)(ValueList[i].maritalStatus), (string)(ValueList[i].pAddress), (string)(ValueList[i].name), bite.ToArray()); ;
                            count++;
                        }
                        response.Close();
                        return count + " Yay! new applications found";
                    }
                    else
                    {
                        response.Close();
                        return "Ooops! No new applications";
                    }
                }

            }

        }
    }
}

  