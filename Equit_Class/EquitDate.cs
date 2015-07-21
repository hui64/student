using UnityEngine;
using System.Collections;
using System .Collections.Generic;
using System ;
public class EquitDate
{
		private string isWho;
		private string name;
		private string chandi;
		private string uiTureName;//UI图集上图片的名字
		private int level;
		private AttributeEquit[] attribute;
		

		public EquitDate (string myName, string myChandi, string myUiTureName, int myLevel)
		{
				isWho = "系统";
				name = myName;
				chandi = myChandi;
				uiTureName = myUiTureName;
				level = myLevel;
				attribute = new AttributeEquit[Enum .GetValues (typeof(EquitAttribute)).Length];
				for (int cnt=0; cnt<attribute.Length; cnt ++)
						attribute [cnt] = new AttributeEquit ();
		}
#region  Base Setters and Getters
		/// <summary>
		/// Sets the is who.设置装备的拥有者默认是系统
		/// </summary>
		/// <returns>The is who.</returns>
		/// <param name="who">Who.</param>
		public void SetIsWho (string who)
		{
				isWho = who;
		}
		/// <summary>
		/// Gets the get is who.得到装备的拥有者的名字
		/// </summary>
		/// <value>The get is who.</value>
		public string GetIsWho {
				get{ return isWho;}
				set {
						isWho = value;
				}
		}

		/// <summary>
		/// Gets the name.装备的名字
		/// </summary>
		/// <value>The name.</value>
		public string GetName {
				get{ return name;}
				
				set {
						name = value;
				}
		}
		/// <summary>
		/// Gets the changdi.
		/// </summary>
		/// <value>The changdi.</value>
		public string Chandi {
				get { return chandi;}
				
				set {
						chandi = value;
				}
		}
		

		/// <summary>
		/// Gets the  UiTureName
		/// </summary>
		public string GetUiTureName {
				get { return uiTureName;}
		
				set {
						uiTureName = value;
				}
		}
		/// <summary>
		/// Gets the level.
		/// </summary>
		/// <value>The level.</value>
		public int GetLevel {
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
				return attribute [myEnumNumber];
		}	
		
#endregion

}
