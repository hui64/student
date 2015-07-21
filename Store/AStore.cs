using UnityEngine;
using System.Collections;
using System.Collections.Generic;




/// <summary>
/// A store. 装备在商店上的接口
/// </summary>
public interface AStore
{		/// <summary>
		/// Gets or sets the money.拥有的财产
		/// </summary>
		/// <value>The money.</value>
		int Money{ set; get; }
		/// <summary>
		/// Gets or sets the store goods.商店拥有的商品
		/// </summary>
		/// <value>The store goods.</value>
		List<AStoreGood>[] StoreGoods{ get; set; } 
		/// <summary>
		/// Gets the date.买入商品
		/// </summary>
		void BuyGood (AGood myGood);
		/// <summary>
		/// Sells the good.卖出商品
		/// </summary>
		/// <param name="storeGood">Store good.</param>
		void SellGood (AStoreGood storeGood);

}
