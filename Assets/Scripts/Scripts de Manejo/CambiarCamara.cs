using UnityEngine;

//TODO:
//-remover variable _x y reemplazarla
[DisallowMultipleComponent]
public class CambiarCamara : MonoBehaviour {

	#region Variables
	[SerializeField]
	private GameObject[] camaras;
	int _seleccioncamara; //Decide cual cámara se activa la proxima vez que se presione el botón para cambio de cámara
	#endregion

	#region Unity Methods
    
	void Start()
	{
        _seleccioncamara = 1;//Empezar con Cámara en 2d 
        activarCamara2d();
	}

    void Update () {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (_seleccioncamara == 1)
            {
                activarCamara2d();
            }
            else
            {
                activarCamara3d();
            }
            _seleccioncamara = _seleccioncamara*(-1);
        }
    }

    #endregion

    void activarCamara2d()
    {
        camaras[0].GetComponent<Camera>().enabled = true;
        camaras[1].GetComponent<Camera>().enabled = false;
    }

    void activarCamara3d()
	{
		camaras[1].GetComponent<Camera>().enabled = true;
		camaras[0].GetComponent<Camera>().enabled = false;
	}
}
