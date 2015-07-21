using System;  
using UnityEngine;  
using System.IO;  
using System.Xml;  
using System.Linq;  
using System.Text;  
using System.Collections.Generic; 

public class ImportXML : MonoBehaviour
{
		public int speed;
		// Use this for initialization
		void Start ()
		{			
				string filePath = Application.dataPath + @"/XML/game_equit.xml"; 
				XmlDocument doc = new XmlDocument (); 
				doc.Load (filePath);
				//List <string > _allProvinceName = new List<string> ();
				XmlNode provinces = doc.SelectSingleNode ("equit");
				XmlElement _provinces = (XmlElement)provinces; 
				//print (_provinces.GetAttribute ("name"));
				//foreach (XmlElement province in provinces) {
				//XmlElement _province = (XmlElement)province; 
				//speed = province.GetType ();
				//print (speed);
				//	foreach (XmlElement city in province.ChildNodes) {
				//print (city .GetAttribute ("name"));
				//}
						
				//}
		}
		
		// Update is called once per frame
		void Update ()
		{
	
		}
}





