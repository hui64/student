public class Skill_initial :Change
{
		private bool _know;
		public Skill_initial ()
		{
				LeveltoExp = 25;
				ExpModifier = 1.2f;
		}
		public bool Know {
				get{ return _know;}
				set{ _know = value;}
		}

}
public enum SkillName
{

		Attact_01,	//近程攻击
		Attact_02,	//远程攻击
		Attact_03,	//法术攻击
		Attact_04,	
}
