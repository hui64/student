using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic ;
public class PlayerDate
{
		
		private  string  _name;	
		private  uint    _level;	
		private  uint    _freeExp;

		//
		/// <summary>
		/// The _attribute.玩家属性
		/// </summary>
		private Attribute[] _attribute;
		/// <summary>
		/// The _vital.玩家血量 蓝量 体力等属性
		/// </summary>
		private Vital[] _vital;
		//private Skill_initial[] _skill_initial;
		private static PlayerDate player = null;
		private PlayerDate ()
		{
				_name = string.Empty; 
				_level = 0;
				_freeExp = 0;

				_attribute = new Attribute[Enum.GetValues (typeof(AttributeName)).Length ];
				_vital = new Vital[Enum.GetValues (typeof(VitalName)).Length ];
				//_skill_initial = new Skill_initial[Enum.GetValues (typeof(SkillName)).Length ];



				SetupAttributes ();
				//SetupSkill ();
				SetupVital ();
				SetVitalAttributeChange ();
				//SetSkillAttributeChange ();
		}
		/// <summary>
		/// Gets the player.返回一个单例
		/// </summary>
		/// <returns>The player.</returns>
		public static PlayerDate GetPlayer ()
		{
				if (player == null)
						player = new PlayerDate ();
				return player;
		}
		
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name {
				get{ return _name;}
				set{ _name = value;}
		}
		/// <summary>
		/// Gets or sets the level.
		/// </summary>
		/// <value>The level.</value>
		public uint Level {
				get{ return _level;}
				set{ _level = value;}
		}
		/// <summary>
		/// Gets or sets the free exp.
		/// </summary>
		/// <value>The free exp.</value>
		public uint  FreeExp {
				get{ return  _freeExp;}
				set{ _freeExp = value;}
		}
		//
		/// <summary>
		/// Adds the exp.经验增加 并且刷新 是否升级以及升级后的变化
		/// </summary>
		/// <param name="exp">Exp.</param>
		public void AddExp (uint exp)
		{
				_freeExp += exp;
				CalculateLevel ();
		}
		private void CalculateLevel ()
		{//计算等级的方法 暂定

		}
		/// <summary>
		/// Setups the attributes.初始化属性数组
		/// </summary>
		private void SetupAttributes ()
		{
				for (int cnt=0; cnt<_attribute.Length; cnt ++)
						_attribute [cnt] = new Attribute ();
		}
		/// <summary>
		/// Setups the vital.初始化生命属性
		/// </summary>
		private void SetupVital ()
		{
				for (int cnt=0; cnt<_vital.Length; cnt ++)
						_vital [cnt] = new Vital ();
		}

		//private void SetupSkill ()
		//{
		//	for (int cnt=0; cnt<_skill_initial.Length; cnt ++)
		///	_skill_initial [cnt] = new Skill_initial ();
		//}
		//
		/// <summary>
		/// Gets the attribute.根据属性枚举的值 取到对应数组里 该属性的值
		/// </summary>
		/// <returns>The attribute.</returns>
		/// <param name="index">Index.</param>
		public Attribute GetAttribute (int index)
		{
				return _attribute [index];
		}
		/// <summary>
		/// Gets the vital.根据属性枚举的值 取到对应数组里 该属性的值
		/// </summary>
		/// <returns>The vital.</returns>
		/// <param name="index">Index.</param>
		public Vital GetVital (int index)
		{
				return _vital [index];
		}
		
		//public Skill_initial GetSkill (int index)
		//{
		//	return _skill_initial [index];
		//}
		
		private void SetVitalAttributeChange ()
		{//设定修改的系数
				//health:
				//ChangedAttribute health = new ChangedAttribute ();
				//health.attribute = GetAttribute ((int)(AttributeName.Constituion));
				//health.ratio = 0.5f;
				GetVital ((int)(VitalName .Health)).AddMods (new ChangedAttribute{attribute =GetAttribute ((int)(AttributeName.Constituion)),ratio = 0.5f});
				//energy
				GetVital ((int)(VitalName .Energy)).AddMods (new ChangedAttribute{attribute =GetAttribute ((int)(AttributeName.Constituion)),ratio = 1.0f});
				//mana
				GetVital ((int)(VitalName .Mana)).AddMods (new ChangedAttribute{attribute =GetAttribute ((int)(AttributeName.Willpower )),ratio = 1.0f});
		}
		//private void SetSkillAttributeChange ()
		//{//因为_modValue是根据_mod数组赋值的 所以可以多个属性控制_modValue的值
		//foreach(ChangedAttribute att in _mods ) {
		//    _modValue+=(int)(att.attribute.AdjustedBaseValue()*att.ratio);}
		//Attact_01
		//	GetSkill ((int)(SkillName .Attact_01)).AddMods (new ChangedAttribute{attribute =GetAttribute ((int)(AttributeName.Mighton  )),ratio =2.0f});
		//Attact_01
		//GetSkill ((int)(SkillName .Attact_01)).AddMods (new ChangedAttribute{attribute =GetAttribute ((int)(AttributeName.Constituion   )),ratio =5.0f});

		//Attact_02
		//GetSkill ((int)(SkillName .Attact_02)).AddMods (new ChangedAttribute{attribute =GetAttribute ((int)(AttributeName.Mighton  )),ratio =2.0f});
		//Attact_03
		//GetSkill ((int)(SkillName .Attact_03)).AddMods (new ChangedAttribute{attribute =GetAttribute ((int)(AttributeName.Mighton  )),ratio =2.0f});
		//Attact_04
		//GetSkill ((int)(SkillName .Attact_04)).AddMods (new ChangedAttribute{attribute =GetAttribute ((int)(AttributeName.Mighton  )),ratio =2.0f});

		//}

}
