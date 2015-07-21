using UnityEngine;
using System.Collections;

public class Knapsack : MonoBehaviour
{
		public GameObject[] cells;
		public string[] itemName; 
		public GameObject item;
		private bool isFind  ;

		/// <summary>
		/// Picks up.捡起物品时在背包中生成该物品 同一物品可以叠加
		/// </summary>
		public void PickUp ()
		{
				isFind = false;
				int index = Random.Range (0, itemName.Length);
				string name = itemName [index];

				for (int i=0; i<cells.Length; i++) {
						if (cells [i].transform.childCount > 0) {
								Knap_Item item = cells [i].GetComponentInChildren<Knap_Item> ();
								if (item.sprite.spriteName == name) {
										if (item .count < 10) {
												isFind = true;
												item.AddCount (1);
												break;
										}
								}
						}
				}
				if (isFind == false) {
						
						for (int i=0; i<cells.Length; i++) {
								if (cells [i].transform.childCount == 0) {
										GameObject go = NGUITools.AddChild (cells [i], item);
										go.GetComponent<UISprite> ().spriteName = name;
										go.transform .localPosition = Vector3.zero;
										
										break;

								}
						}
				}
		}
		void Update ()
		{
				if (Input.GetKeyDown (KeyCode.T))
						PickUp ();
		}
		
}
