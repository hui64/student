using UnityEngine;
using System.Collections;
/// <summary>
/// A store good. 经过商店处理过的商品 
/// </summary>
public interface AStoreGood
{
		
		/// <summary>
		/// Gets or sets the good. 没有经过商店处理过的商品
		/// </summary>
		/// <value>The good.</value>
		AGood Good{ set; get; }
		/// <summary>
		/// Gets or sets the number.该商店给商品编号
		/// </summary>
		/// <value>The number.</value>
		int StoreNumber{ set; get; }
		/// <summary>
		/// Gets or sets the modify price.差价   商品的价格=原始价格+差价
		/// </summary>
		/// <value>The modify price.</value>
		int ModifyPrice{ set; get; }

		/// <summary>
		/// Gets or sets my store good position.商品的位置
		/// </summary>
		/// <value>My store good position.</value>
		Vector3 MyStoreGoodPosition{ set; get; }
		/// <summary>
		/// Shows the equit商品的描述
		/// </summary>
		/// <returns>The equit.</returns>
		string  ShowEquit ();
}
