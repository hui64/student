using UnityEngine;
using System.Collections;
public enum Grade
{
		EASY,
		NORMAL,
		HARD
}
public class GameSetting
{
		private float volume;//音量大小
		private Grade grade;//游戏难度
		private bool isFullScreen;//是否全屏

		private GameSetting ()
		{
				volume = 0.5f;
				grade = Grade.NORMAL;
				isFullScreen = true;
		}
		static GameSetting P;
		public static GameSetting getInstance {
				get {
						if (P == null)
								P = new GameSetting ();
						return P;
				}
		}


		public float Volume {
				get{ return volume;}
				set{ volume = value;}
		}
		public Grade  Grade {
				get{ return grade;}
				set{ grade = value;}
		}
		public bool  IsFullScreen {
				get{ return  isFullScreen;}
				set{ isFullScreen = value;}
		}


}
