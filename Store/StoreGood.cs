using UnityEngine;
using System.Collections;

public class StoreGood : AStoreGood
{
	
		public 	StoreGood (AGood good)
		{
				myGood = good;
		}
		/// <summary>
		/// Gets or sets the good. 没有经过商店处理过的商品
		/// </summary>
		/// <value>The good.</value>
		private  AGood myGood;
		/// <summary>
		/// Gets or sets the number.该商店给商品编号
		/// </summary>
		/// <value>The number.</value>
		private	int storeNumber; 
		/// <summary>
		/// Gets or sets the modify price.差价   商品的价格=原始价格+差价
		/// </summary>
		/// <value>The modify price.</value>
		private	int modifyPrice;

		/// <summary>
		/// My store good position.商品在商店的位置
		/// </summary>
		private Vector3  myStoreGoodPosition;

		/// <summary>
		/// Shows the equit商品的描述
		/// </summary>
		/// <returns>The equit.</returns>
		public string  ShowEquit ()
		{
				return myGood.ShowEquit ();
		}

#region  Base Setters and Getters
		/// <summary>
		/// Gets or sets the good. 没有经过商店处理过的商品
		/// </summary>
		/// <value>The good.</value>
		public AGood Good { 
				set { 
						myGood = value;
				}
				get {
						return myGood;
				}
		}
		/// <summary>
		/// Gets or sets the number.该商店给商品编号
		/// </summary>
		/// <value>The number.</value>
		public int StoreNumber { 
				set { 
						storeNumber = value;
				}
				get {
						return storeNumber;
				}
		}
		/// <summary>
		/// Gets or sets the modify price.差价 商品的价格=原始价格+差价
		/// </summary>
		/// <value>The modify price.</value>
		public int ModifyPrice { 
				set { 
						modifyPrice = value;
				}
				get {
						return modifyPrice;
				}
		}
		/// <summary>
		/// Gets or sets my store good position.商品的位置
		/// </summary>
		/// <value>My store good position.</value>
		public Vector3  MyStoreGoodPosition { 
				set { myStoreGoodPosition = value; }
				get { return myStoreGoodPosition;}
		}

#endregion

}
