using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	/** ウェーブを登録*/
	public SpawnWave[] spawnWaves;

	// Use this for initialization
	void Start () {
		StartCoroutine (SpawnWaves ());
	}

	/** ウェーブを制御する*/
	IEnumerator SpawnWaves() {
		while (true) {
			// ウェーブを選択
			SpawnWave nowWave = spawnWaves[Random.Range(0,spawnWaves.Length)];
			yield return StartCoroutine (nowWave.spawnWave());
		}
	}
}
