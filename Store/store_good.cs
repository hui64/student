using UnityEngine;
using System.Collections;

public class store_good : MonoBehaviour
{		/// <summary>
		/// My user interface sprite. 该物体上的UISprite
		/// </summary>
		public UISprite myUISprite;
		/// <summary>
		/// My user interface lable sprite.label的背景图片
		/// </summary>
		public UISprite myUILableSprite;
		/// <summary>
		/// My label.该物体的子物体 Label的引用
		/// </summary>
		public UILabel myLabel;
		/// <summary>
		/// My store good.该商店的商品
		/// </summary>
		public AStoreGood myStoreGood;
		/// <summary>
		/// Mouses the over.鼠标移上时调用
		/// </summary>
		public void MouseOver ()
		{
				myLabel.enabled = true;
				myUILableSprite.enabled = true;
		}
		/// <summary>
		/// Mouses the out.鼠标离开时调用
		/// </summary>
		public void MouseOut ()
		{
				myLabel.enabled = false;
				myUILableSprite.enabled = false;
		}
		/// <summary>
		/// Raises the click event.鼠标点击时调用  
		/// </summary>
		public void OnClick ()
		{
				int i = myStoreGood.StoreNumber;
				int j = (int)(myStoreGood.Good.Type);
				myStoreGood.Good.Number--;
				if (myStoreGood.Good.Number < 1) {
						UIstore.storeGoods [j].Remove (UIstore.storeGoods [j] [i]);
						for (int k=i; i<UIstore.storeGoods[j].Count; k++) {
								UIstore.storeGoods [j] [k].StoreNumber--;
						}
				}
				//print (myStoreGood.StoreNumber);
		}

		public void setSpriteAndLabel ()
		{
				myLabel.text = myStoreGood.ShowEquit (); 
				myUISprite.spriteName = myStoreGood.Good.UITureName; 
		}


		// Use this for initialization
		void Start ()
		{
				
				//print (myLabel.transform.position);
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
}
