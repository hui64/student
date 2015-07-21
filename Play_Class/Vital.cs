public class Vital :Change {
	private int _culValue;//血量 蓝量 体力等等的当前值
	public Vital(){
		_culValue = 0;
		LeveltoExp = 50;
		ExpModifier =1.5f;
		}
	public int 	CulValue{
		get{if(_culValue >AdjustedBaseValue() )
			_culValue =AdjustedBaseValue() ;
			return _culValue;
		}
		set{_culValue =value;}
	}
}
public enum VitalName{
	Health,
	Energy,
	Mana  //法力

}