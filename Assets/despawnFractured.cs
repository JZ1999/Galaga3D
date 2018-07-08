using UnityEngine;

public class despawnFractured : MonoBehaviour {

    #region Variables
	[SerializeField]
	private float despawnTime;
	private float aux;
	[SerializeField]
	private AudioSource crackling;
	#endregion

	#region Unity Methods

	void Start () {
		crackling.Play();
		aux = despawnTime;
    }
    
    void Update () {
		despawnTime -= Time.deltaTime;
        if(despawnTime < 0)
		{
			Destroy(gameObject);
		}
    }

    #endregion
}
