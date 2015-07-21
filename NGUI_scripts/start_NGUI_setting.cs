using UnityEngine;
using System.Collections;



public class start_NGUI_setting : MonoBehaviour
{
		public TweenPosition setTween;
		public TweenPosition setOverTween;
		public AudioSource audioSource;
		




		public void SetButtonClick ()
		{
				setTween.PlayForward ();
				setOverTween.PlayForward (); 
		}

		public void SetOverButtonClick ()
		{
				setTween.PlayReverse ();
				setOverTween.PlayReverse (); 
		}


		public void StartGame ()
		{
				Application.LoadLevel ("stander");
		}

		public void QuitGame ()
		{
				Application.Quit ();

		}


		public void VolumeChanged ()
		{
				GameSetting.getInstance.Volume = UIProgressBar.current.value;
				audioSource.volume = GameSetting.getInstance.Volume;
				

		}


		public void GradeChanged ()
		{
				switch (UIPopupList.current.value.Trim ()) {
				case"简     单":
						GameSetting.getInstance.Grade = Grade.EASY;
						break;
				case"普     通":
						GameSetting.getInstance.Grade = Grade.NORMAL;
						break;	
				case"困     难":
						GameSetting.getInstance.Grade = Grade.HARD;
						break;




				}
	     
		
		}


		public void ScreenChanged ()
		{
				GameSetting.getInstance.IsFullScreen = UIToggle.current.value;
		}
}

			
			

		
	
		

		



	


