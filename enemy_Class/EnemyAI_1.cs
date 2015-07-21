using UnityEngine;
using System.Collections;
//只有游戏物体上有animation组件和NavMeshAgent 并且animation上的动画剪辑上需要的动画片段改为idle, walk, hit ,getHit, death 

public class EnemyAI_1 : BaseEnemyAI
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
		
		private float deathMoveTime;
		public bool deathMoveBool;
		public  bool keyBool = true;
		private bool moveFreeBool = true;
		private bool hitBool;
		public  bool getHitBool ;
		private bool deathBool;
		private bool inGetHitBool;	//判断是否在攻击范围内
		private AnimatState myState;
		private float myTimeGetHitStart;
		private float myTimeGetHitEnd;
		private  Animator animator;
		
		// Use this for initialization
	
		//System.DateTime date1 = new System.DateTime(1996, 6, 3, 22, 15, 0);
		//System.DateTime date2 = new System.DateTime(1996, 12, 6, 13, 2, 0);
		//System.DateTime date3 = new System.DateTime(1996, 10, 12, 8, 42, 0);
	
		// diff1 gets 185 days, 14 hours, and 47 minutes.
		//System.TimeSpan diff1 = date2.Subtract(date1);


		void Start ()
		{
				//System.DateTime date1 = new System.DateTime (2015, 2, 8);
				//System.DateTime date2 = new System.DateTime (System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day);
				//System.TimeSpan diff1 = date2.Subtract (date1);//返回  date2-date1

				//print (diff1.Days);
				myTime = 10.0f;
				myTimeGetHitEnd = 0.8f;
				animator = GameObject.FindGameObjectWithTag ("Player").GetComponent<Animator> ();
				
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
						else {
								inGetHitBool = false;
						}
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

				if (myLife < 0 || deathBool) {
						myState = AnimatState.Death;
				} else if (getHitBool) {
						myState = AnimatState.GetHit;
				} else if (hitBool) {
						myState = AnimatState.Hit;
				} else if (moveFreeBool) {
						myState = AnimatState.Movefree;
				} else {
						myState = AnimatState.MoveToplayer;
				}

				

				switch (myState) {
				case AnimatState.Idle:
						nma.destination = transform.position;
						myAnimation.Play ("idle");
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
						if (myAnimation.IsPlaying ("hit") || myAnimation.IsPlaying ("death")) {
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
				case AnimatState.GetHit:
					

						//transform.Translate (0.05f * transform.forward .x, 0.05f * transform.forward .y, -transform.forward .z * 0.05f);
						myTimeGetHitStart += Time .deltaTime;
						myTimeGetHitEnd -= Time .deltaTime;
						nma.destination = transform.position;
						myAnimation.Play ("getHit");
						if (myTimeGetHitStart > animation ["getHit"].clip.length / 2) {
								myAnimation ["getHit"].speed = 0;
						}
						if (myTimeGetHitEnd < 0) {
								getHitBool = false;
								myAnimation ["getHit"].speed = 0.5f;
						}
						//StartCoroutine (Wait ()); 
						break;
				case AnimatState.Death:
						nma.destination = transform.position;
						myAnimation.Play ("death");
						deathMoveTime += Time.deltaTime;
						if (deathMoveTime < 0.4f) {
								transform.Translate (0, 0.8f, -0.05f);
						} else if (deathMoveTime < 0.8f) {
								transform.Translate (0, -0.01f, 0);
						} else if (deathMoveTime > 1.0f) {
								deathBool = false;
								deathMoveTime = 0;
								getHitBool = false;
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

		
		override public void SetGetHit1 ()
		{
				if (inGetHitBool) {
						getHitBool = true;
						animator .speed = 0.2f;
						StartCoroutine (Wait ());
				}
				myTimeGetHitEnd = 0.8f;
				myTimeGetHitStart = 0;
				
		}
		override public void SetGetHit2 ()
		{
				if (inGetHitBool) {
						getHitBool = true;
						animator .speed = 0.2f;
						StartCoroutine (Wait ());
				}
				myTimeGetHitEnd = 0.8f;
				myTimeGetHitStart = 0;
		
		}
		override public void SetGetHit3 ()
		{
				if (inGetHitBool) {
						
						deathBool = true;
				} 
				
		}
		override public void SetGetHit4 ()
		{
				if (distance < 2.5f & dotToEnemy > 0.5f) {
						getHitBool = true;
						animator .speed = 0.2f;
						StartCoroutine (Wait ());
				}
				myTimeGetHitEnd = 0.8f;
				myTimeGetHitStart = 0;
		
		}
		IEnumerator Wait ()
		{
				yield return new WaitForSeconds (0.3f);
				animator .speed = 1.0f;
		}
		
}
