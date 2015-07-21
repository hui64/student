using UnityEngine;
using System.Collections;
using System.Collections.Generic;
/// <summary>
/// Game date.  系统数据  包括装备 技能 等等  也可以用数据库代替
/// </summary>
public class GameDate
{		/// <summary>
		/// The game skills.系统拥有的技能
		/// </summary>
		public List<ASkill> gameSkills;
		/// <summary>
		/// The game equits.系统拥有的装备
		/// </summary>
		public List<AEquit> gameEquits;
		private static GameDate  gameDate = new GameDate ();
		private GameDate ()
		{
		
		}
		/// <summary>
		/// Gets the game date.返回单例
		/// </summary>
		/// <returns>The game date.</returns>
		public static GameDate getGameDate ()
		{
				return gameDate;
		}
		/// <summary>
		/// Adds to game skill.给系统添加技能
		/// </summary>
		/// <param name="skill">Skill.</param>
		public void AddToGameSkill (ASkill skill)
		{
				gameSkills.Add (skill);
		}
		/// <summary>
		/// Adds to game equit.给系统添加装备
		/// </summary>
		/// <param name="equit">Equit.</param>
		public void AddToGameEquit (AEquit equit)
		{
				gameEquits.Add (equit);
		}



}
