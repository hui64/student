using UnityEngine;
using System.Collections;
/// <summary>
/// A player move. 玩家移动的抽象类
/// </summary>
public abstract class APlayerMove
{
		//public Transform myTransform;
		//public Animator  myAnimator;

		/// <summary>
		/// Moves up.玩家的移动方式 包括位移跟动画
		/// </summary>
		public abstract void MoveUp (Transform  myTransform, Animator myAniamtor);
		public abstract void MoveDown (Transform  myTransform, Animator myAniamtor);
		public abstract void MoveRight (Transform  myTransform, Animator myAniamtor);
		public abstract void MoveLeft (Transform  myTransform, Animator myAniamtor);
		public abstract void Jump (Transform  myTransform, Animator myAniamtor);
		
}
