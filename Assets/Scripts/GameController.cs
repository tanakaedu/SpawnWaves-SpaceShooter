using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	/** ウェーブを登録*/
	public GameObject[] spawnWaves;

	// Use this for initialization
	void Start () {
		StartCoroutine (SpawnWaves ());
	}

	/** ウェーブを制御する*/
	IEnumerator SpawnWaves() {
		for (int i = 0; i < spawnWaves.Length; i++) {
			// ウェーブを生成
			GameObject nowWave = Instantiate(spawnWaves[i], Vector3.zero, Quaternion.identity) as GameObject;
			// 実行監視
			yield return StartCoroutine (nowWave.GetComponent<SpawnWave>().spawnWave());
			// インスタンスを削除
			Destroy(nowWave);
		}

		// クリア処理へ
		Debug.Log("Clear!");
	}
}
