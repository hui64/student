using UnityEngine;
using System.Collections;
using System .Collections.Generic ;
/// <summary>
/// A skill.玩家技能的抽象类
/// </summary>
public abstract class ASkill
{
		public abstract void PlaySkillAnimator (Animator myAnimation);
		public abstract void Used ();
		public abstract void LevelUp ();
		//11
}
