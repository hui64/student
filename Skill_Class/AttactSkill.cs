using UnityEngine;
using System.Collections;
using System.Collections.Generic;
/// <summary>
/// Attact skill.攻击技能类  继承 ASkill
/// </summary>
public class AttactSkill : ASkill
{
		public int  skillNumber;
		public string skillAnimatorName;
		public int usedkillMana;
		public int attact;
		public int changedAttact;
		public BasePlayer basePlayer;

		override public  void  PlaySkillAnimator (Animator myAnimator)
		{
				myAnimator.SetBool (skillAnimatorName, true);
				
		}
		override public  void LevelUp ()
		{
		}
		override public  void Used ()
		{
		}
		public void OnPress ()
		{
				basePlayer = BasePlayer.GetBasePlayer ();

			
		}
}
