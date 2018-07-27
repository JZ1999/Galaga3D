using UnityEngine;

//Le agrega rigidbody a cada fracturacion del planeta y setea el tag de todos
[DisallowMultipleComponent]
public class addGravity : MonoBehaviour {

	#region Variables
    #endregion

    #region Unity Methods

    void Start () {
		gameObject.AddComponent<Rigidbody>();
		gameObject.tag = "planet";
    }

	void Update()
	{
		int __direccionAleatoriaDeFuerza = Random.Range(0, 4);
		aplicarFuerza(__direccionAleatoriaDeFuerza);
	}

    #endregion

	void aplicarFuerza(int __direccionAleatoriaDeFuerza)
	{
		//Modificar empuje para tener resultado querido
		if (__direccionAleatoriaDeFuerza == 0)
			gameObject.GetComponent<Rigidbody>().AddForce(Vector3.left * 4);//Se multiplica por 4 para exagerar el empuje
		else if (__direccionAleatoriaDeFuerza == 1)
			gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * 4);
		else if (__direccionAleatoriaDeFuerza == 2)
			gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * 3);
		else if (__direccionAleatoriaDeFuerza == 3)
			gameObject.GetComponent<Rigidbody>().AddForce(Vector3.back * 3);

	}
}
