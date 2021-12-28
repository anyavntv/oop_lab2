using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Windows.Forms;

namespace Lab2
{
    class Search
    {
        private ISearchStrategy _strategy;
        private Laptop _searchRequest;
        private string _path;
        public Search(ref ISearchStrategy strategy, ref Laptop searchRequest, string path)
        {
            _strategy = strategy;
            _searchRequest = searchRequest;
            _path = path;
        }
        public List<Laptop> Run()
        {
            return _strategy.Search(_searchRequest, _path);
        }
    }
    public class PriceRange
    {
        public static bool CheckFormat(string priceRange)
        {
            Regex regex = new Regex(@"(^(0|([1-9]+([0-9]+)?))-([1-9]+([0-9]+)?)$)"); //^0-234020$ or  ^1302-32031$ 
            MatchCollection matches = regex.Matches(priceRange);
            return matches.Count != 0;  
        }
        public static bool CheckBelonging(string priceChecked, string priceRange)
        {
            int separatorIndex = priceRange.IndexOf('-');
            int price = Int32.Parse(priceChecked);
            int lowerBound = Int32.Parse(priceRange.Substring(0, separatorIndex));
            int upperBound = Int32.Parse(priceRange.Substring(separatorIndex+1));
            return price >= lowerBound && price <= upperBound;
        }
    }
    interface ISearchStrategy
    {
        List<Laptop> Search(Laptop searchrequest, string path);
       
    }
    class DomSearchStrategy : ISearchStrategy
    {
        public List<Laptop> Search(Laptop searchRequest, string path)
        {
            List<Laptop> result = new List<Laptop>();
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            XmlNode root = doc.DocumentElement;
            foreach(XmlNode node in root.ChildNodes)
            {
                string manufacturer = "";
                string price = "";
                string condition = "";
                string os = "";
                string model = "";    //searchRequest doesnot contain those fields...
                string serialNumber= "";
                foreach(XmlAttribute attribute in node.Attributes)
                {
                    if(attribute.Name.Equals("Manufacturer") && (attribute.Value.Equals(searchRequest.Manufacturer) || searchRequest.Manufacturer.Equals("Будь-який")))
                        manufacturer = attribute.Value;
                    if (attribute.Name.Equals("Model"))  //...but we add them to a result without any conditons 
                        model = attribute.Value;
                    if (attribute.Name.Equals("SerialNumber")) //
                        serialNumber = attribute.Value;
                    if (attribute.Name.Equals("Price") && PriceRange.CheckBelonging(attribute.Value, searchRequest.Price))
                        price = attribute.Value;
                    if (attribute.Name.Equals("Condition") && (attribute.Value.Equals(searchRequest.Condition) || searchRequest.Condition.Equals("Будь-який")))
                        condition = attribute.Value;
                    if (attribute.Name.Equals("OS") && (attribute.Value.Equals(searchRequest.OS) || searchRequest.OS.Equals("Будь-яка")))
                        os = attribute.Value;
                }
                if (manufacturer != "" && condition != "" && price != "" && os != "")
                {
                    Laptop laptop = new Laptop
                    {
                        Manufacturer = manufacturer,
                        Price = price,
                        Condition = condition,
                        OS = os,
                        Model = model,
                        SerialNumber = serialNumber
                    };
                    result.Add(laptop);
                }
            }
            return result;
        }
    }
    class SaxSearchStrategy : ISearchStrategy
    {
        public List<Laptop> Search(Laptop searchRequest, string path)
        {
            List<Laptop> result = new List<Laptop>();
            XmlTextReader xmlReader = new XmlTextReader(path);
            while (xmlReader.Read())
            {
                if (xmlReader.HasAttributes)
                {
                    while (xmlReader.MoveToNextAttribute())
                    {
                        string manufacturer = "";
                        string price = "";
                        string condition = "";
                        string os = "";
                        string model = "";    //searchRequest doesnot contain those fields...
                        string serialNumber = "";
                        if (searchRequest.Manufacturer.Equals("Будь-який") || xmlReader.Name.Equals("Manufacturer") && xmlReader.Value.Equals(searchRequest.Manufacturer))
                        {
                            manufacturer = xmlReader.Value;
                            xmlReader.MoveToNextAttribute();
                            if (xmlReader.Name.Equals("Model")) //...but we add them without any conditions
                            {
                                model = xmlReader.Value;
                                xmlReader.MoveToNextAttribute();
                                if (xmlReader.Name.Equals("SerialNumber")) //
                                {
                                    serialNumber = xmlReader.Value;
                                    xmlReader.MoveToNextAttribute();
                                    if (searchRequest.Price.Equals("0") || xmlReader.Name.Equals("Price") && PriceRange.CheckBelonging(xmlReader.Value, searchRequest.Price))
                                    {
                                        price = xmlReader.Value;
                                        xmlReader.MoveToNextAttribute();
                                            if (searchRequest.Condition.Equals("Будь-який") || xmlReader.Name.Equals("Condition") && xmlReader.Value.Equals(searchRequest.Condition))
                                            {
                                            condition = xmlReader.Value;
                                            xmlReader.MoveToNextAttribute();
                                            if (searchRequest.OS.Equals("Будь-яка") || xmlReader.Name.Equals("OS") && xmlReader.Value.Equals(searchRequest.OS))
                                            {
                                                os = xmlReader.Value;
                                            }  
                                        }
                                    }
                                }      
                            }   
                        }
                        if (manufacturer != "" && condition != "" && price != "" && os != "")
                        {
                            Laptop laptop = new Laptop
                            {
                                Manufacturer = manufacturer,
                                Price = price,
                                Condition = condition,
                                OS = os,
                                Model = model,
                                SerialNumber = serialNumber
                            };
                            result.Add(laptop);
                        }
                    }
                }
            }
            xmlReader.Close();
            return result;
        }
    }
    class LinqSearchStrategy : ISearchStrategy
    {
        public List<Laptop> Search(Laptop searchRequest, string path)
        {
            List<Laptop> result = new List<Laptop>();
            XDocument doc = XDocument.Load(path);
            var resultCollection = from obj in doc.Descendants("Laptop")
                      where 
                      (obj.Attribute("Manufacturer").Value.Equals(searchRequest.Manufacturer) || searchRequest.Manufacturer.Equals("Будь-який")) &&
                      PriceRange.CheckBelonging(obj.Attribute("Price").Value, searchRequest.Price) &&
                      (obj.Attribute("Condition").Value.Equals(searchRequest.Condition) || searchRequest.Condition.Equals("Будь-який")) &&
                      (obj.Attribute("OS").Value.Equals(searchRequest.OS) || searchRequest.OS.Equals("Будь-яка")) 
                      select new
                      {
                          manufacturer = (string)obj.Attribute("Manufacturer"),
                          price = (string)obj.Attribute("Price"),
                          condition = (string)obj.Attribute("Condition"),
                          os = (string)obj.Attribute("OS"),
                          model = (string)obj.Attribute("Model"),  //searchRequest doesnot contain those fields but we add them without any conditions
                          serialNumber = (string)obj.Attribute("SerialNumber"),
                      };
            foreach (var node in resultCollection)
            {
                Laptop laptop = new Laptop
                {
                    Manufacturer = node.manufacturer,
                    Price = node.price,
                    Condition = node.condition,
                    OS = node.os,
                    Model = node.model,
                    SerialNumber = node.serialNumber
                };
                result.Add(laptop);
            }
            return result;
        }
    }
}
