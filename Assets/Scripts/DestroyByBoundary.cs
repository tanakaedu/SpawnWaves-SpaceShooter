using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour {
	void OnTriggerExit(Collider col) {
		Destroy (col.gameObject);
	}
}
