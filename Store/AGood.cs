using UnityEngine;
using System.Collections;
/// <summary>
/// Store good type.商品的类型  可以继续添加类型
/// </summary>
public enum StoreGoodType
{		
		/// <summary>
		/// The equit.装备
		/// </summary>
		装备,
		/// <summary>
		/// The skill. 技能
		/// </summary>
		技能,
		/// <summary>
		/// The pet.宠物
		/// </summary>
		宠物
}
/// <summary>
/// A store good.作为商品需要实现的接口
/// </summary>
public  interface AGood
{	/// <summary>
		/// Gets or sets the name of the equit.商品名称
		/// </summary>
		/// <value>The name of the equit.</value>
		string EquitName{ set; get; }
		/// <summary>
		/// Gets or sets the number.商品的数量
		/// </summary>
		/// <value>The number.</value>
		int Number{ set; get; }
		/// <summary>
		/// Gets or sets the price.商品的价格
		/// </summary>
		/// <value>The price.</value>
		int Price{ set; get; }

		/// <summary>
		/// Gets or sets the type. 商品的类型   商店可以根据商品的属性再进行分类
		/// </summary>
		/// <value>The type.</value>
		StoreGoodType Type{ set; get; }
		/// <summary>
		/// Players the buy good. 玩家买这件商品需要花费的代价  这里的PlayerDate 最好优化成接口
		/// </summary>
		/// <param name="myPlayerDate">My player date.</param>
		void PlayerBuyGood (PlayerDate myPlayerDate);
		/// <summary>
		/// The name of the user interface ture.商品的图片 UI图片
		/// </summary>
		string UITureName{ set; get; }
		/// <summary>
		/// Equits the show.显示商品的描述  当鼠标放在商品上时调用 
		/// </summary>
		string  ShowEquit ();
		/// <summary>
		/// Need the specified myPlayerDate. 买这件物体的要求 返回bool
		/// </summary>
		/// <param name="myPlayerDate">My player date.</param>
		bool Need (PlayerDate myPlayerDate);
		
}
