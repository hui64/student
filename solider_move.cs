using UnityEngine;
using System.Collections;

public class solider_move : MonoBehaviour
{
		public float speed = 1.0f;
		public  CharacterController controller ;
		public Vector3 solider_move01 = Vector3.zero;
		public float gravity_speed = 20.0f;
		public float jump_speed = 6.5f;
		public  Animator animator;
		public float velocity = 0.0f;
		public Vector3 new_move;
		public static  bool jump_bool = false;
		public float jumpTime;



	
	
		// Use this for initialization
		void Start ()
		{
			
				controller = GetComponent<CharacterController> ();
				animator = GetComponent<Animator> ();
				//GetComponent<NavMeshAgent> ().destination = new Vector3 (50, 6, 107);
				//GetComponent<NavMeshAgent> ().enabled = false;
			
		}
	
		// Update is called once per frame
		void Update ()
		{
				AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo (1);

				if (transform.position.x > 5 & transform.position.z > 5 & transform.position.x < 490.0f & transform.position.z < 490.0f & Input.GetKey (KeyCode.W) & stateInfo.nameHash == Animator.StringToHash ("State.Empty")) {
						solider_move01 = transform.forward * Time.deltaTime * speed;
					
				} else {
						solider_move01 = Vector3.zero;
				}

				solider_move01.y -= gravity_speed * Time.deltaTime;
				if (Input.GetKeyDown (KeyCode.Space) & controller.isGrounded) {
						jump_bool = true;
						animator .SetBool ("Jump_bool", true);
				}
				if (jump_bool) {
						transform .Translate (0, 0.3f, 0);
						StartCoroutine (Wait ());
				}



				solider_move01 = (solider_move01 + animator.deltaPosition * 0) * speed;
			


				controller.Move (solider_move01);
				

				//print (controller.velocity);

				//if (Input .GetKey (KeyCode.W)) {
				//	transform.Translate (0, 0,speed);
				//}
				transform.Rotate (0, Input.GetAxis ("Horizontal"), 0, Space.Self);


	
		}
		IEnumerator Wait ()
		{
		
				yield return new WaitForSeconds (jumpTime);
				
				jump_bool = false;


		
		}
		

}

