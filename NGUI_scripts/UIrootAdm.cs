using UnityEngine;
using System.Collections;

public class UIrootAdm : MonoBehaviour
{
		public GameObject talk;
		public GameObject knapsack;
		public GameObject attbute;
		public GameObject uistore;
		public GameObject skill;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (Input.GetKeyDown (KeyCode.K)) {
						if (talk.activeSelf) {
								talk.SetActive (false);
						} else {
								talk.SetActive (true);
						}
				}
				if (Input.GetKeyDown (KeyCode.L)) {
						if (attbute.activeSelf) {
								attbute.SetActive (false);
						} else {
								attbute.SetActive (true);
						}
				}
				if (Input.GetKeyDown (KeyCode.Q)) {
						if (knapsack.activeSelf) {
								knapsack.SetActive (false);
						} else {
								knapsack.SetActive (true);
						}
				}
				if (Input.GetKeyDown (KeyCode.U)) {
						if (uistore.activeSelf) {
								uistore.SetActive (false);
						} else {
								uistore.SetActive (true);
						}
				}
	
		}
}
