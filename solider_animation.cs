using UnityEngine;
using System.Collections;


public class solider_animation : MonoBehaviour
{
	
		public Animator animator;
		public int key = 0;
		private float myTime;
		private float hitTime;
		public bool	key_bool = true;
		public  CharacterController controller ;

		
		


		
		void Start ()
		{
				hitTime = 1.2f;
				controller = GetComponent<CharacterController> ();
				animator = GetComponent<Animator> ();
				
				//myList = new List<BaseEnemyAI> ();
			
				
				
				
	
		}
		
		void Update ()
		{
				AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo (1);
				
				myTime += Time.deltaTime;
				hitTime -= Time.deltaTime;
				if (key > 3) {
						key = 0;
				}
				if (stateInfo.nameHash == Animator.StringToHash ("State.Empty") & myTime > 0.2) {
						key_bool = true;
				}
				if (Input.GetButton ("Fire1")) {
						animator.SetBool ("Attact_bool", true);
						if (key_bool) {
								animator.SetFloat ("Attact_float", key);
								if (hitTime > 0) {
										key++;
										
								} else {
										key = 0;
								}
								key_bool = false;
								myTime = 0;
								hitTime = 1.2f;
						}
				}
				if (Input.GetButtonUp ("Fire1")) 
						animator.SetBool ("Attact_bool", false);
				//if (Input.GetKey (KeyCode .Space))
				//		animator .SetBool ("Jump_bool", true);
				if (stateInfo.nameHash == Animator.StringToHash ("State.jump"))
						animator.SetBool ("Jump_bool", false);
				if (Input .GetKeyDown (KeyCode.R))
						animator.SetBool ("Buff_bool", true);
				if (Input .GetKeyUp (KeyCode.R))
						animator.SetBool ("Buff_bool", false);
				if (Input .GetKeyDown (KeyCode.D))
						animator.SetBool ("Left_bool", true);
				if (Input .GetKeyUp (KeyCode.D))
						animator.SetBool ("Left_bool", false);
				if (Input .GetKeyDown (KeyCode.A))
						animator.SetBool ("Right_bool", true);
				if (Input .GetKeyUp (KeyCode.A))
						animator.SetBool ("Right_bool", false);
				
				if (Input .GetKey (KeyCode.W))
						animator.SetBool ("Run_bool", true);
				if (Input .GetKeyUp (KeyCode.W))
						animator.SetBool ("Run_bool", false);
			      
		}  
		

}

	

