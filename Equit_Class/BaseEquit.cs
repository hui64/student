using UnityEngine;
using System.Collections;
public class BaseEquit:AEquit,AGood
{
		/// <summary>
		/// The is who. 装备的拥有者  默认为系统
		/// </summary>
		private string isWho;
		/// <summary>
		/// The name.装备的名称
		/// </summary>
		private string equitName;
		/// <summary>
		/// The price. 装备的价格
		/// </summary>
		private int price;
		/// <summary>
		/// The type.装备的类型   
		/// </summary>
		private StoreGoodType type;
		/// <summary>
		/// The chandi.装备的产地
		/// </summary>
		private string chandi;
		/// <summary>
		/// The name of the user interface ture.装备的图片 UI图片
		/// </summary>
		private string uiTureName;
		/// <summary>
		/// The moder.装备的模型   当装备 离开UI在游戏场景时引用的模型
		/// </summary>
		private GameObject moder;
		/// <summary>
		/// The level.装备的等级
		/// </summary>
		private int level;
		/// <summary>
		/// The number.装备的数量
		/// </summary>
		private int number;
		/// <summary>
		/// The attribute.装备的属性   
		/// </summary>
		private AttributeEquit[] attributes;
		/// <summary>
		/// The equit skill.  装备上拥有的技能
		/// </summary>
		public ASkill equitSkill;
		/// <summary>
		/// Initializes a new instance of the <see cref="BaseEquit"/> class.构造函数
		/// </summary>
		public  BaseEquit ()
		{
		}
	
	
	
		/// <summary>
		/// Equits the level up.z装备升级时  属性也跟着提升
		/// </summary>
		public  void  equitLevelUp ()
		{ 
				foreach (AttributeEquit  attribute in attributes) {
						attribute.LevelUp ();
				}
		}
	
		/// <summary>
		/// Useds the equit skill.使用装备上附带的技能
		/// </summary>
		public  void usedEquitSkill ()
		{
				equitSkill.Used ();
		}
		/// <summary>
		/// Equits the show.显示装备的描述  当鼠标放在装备上时调用 
		/// </summary>
		public string  ShowEquit ()
		{
				return equitName + "\n" + "等级" + "\n" + Level;
		}
		/// <summary>
		/// Players the buy good. 玩家买这件商品需要花费的代价 这里的PlayerDate 最好优化成接口
		/// </summary>
		/// <param name="myPlayerDate">My player date.</param>
		public 	void PlayerBuyGood (PlayerDate myPlayerDate)
		{
		}
		/// <summary>
		/// Need this instance. 可以拥有这个商品的条件
		/// </summary>
		public bool Need (PlayerDate myPlayerDate)
		{
				return true;
		}

#region  Base Setters and Getters
		/// <summary>
		/// Gets or sets a value indicating whether this instance is who.装备的拥有者
		/// </summary>
		/// <value><c>true</c> if this instance is who; otherwise, <c>false</c>.</value>
		public string IsWho {
				get{ return isWho;}
				set {
						isWho = value;
				}
		}
	
		/// <summary>
		/// Gets or sets the name of the equit.装备的名字
		/// </summary>
		/// <value>The name of the equit.</value>
		public string EquitName {
				get{ return equitName;}
		
				set {
						equitName = value;
				}
		}
		/// <summary>
		/// Gets or sets the type.装备的 类型
		/// </summary>
		/// <value>The type.</value>
		public StoreGoodType Type {
				get{ return type;}
				set {
						type = value;
				}
		}
	
	
	
		/// <summary>
		/// Gets or sets the chandi.装备的产地
		/// </summary>
		/// <value>The chandi.</value>
		public string Chandi {
				get { return chandi;}
		
				set {
						chandi = value;
				}
		}
	
	
		/// <summary>
		/// Gets or sets the name of the user interface ture. 装备的UI图片
		/// </summary>
		/// <value>The name of the user interface ture.</value>
		public string UITureName {
				get { return uiTureName;}
		
				set {
						uiTureName = value;
				}
		}
		/// <summary>
		/// Gets or sets the moder.装备的3D模型
		/// </summary>
		/// <value>The moder.</value>
		public GameObject Moder {
				get{ return moder;}
				set {
						moder = value;
				}
		}
		public int Price {
				get{ return price;}
				set {
						price = value;
				}
		}
		/// <summary>
		/// Gets or sets the number.商品的数量  装备的数量
		/// </summary>
		/// <value>The number.</value>
		public int Number {
				get{ return number;}
				set {
						number = value;
				}
		}

		/// <summary>
		/// Gets or sets the level.		装备的等级
		/// </summary>
		/// <value>The level.</value>
		public int Level {
				get{ return level;}
				set {
						level = value;
				}
		}
		/// <summary>
		/// Gets the attribute equit.根据枚举  返回对应的装备属性
		/// </summary>
		/// <returns>The attribute equit.</returns>
		/// <param name="myEnumNumber">My enum number.</param>
		public AttributeEquit GetAttributeEquit (int myEnumNumber)
		{
				return attributes [myEnumNumber];
		}	
	
#endregion
}
