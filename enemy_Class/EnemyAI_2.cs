using UnityEngine;
using System.Collections;

public class EnemyAI_2 : BaseEnemyAI
{
		private enum  AnimatState
		{
				Idle,            
				Walk,
				Run
				
		
		}
		
		
		
		private AnimatState myState;
		public  bool  runBool;
		public  float myTime2;
		private bool  keyBool = true;
		private Vector3 hitPoint;
		//private double  dot_01;
		
		// Use this for initialization
		void Start ()
		{		
				myTime = 0;	
				myTime2 = 10.0f;
			
	
		}
	
		// Update is called once per frame
		void Update ()
		{
			
				if (transform.position.x < 10.0f || transform.position.x > 140.0f || transform.position.z < 10.0f || transform.position.z > 10.0f)
						nma.destination = new Vector3 (10, 10, 10);
				distance = Vector3.Distance (playerTransform.position, transform .position);
				if (distance < 5) {
						//dot_01 = Vector3.Dot ((playerTransform.position - transform .position).normalized, transform.position.normalized);
						if (backCannotFindPlayer) {
								dotToPlayer = Vector3.Dot ((playerTransform.position - transform .position).normalized, transform.forward);
			
						} else {
								dotToPlayer = 1;
						}
			
				}
	
				
				myTime2 += Time.deltaTime;
				myTime += Time .deltaTime;
				if (myTime > 30.0f)
						myTime = 0;


				if (distance < 4.0f & dotToPlayer > 0)
						runBool = true;
				if (distance > 10.0f) {
						runBool = false;
						keyBool = true;
				}

				if (runBool)
						myState = AnimatState.Run;
				else if (myTime < 10.0f)
						myState = AnimatState.Idle;
				else if (myTime < 30.0f)
						myState = AnimatState.Walk;
				switch (myState) {
				case AnimatState.Idle:
						nma.destination = transform .position;
						myAnimation.Play ("idle");
						break;
				case AnimatState.Walk:
						if (myTime2 > 10.0f) {
								nma.destination = RayHitPoint ();
								myTime2 = 0;
						}
						myAnimation.Play ("walk");
						nma.speed = 1.0f;
						break;
				case AnimatState.Run:
						if (keyBool) {
								hitPoint = RayHitPoint ();
								if (Vector3.Distance (hitPoint, playerTransform .position) > 20.0f) {

										float dotKey = Vector3.Dot (playerTransform .position - hitPoint, playerTransform.forward);
										if (dotKey < 0) {
												nma.destination = hitPoint;
												
												keyBool = false;
										}
								}
						}
						myAnimation.Play ("run");
						nma.speed = 2.0f;
						break;
				}


				
		}
}
