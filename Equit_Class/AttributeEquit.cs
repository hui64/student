using UnityEngine;
using System.Collections;
/// <summary>
/// Equit attribute.装备的所有属性  
/// </summary>
public enum EquitAttribute
{
		Mighton,        //力量
		Constituion,    //体质
		Nimbleness,     //敏捷
		Speed,          //速度
		Concertration,  //集中
		Willpower,      //意志力
		Charisma        //魅力
}
/// <summary>
/// Mighton equit. 力量型装备 拥有的属性 可以继续添加属性
/// </summary>
public enum MightonEquitAttribute
{
		Mighton,        //力量
		Constituion   //体质
}
/// <summary>
/// Nimbleness. 敏捷型装备 拥有的属性 可以继续添加属性
/// </summary>
public enum NimblenessEquitAttribute
{
		Nimbleness,     //敏捷
		Speed         //速度
}
/// <summary>
/// Jewelry equit.首饰类装备 拥有的属性 可以继续添加属性
/// </summary>
public enum JewelryEquitAttribute
{
		Concertration,  //集中
		Willpower,      //意志力
		Charisma        //魅力
}


public class AttributeEquit
{	 /* /// <summary>
		/// The name of the attribute.属性的名称  比如说力量  敏捷 智力 等
		/// </summary>
		private string _attributeName;*/
		/// <summary>
		/// The _value.属性 大小
		/// </summary>
		private int _value;
		/// <summary>
		/// The _level up add value. 升级时 属性提升的大小
		/// </summary>
		private int _levelUpAddValue;
		/// <summary>
		/// The _modifier. 等级提升后 属性提升比值  比如说1级到2级提升10个基础值 2级到3级就提升基础值为10*该值 在提升再乘以该值
		/// </summary>
		private float _modifier;
		public AttributeEquit ()
		{
				_value = 50;
				_levelUpAddValue = 100;
				_modifier = 0.9f;
		}
#region  Base Setters and Getters
		/*  /// <summary>
		/// Gets or sets the name of the attribute.属性的名字 力量 敏捷 智力等
		/// </summary>
		/// <value>The name of the attribute.</value>
		public string  AttributeName {
				get{ return _attributeName;}
				set {
						_attributeName = value;
				}
		}*/
		/// <summary>
		/// Gets or sets the value. 属性的基础值
		/// </summary>
		/// <value>The value.</value>
		public int Value {
				get{ return _value;}
				set {
						_value = value;
				}
		}
		/// <summary>
		/// Gets or sets the level up add value.升级时属性提升的大小
		/// </summary>
		/// <value>The level up add value.</value>
		public int LevelUpAddValue {
				get{ return _levelUpAddValue;}

				set {
						_levelUpAddValue = value;
				}
		}
		/// <summary>
		/// Gets or sets the modifier.等级倍增 等级提升后 属性提升比值  比如说1级到2级提升10个基础值 2级到3级就提升基础值为10*该值 在提升再乘以该值
		/// </summary>
		/// <value>The modifier.</value>
		public float Modifier {
				get{ return _modifier;}
				set {
						_modifier = value;
				}
		}

#endregion
		/// <summary>
		/// Levels up.等级提升后调用   对应属性会提升
		/// </summary>
		public void  LevelUp ()
		{
				_value = _value + _levelUpAddValue;
				_levelUpAddValue = (int)(_levelUpAddValue * _modifier);
		}


}
