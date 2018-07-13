using UnityEngine;

public class Movement : MonoBehaviour {

	#region Variables
	public Rigidbody rb;
	public float speed;
	public float rotation;
	public Transform tr;
    #endregion

    #region Unity Methods
    
    void Update () {
		int movement = applyRotation(getMovement());
		if(transform.position.x > 4.5 || transform.position.x < -4.5)
		{
			Vector3 dir = transform.position.x > 4.5 ? Vector3.left : Vector3.right;
			rb.AddForce(dir);
			rb.velocity = Vector3.zero;
		}
		if (movement!=0)
		{
			float new_x = speed * Time.deltaTime * movement;
			rb.AddForce(new Vector3(new_x,0,0));
		}
		else
		{
		}
    }

    #endregion

	private int getMovement()
	{
		if (Input.GetKey(KeyCode.A))
			return -1;
		else if (Input.GetKey(KeyCode.D))
			return 1;
		return 0;
	}

	private int applyRotation(int dir)
	{
		float z = transform.rotation.z;
		bool canRotate = z > -0.13 && z < 0.13;
		bool canRotateLeft = z > -0.13;
		bool canRotateRight = z < 0.13;

		if (canRotate)
			tr.Rotate(new Vector3(0, 0, rotation * -dir));
		else if ( !canRotateLeft && dir == 1 )
			tr.Rotate(new Vector3(0,0,rotation*-dir));
		else if (!canRotateRight && dir == -1)
			tr.Rotate(new Vector3(0, 0, rotation*-dir));
		return dir;
	}
}

