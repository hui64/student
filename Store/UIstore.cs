using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System ;
public class UIstore : MonoBehaviour,AStore
{		/// <summary>
		/// The store_goods.商店上商品共分为这几种类型
		/// </summary>
		public GameObject[] storeGoodType;
		/// <summary>
		/// My store lable position.装备介绍 显示的位置
		/// </summary>
		public Vector3 myStoreLablePosition;
		/// <summary>
		/// The _store good.商店商品的预制
		/// </summary>
		public GameObject _storeGood;
		/// <summary>
		/// The _store goods.s商店商品类型的预制
		/// </summary>
		public GameObject _storeGoods;
		public GameObject _UIstore;
		/// <summary>
		/// The money. 商店拥有的财产
		/// </summary>
		private  int money;

		/// <summary>
		/// The store goods. 所有的商品
		/// </summary>
		public  static  List<AStoreGood>[] storeGoods;
		/// <summary>
		/// Gets the date.买入商品
		/// </summary>
		/// <param name="myGood">My good.</param>
		public void BuyGood (AGood myGood)
		{
				AddGood (myGood);
				
		}
		/// <summary>
		/// Adds the good.添加商品  并且引入该商品的修改价格   商店商品的价格 等于 商品的价格+修改价格（modifyprice） 
		/// </summary>
		/// <param name="myGood">My good.</param>
		private void AddGood (AGood myGood, int modifyprice=0)
		{
				bool isFind = false;
				int i = (int)(myGood.Type);
				foreach (AStoreGood storeGood in storeGoods[i]) {
						
						if (storeGood.Good.EquitName == myGood .EquitName) {
								isFind = true;
								storeGood.Good.Number += myGood.Number;  
						}
				}
				if (!isFind) {
						AStoreGood myStoreGood = new StoreGood (myGood);
						
						GameObject go = NGUITools.AddChild (storeGoodType [i], _storeGood);
						
						store_good myScript = go.GetComponent<store_good> ();
						
						storeGoods [i].Add (myStoreGood);
						AStoreGood good1 = storeGoods [i] [storeGoods [i].Count];
						good1.StoreNumber = storeGoods [i].Count;
						good1.ModifyPrice = modifyprice;
						
						int x = (i % 3) * 80;
						int y = (int)(i / 3) * 50;
						go.transform.localPosition = new Vector3 (180 - x, 90 - y, 0);
						go.GetComponent<UILabel> ().transform.localPosition = myStoreLablePosition;
						good1.MyStoreGoodPosition = myStoreLablePosition;
						myScript.myStoreGood = good1;
						myScript.setSpriteAndLabel ();
						//NGUITools.AddChild ();
				}
		}
		/// <summary>
		/// Sells the good.卖出商品
		/// </summary>
		/// <param name="storeGood">Store good.</param>
		public  void SellGood (AStoreGood storeGood)
		{
		}
		/// <summary>
		/// Gets or sets the money.拥有的财产
		/// </summary>
		/// <value>The money.</value>
		public int Money {

				set{ money = value;}
				get{ return money;}
		}
		/// <summary>
		/// Gets or sets the store goods.商店拥有的商品
		/// </summary>
		/// <value>The store goods.</value>
		
		public List<AStoreGood>[] StoreGoods { 
				get { return storeGoods; }
				set { storeGoods = value;}
		} 


		// Use this for initialization
		void Start ()
		{
				myStoreLablePosition = transform.FindChild ("myLabelPosition").transform.position;
				storeGoods = new List<AStoreGood>[Enum.GetValues (typeof(StoreGoodType)).Length];
				storeGoodType = new GameObject[Enum.GetValues (typeof(StoreGoodType)).Length];
				for (int i=0; i<storeGoodType.Length; i++) {
						storeGoodType [i] = NGUITools.AddChild (_UIstore, _storeGoods);
						storeGoodType [i].transform.localPosition = Vector3.zero;
						storeGoodType [i].GetComponent<store_goods> ().myUILabel.text = Enum.GetName (typeof(StoreGoodType), i);
						storeGoodType [i].GetComponent<store_goods> ().myLabel.transform.localPosition = new Vector3 (128, 44 - i * 50, 0);
				}
				//print (Enum.GetName (typeof(StoreGoodType), 0)); 
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
}
