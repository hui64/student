

public class BaseDate
{
		private int _baseValue;              //  人物 血量 法力 体力  或者不同技能的基础属性
		private int _baseValuetoLevelUp;     //	 升一级多提升多少的基础属性
		private int _buffValue;              //	可以修改基础属性的值 
		private int _leveltoExp;             //	提升一级基础属性 需要的经验
		private float _expModifier ;         //	提升等级需要的经验倍增量

		public BaseDate ()
		{
				_baseValue = 0;
				_baseValuetoLevelUp = 10;
				_buffValue = 0;
				_leveltoExp = 100;
				_expModifier = 1.2f;
		}
#region  Base Setters and Getters
		/// <summary>
		/// Gets or sets the base value.
		/// </summary>
		/// <value>The base value.</value>
		public int BaseValue {
				get{ return _baseValue;}
				set{ _baseValue = value;}
		}
		/// <summary>
		/// Gets or sets the base valueto level up.
		/// </summary>
		/// <value>The base valueto level up.</value>
		public int BaseValuetoLevelUp {
				get{ return _baseValuetoLevelUp;}
				set{ _baseValuetoLevelUp = value;}
		}
		/// <summary>
		/// Gets or sets the buff value.
		/// </summary>
		/// <value>The buff value.</value>
		public int BuffValue {
				get{ return _buffValue;}
				set{ _buffValue = value;}
		}
		/// <summary>
		/// Gets or sets the levelto exp.
		/// </summary>
		/// <value>The levelto exp.</value>
		public int LeveltoExp {
				get{ return _leveltoExp;}
				set{ _leveltoExp = value;}
		}
		/// <summary>
		/// Gets or sets the exp modifier.
		/// </summary>
		/// <value>The exp modifier.</value>
		public float ExpModifier {
				get{ return _expModifier;}
				set{ _expModifier = value;}
		}
#endregion

		private int CalculateLeveltoExp ()
		{
				return (int)(_leveltoExp * _expModifier);
		}
		/// <summary>
		/// Levels up. 升级后从新设置升级所需的经验  并且基础属性增加
		/// </summary>
		public void LevelUp ()
		{
				_leveltoExp = CalculateLeveltoExp ();
				_baseValue += _baseValuetoLevelUp;
		}
		/// <summary>
		/// Adjusteds the base value. 返回被_baseValue+_buffValue
		/// </summary>
		/// <returns>The base value.</returns>
		public int AdjustedBaseValue ()
		{
				return _baseValue + _buffValue;
		}


	
}