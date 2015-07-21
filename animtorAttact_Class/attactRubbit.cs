using UnityEngine;
using System.Collections;

public class attactRubbit : BaseAttact
{
		private Ray ray;
		private RaycastHit hit;
		private	GameObject enemy;
		/// <summary>
		/// 动画attact_02播放时 的回调函数
		/// </summary>
		override	public  void SetAttact1 ()
		{
				enemy = null;
				enemy = getHitGameObject ();
				
				if (enemy != null & enemy.tag.Equals ("Enemy")) {
						enemy.GetComponent<BaseEnemyAI> ().SetGetHit1 ();
						
				}
				
		}
	

		override	public  void SetAttact2 ()
		{
				enemy = null;
				enemy = getHitGameObject ();
				if (enemy != null & enemy.tag.Equals ("Enemy"))
						enemy.GetComponent<BaseEnemyAI> ().SetGetHit2 ();
		}

	
		override	public  void SetAttact3 ()
		{
				enemy = null;
				enemy = getHitGameObject ();
				if (enemy != null & enemy.tag.Equals ("Enemy"))
						enemy.GetComponent<BaseEnemyAI> ().SetGetHit3 ();
		}
	
	
		override	public  void SetAttact4 ()
		{
				enemy = null;
				enemy = getHitGameObject ();
				if (enemy != null & enemy.tag.Equals ("Enemy"))
						enemy.GetComponent<BaseEnemyAI> ().SetGetHit4 ();
		}


		/// <summary>
		/// 以玩家的前方发射一条2米的射线 返回碰撞到的物体
		/// </summary>
		/// <returns>The hit game object.</returns>
		public GameObject getHitGameObject ()
		{
				ray = new Ray (new Vector3 (transform.position.x, transform.position.y + 0.5f, transform.position.z), transform.forward);
				if (Physics.Raycast (ray, out hit, 100.0f)) {
						
						Debug.DrawRay (new Vector3 (transform.position.x, transform.position.y + 0.5f, transform.position.z), transform.forward, Color.red, 10.0f);
						return hit.collider.gameObject;
						
				} else {
						return gameObject;
				}
		}


}
