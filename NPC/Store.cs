using UnityEngine;
using System.Collections;

public class PlayAnimation : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
				gameObject.GetComponent <Animation> ().Play ("idle");

		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
}
