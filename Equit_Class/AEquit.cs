using UnityEngine;
using System.Collections;
/// <summary>
/// A equit.装备的抽象类
/// </summary>
public interface  AEquit
{       
		/// <summary>
		/// Equits the level up.z装备升级时  属性也跟着提升
		/// </summary>
		void  equitLevelUp ();
		/// <summary>
		/// Useds the equit skill.使用装备上附带的技能
		/// </summary>
		void usedEquitSkill ();
	
		

	
	
}