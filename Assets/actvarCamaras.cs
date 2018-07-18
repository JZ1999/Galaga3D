using UnityEngine;

public class actvarCamaras : MonoBehaviour {

	#region Variables
	[SerializeField]
	private GameObject[] camaras;
	[SerializeField]
	private float Timer;
	bool x = true;
	#endregion

	#region Unity Methods
    
	void Start()
	{
		camaras[0].GetComponent<Camera>().enabled = true;
		camaras[1].GetComponent<Camera>().enabled = false;
	}

    void Update () {
		Timer -= Time.deltaTime;
		if (Timer < 0 && x)
		{
			x = false;
			Debug.Log("Cam");
			camaras[1].GetComponent<Camera>().enabled = true;
			camaras[0].GetComponent<Camera>().enabled = false;
			
		}
	}

    #endregion
}
