using System.Collections.Generic ;

public class Change : Attribute
{

		private  List <ChangedAttribute > _mods;
		private int _modValue;

		public Change ()
		{
				_mods = new List<ChangedAttribute> ();
				_modValue = 0;
		}

		public void AddMods (ChangedAttribute mod)
		{
				_mods.Add (mod);
				ModValue ();
		}

		private void ModValue ()
		{
				_modValue = 0;
				if (_mods.Count > 0) {
						foreach (ChangedAttribute att in _mods) {
								_modValue += (int)(att.attribute.AdjustedBaseValue () * att.ratio);
						}
				}

		}
		public new int AdjustedBaseValue ()
		{
				return BaseValue + BuffValue + _modValue;
		}


}
public struct ChangedAttribute
{
		public Attribute attribute;
		public float ratio;

}
