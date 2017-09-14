using UnityEngine;

public class CameraJogador : MonoBehaviour {

	Vector3 direfrecaPosicao;
	public GameObject jogador;

	void Start () {
		direfrecaPosicao = jogador.transform.position -
					gameObject.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		gameObject.transform.position = 
			jogador.transform.position - direfrecaPosicao;
	}
}
