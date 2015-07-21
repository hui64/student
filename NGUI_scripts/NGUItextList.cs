using UnityEngine;
using System.Collections;

public class NGUItextList : MonoBehaviour
{
		public UITextList myTextList;
		private int index = 0;
		// Use this for initialization
		void Start ()
		{
				myTextList = this.GetComponent<UITextList> ();
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (Input.GetKeyDown (KeyCode.Q)) {
						myTextList.Add ("unity 游戏蛮牛" + index);
						index++;
				}
	
		}
}
