
using UnityEngine;
using System.Collections;


public class EnemyAI_3 : BaseEnemyAI
{
		private enum  AnimatState//根据距离,生命值,和是否被攻击判断状态
		{
				Idle,            
				Movefree,
				MoveToplayer,
				Hit,
				GetHit,
				Death
		
		}
	
	
	
		public float myLife = 1000;
		public float hitSpeed = 1.0f;//动画播放速度 攻击速度
		public float hitMinDistance = 1.0f;//最小攻击距离
		public float hitMaxDistance = 2.0f;//最大攻击距离
	
		
		public  bool keyBool = true;
		private bool moveFreeBool = true;
		private bool hitBool;
		private bool StartCoroutineBool;
		
		public  bool inGetHitBool;	//判断是否在攻击范围内
		private AnimatState myState;
		
		private  Animator animator;
		public  float myTime1 = 0;
		
	
		// Use this for initialization
	
	

		void Start ()
		{
				myTime = 10.0f;
				
				animator = GameObject.FindGameObjectWithTag ("Player").GetComponent<Animator> ();
				StartCoroutineBool = true;
		}
	
		// Update is called once per frame
		void  Update ()
		{
				distance = Vector3.Distance (playerTransform.position, transform .position);
				if (distance < 5) {
						dotToEnemy = Vector3.Dot ((transform.position - playerTransform.position).normalized, playerTransform.forward);
				}
				if (backCannotFindPlayer) {
						dotToPlayer = Vector3.Dot ((playerTransform.position - transform .position).normalized, transform.forward);
			
				} else {
						dotToPlayer = 1;
			
				}
		
				myTime += Time.deltaTime;
		
		
		
		
				if (distance < hitMinDistance) {
						//if (dotToPlayer > 0)
						hitBool = true;
						if (dotToEnemy > 0.5f)
								inGetHitBool = true;
						
				}
				if (distance > hitMaxDistance) {
						hitBool = false;
						inGetHitBool = false;
				}
				if (distance < 5) {
						if (dotToPlayer > 0)//是否在前方
								moveFreeBool = false;
				}
				if (distance > 8)
						moveFreeBool = true;
		
				//if (!solider_animation.hitEnemy) {
				//keyBool = true;
				//}
		
				if (myLife < 0) {
						myState = AnimatState.Death;
				} else if (hitBool) {
						myTime1 += Time .deltaTime;
						if (myTime1 < myAnimation ["hit"].clip.length) {
								myState = AnimatState.Hit;
						} else {
								myState = AnimatState.Idle;
								
						}
				} else if (moveFreeBool) {
						myState = AnimatState.Movefree;
				} else {
						myState = AnimatState.MoveToplayer;
						
				}
		
		
		
				switch (myState) {
				case AnimatState.Idle:
						
						transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (new Vector3 (playerTransform.position.x, transform.position.y, playerTransform.position .z) - transform .position), 1.0f);
						nma.destination = transform.position;
						myAnimation.Play ("idle");
						if (myTime1 > 3.0f)
								myTime1 = 0;
						break;
				case AnimatState.Movefree:
						if (myTime > 10) {
								nma.destination = RayHitPoint ();
								myTime = 0;
				
						}
						myAnimation.Play ("walk");
						break;
				case AnimatState.MoveToplayer:
			
						myAnimation.PlayQueued ("walk", QueueMode.CompleteOthers);
						if (myAnimation.IsPlaying ("hit") || myAnimation.IsPlaying ("death") || myAnimation.IsPlaying ("idle")) {
								nma.destination = transform.position;
								
						} else {
								nma.destination = playerTransform.position;
						}
						
			
						break;
				case AnimatState.Hit:
			
						transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (new Vector3 (playerTransform.position.x, transform.position.y, playerTransform.position .z) - transform .position), 1.0f);
						nma.destination = transform.position;
						myAnimation.Play ("hit");
						myAnimation ["hit"].speed = hitSpeed;
						hitPlayer ();
						
						break;
		
				case AnimatState.Death:
						nma.destination = transform.position;
						myAnimation.Play ("death");
						animator.speed = 1.0f;
						if (StartCoroutineBool) {
								StartCoroutine (deathWait ());
								StartCoroutineBool = false;
						}
						
						break;
			
				}
		
		
		
		
		
		}



		/// <summary>
		///Enemy 攻击到玩家的时候调用这个函数 
		/// </summary>
		override 	public void  hitPlayer ()
		{
		}


		/// <summary>
		/// 玩家攻击时调用   是否被攻击
		/// </summary>
		override public void SetGetHit1 ()
		{
				
				if (inGetHitBool) {
						myLife -= 100;
						animator .speed = 0.3f;
						StartCoroutine (Wait ());
						
				}
				
		
		}
		override public void SetGetHit2 ()
		{
				if (inGetHitBool) {
						myLife -= 100;
						animator .speed = 0.3f;
						StartCoroutine (Wait ());
				}
				
		}
		override public void SetGetHit3 ()
		{
				if (inGetHitBool) {
						myLife -= 100;
						animator .speed = 0.3f;
						StartCoroutine (Wait ());
				}
		}
		override public void SetGetHit4 ()
		{
				if (distance < 2.5f & dotToEnemy > 0.3f) {
						myLife -= 100;
						animator .speed = 0.5f;
						StartCoroutine (Wait ());
				}
				
		}
		IEnumerator Wait ()
		{
				yield return new WaitForSeconds (0.3f);
				animator .speed = 1.0f;
		}
		IEnumerator deathWait ()
		{
				yield return new WaitForSeconds (myAnimation ["death"].clip.length * 0.9f);
				myAnimation ["death"].speed = 0;
				yield return new WaitForSeconds (2.0f);
				StartCoroutineBool = true;
				gameObject.SetActive (false); 
				myAnimation ["death"].speed = 1.0f;
				
		}
	
}