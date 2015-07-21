public class Attribute:BaseDate
{

		public Attribute ()
		{
				LeveltoExp = 50;
				ExpModifier = 1.5f;

		}
}
/// <summary>
/// Attribute name.人物属性的枚举
/// </summary>
public enum AttributeName
{// 可以继续添加属性
		Mighton,        //力量
		Constituion,    //体质
		Nimbleness,     //敏捷
		Speed,          //速度
		Concertration,  //集中
		Willpower,      //意志力
		Charisma        //魅力
	

}
