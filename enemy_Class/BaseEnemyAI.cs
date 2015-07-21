using UnityEngine;
using System.Collections;

public class BaseEnemyAI : MonoBehaviour
{
		private int  rayX;
		private int rayY;
		private int  rayZ;
		private Ray ray;
		private RaycastHit hit;
		public Transform playerTransform;
		public float distance;
		public float  myTime ;
		public float dotToPlayer;
		public float dotToEnemy;
		public bool backCannotFindPlayer;//是否能发现背后的敌人

		public NavMeshAgent nma;
		public Animation myAnimation;
		

		void Awake ()
		{	
				nma = GetComponent<NavMeshAgent> ();
				myAnimation = GetComponent<Animation> ();
				
				playerTransform = GameObject .FindGameObjectWithTag ("Player").transform;
				
		}
		
		void Start ()
		{
			
				
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				
				
				
		
		}
		/// <summary>
		/// enemy被攻击时掉用此函数
		/// </summary>
		virtual 	public void SetGetHit1 ()
		{
					
		}
		// Use this for initialization
		virtual 	public void SetGetHit2 ()
		{

		}
		virtual 	public void SetGetHit3 ()
		{

		}
		virtual 	public void SetGetHit4 ()
		{

		}
		/// <summary>
		/// 随机x,z,而y=200 由Vector3(x,y,z)为起点方向为向下 生成一条250米的射线,与地面碰撞返回碰撞的点的坐标 类型为Vector3.
		/// </summary>
		/// <returns>The hit point.</returns>
		public  Vector3 RayHitPoint ()
		{
				rayX = Random.Range (10, 40);
				rayY = 200;
				rayZ = Random.Range (0, 150);
				ray = new Ray (new Vector3 (rayX, rayY, rayZ), Vector3.down);
		
				Physics.Raycast (ray, out hit, 250);
				return hit.point;
		 
		}
		/// <summary>
		///Enemy 攻击到玩家的时候调用这个函数 
		/// </summary>
		virtual  public void  hitPlayer ()
		{
		}
}
