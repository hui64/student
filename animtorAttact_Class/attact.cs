using UnityEngine;
using System.Collections;
using System .Collections.Generic;
public class attact : BaseAttact
{
		public GameObject[] go;
		public  float attact1Distance;
		public  float attact2Distance;
		public  float attact3Distance;
		public  float attact4Distance;
		/// <summary>
		/// 动画attact_01播放时 的回调函数
		/// </summary>
		public override void SetAttact1 ()
		{
				FindEnemy ();
				foreach (GameObject  enemy in go) {
						if (Vector3.Distance (enemy.transform.position, transform.position) < attact1Distance)
								enemy.GetComponent <BaseEnemyAI> ().SetGetHit1 ();
				}
				
		}
		/// <summary>
		/// 动画attact_02播放时 的回调函数
		/// </summary>
		public	override	 void SetAttact2 ()
		{
				FindEnemy ();
				foreach (GameObject  enemy in go) {
						if (Vector3.Distance (enemy.transform.position, transform .position) < attact2Distance)
								enemy.GetComponent <BaseEnemyAI> ().SetGetHit1 ();
				}
		}
	
		public override void SetAttact3 ()
		{
				FindEnemy ();
				foreach (GameObject  enemy in go) {
						if (Vector3.Distance (enemy.transform.position, transform .position) < attact3Distance)
								enemy.GetComponent <BaseEnemyAI> ().SetGetHit1 ();
				}
		
		
		
		}
		public	override	 void SetAttact4 ()
		{
				FindEnemy ();
				foreach (GameObject  enemy in go) {
						if (Vector3.Distance (enemy.transform.position, transform .position) < attact4Distance)
								enemy.GetComponent <BaseEnemyAI> ().SetGetHit1 ();
				}
		
		}
	
		/// <summary>
		/// 遍历场景面板中带Enemy标签的物体 并加人到myList中
		/// </summary>
	
		public void FindEnemy ()
		{
				
				go = null; 
		
				go = GameObject .FindGameObjectsWithTag ("Enemy");
				
				
		}
	
		


		
}
