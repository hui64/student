using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Base player.玩家的 基类   游戏核心逻辑类
/// </summary>
public  class BasePlayer : MonoBehaviour
{
		private static BasePlayer basePlayer = new BasePlayer ();// 暂时 初始化就new一个单例出来 要延迟new 记得要启动线程保护 或者使用lock修饰
		private BasePlayer ()
		{

		}
		/// <summary>
		/// Gets the player.返回一个单例
		/// </summary>
		/// <returns>The player.</returns>
		public static BasePlayer GetBasePlayer ()
		{
				return basePlayer;
		}

		/// <summary>
		/// 玩家的基础数据
		/// </summary>
		public PlayerDate playerDate;

		/// <summary>
		/// The skill_ r.玩家拥有的技能   通过for循环在技能UI上显示拥有的技能
		/// </summary>
		public List<ASkill> mySkills;

		/// <summary>
		/// The on player skill. 能使用快捷方式技能  通过for循环生成快捷技能
		/// </summary>
		public List<ASkill> onPlayerSkills;

		/// <summary>
		/// The equit_01.
		/// 
		/// 玩家的拥有的装备   通过for循环在背包上生成装
		/// </summary>
		public List<AEquit> myEquits;

		/// <summary>
		/// The on player equit.   装备在玩家身上的装备  通过for循环生成装备
		/// </summary>
		public List<AEquit> onPlayerEquits;
		
		/// <summary>
		/// My transform.该玩家的 Transform
		/// </summary>
		public Transform myTransform;

		/// <summary>
		/// My animator.该玩家的动画 
		/// </summary>
		public Animator  myAnimator;

		/// <summary>
		/// My player move. 移动类
		/// </summary>
		public APlayerMove myPlayerMove;

		/// <summary>
		/// Moves up.玩家向前移动
		/// </summary>
		public  void MoveUp ()
		{
				myPlayerMove .MoveUp (myTransform, myAnimator);
		}

		/// <summary>
		/// Moves the right.向右移动  可以是向右旋转
		/// </summary>
		public  void MoveRight ()
		{
				myPlayerMove.MoveRight (myTransform, myAnimator);
		}

		/// <summary>
		/// Moves the left.向左移动  可以是向左旋转
		/// </summary>
		public  void MoveLeft ()
		{
				myPlayerMove .MoveLeft (myTransform, myAnimator);
		}

		/// <summary>
		/// Players the jump.玩家跳跃
		/// </summary>
		public void PlayerJump ()
		{
				myPlayerMove .Jump (myTransform, myAnimator);
		}





		/// <summary>
		/// Adds the exp.经验增加  等级计算在playerState.AddExp (exp)方法里面 当增加经验的时候会自动调用 等级计算
		/// </summary>
		/// <param name="exp">Exp.</param>
		public  void AddExp (uint exp)
		{
				playerDate.AddExp (exp);
		}


		/// <summary>
		/// Skills the level up. 技能升级
		/// </summary>
		/// <param name="skill">Skill.</param>
		public void SkillLevelUp (ASkill skill)
		{
		}

		/// <summary>
		/// Students the skill. 学习技能
		/// </summary>
		public  void StudentSkill (ASkill skill)
		{
				mySkills.Add (skill);
		}

		/// <summary>
		/// Sets the skill_01.把技能关联到界面上可直接使用
		/// </summary>
		/// <param name="skill">Skill.</param>
		public void AddOnPlayerSkill (ASkill skill)
		{
				onPlayerSkills.Add (skill);
		}
		
		/// <summary>
		/// Useds the skill.使用技能
		/// </summary>
		public void UsedSkill (ASkill skill)
		{
				skill.PlaySkillAnimator (myAnimator);
		}

		/// <summary>
		/// My user interface speak.聊天对话框的引用
		/// </summary>
		public GameObject myUISpeak;

		/// <summary>
		/// Speak this instance.  打开聊天UI
		/// </summary>
		public  void OpenUISpeak ()
		{
		}

		/// <summary>
		/// Closes the speak.关闭对话UI
		/// </summary>
		public void CloseUISpeak ()
		{
		}

		/// <summary>
		/// Fits the equit.佩戴装备
		/// </summary>
		public  void FitEquit (AEquit equit)
		{
				onPlayerEquits.Add (equit);
		}

		/// <summary>
		/// Picks up equit.得到装备
		/// </summary>
		/// <param name="equit">Equit.</param>
		public void PickUpEquit (AEquit equit)
		{
				myEquits.Add (equit);
		}
		/// <summary>
		/// The animator used skill. 正在使用的动画时  该动画对应的技能 
		/// </summary>
		public ASkill animatorUsedSkill;

		/// <summary>
		/// Sets the animator used skill.提前.设置玩家正在使用的技能 以备 动画回调时调用
		/// </summary>
		/// <param name="skill">Skill.</param>
		public void SetAnimatorUsedSkill (ASkill skill)
		{
				animatorUsedSkill = skill;
		}
		
		/// <summary>
		/// Animators the event.用于动画回调 所有技能都调用这个函数  设计思路是 动画回调只处理何时调用 技能数据方面在播放动画的时就设置好了  
		/// </summary>
		public void AnimatorEvent ()
		{
				animatorUsedSkill.Used ();
		}
		

		void Start ()
		{
	
		}
	

		void Update ()
		{
	
		}
}
















