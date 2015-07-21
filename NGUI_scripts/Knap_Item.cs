using UnityEngine;
using System.Collections;

public class Knap_Item : UIDragDropItem
{
		public UISprite sprite;
		public UILabel label;
		public  int count = 1;
		//public void 
		public void AddCount (int number=1)
		{
				count += number;
				label.text = count + "";
		}



		protected override void OnDragDropRelease (GameObject surface)
		{
				base.OnDragDropRelease (surface);
				//print ("1");
				if (surface.tag == "Cell") {
						this.transform .parent = surface.transform;
						this.transform .localPosition = Vector3.zero;
				} else if (surface.tag == "Knap_item") {
						Transform parent = this.transform .parent;
						this.transform.parent = surface.transform.parent;
						this.transform.localPosition = Vector3.zero;
						surface.transform .parent = parent;
						surface.transform.localPosition = Vector3.zero;
				}
		}

}
