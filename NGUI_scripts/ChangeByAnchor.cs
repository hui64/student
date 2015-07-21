using UnityEngine;
using System.Collections;

public class ChangeByAnchor : MonoBehaviour
{

		public int mywidth ;
		public int myheight;
		public int Left;
		public int Right;
		public int Bottom;
		public int Top;
		public UIWidget UIcomponent;
		public float bywidth;
		public float byheight;	
		
		
		void Start ()
		{
				UIcomponent = GetComponent<UIWidget > ();
				
		}

		public void Changed ()
		{
				
				UIcomponent.leftAnchor.absolute = (int)(Left * (bywidth * Screen.width / mywidth + byheight * Screen.height / myheight));
				UIcomponent.rightAnchor.absolute = (int)(Right * (bywidth * Screen.width / mywidth + byheight * Screen.height / myheight));
				UIcomponent.bottomAnchor.absolute = (int)(Bottom * (bywidth * Screen.width / mywidth + byheight * Screen.height / myheight));
				UIcomponent.topAnchor.absolute = (int)(Top * (bywidth * Screen.width / mywidth + byheight * Screen.height / myheight));
				
				
				

		}




		

	
		// Update is called once per frame
		void Update ()
		{
				Changed ();
		}
}
