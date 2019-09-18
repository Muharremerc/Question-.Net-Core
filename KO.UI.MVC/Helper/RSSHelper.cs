using KO.UI.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace KO.UI.MVC.Helper
{
    public class RSSHelper
    {
        public static XmlDocument XmlGetir(string xmlUrl)
        {
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string rssData = client.DownloadString(xmlUrl);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(rssData);
            return doc;
        }

        public static List<SubjectDTO> GetSubjects(string url)
        {
            List<SubjectDTO> subjects = new List<SubjectDTO>();

            XmlDocument doc = XmlGetir(url);
            XmlNodeList nodeList = doc.SelectNodes("rss/channel/item");

            foreach (XmlNode item in nodeList)
            {
                SubjectDTO subject = new SubjectDTO()
                {
                    Description = item.SelectSingleNode("description").InnerText,
                    Title = item.SelectSingleNode("title").InnerText
                };
                subjects.Add(subject);
            }
            return subjects;
        }
    }
}
