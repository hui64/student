using UnityEngine;
using System.Collections;

public class chatInput : MonoBehaviour
{
		public  UIInput input;
		public UITextList textlist;
		public void OneEnter ()
		{
				textlist.Add (input.value);
				input .value = "";
		}
}
