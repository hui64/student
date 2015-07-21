using UnityEngine;
using System.Collections;
using System.Collections.Generic ;

public class MainAdmin : MonoBehaviour
{
		public GameObject terrain_prefab;
		public GameObject player_prefab;
		public GameObject[] enemy_prefab;
		public GameObject uiRoot_prefab;
		public  List<GameObject> myEnemy;

		void Awake ()
		{
		}

		void Start ()
		{		//初始化关卡1
				Instantiate (terrain_prefab, Vector3.zero, transform.rotation);
				GameObject myplayer = Instantiate (player_prefab, new Vector3 (38.0f, 0.5f, 115.0f), transform.rotation)as GameObject;
				GameObject myUI = Instantiate (uiRoot_prefab, new Vector3 (1000.0f, 1000.0f, 1000.0f), transform.rotation)as GameObject;
				foreach (GameObject enemy in enemy_prefab) {
						GameObject x = Instantiate (enemy, new Vector3 (40.0f, 1.0f, 120.0f), transform .rotation)as GameObject;	
						myEnemy.Add (x);
				}
						
		}
	

		void Update ()
		{

	
		}
}
