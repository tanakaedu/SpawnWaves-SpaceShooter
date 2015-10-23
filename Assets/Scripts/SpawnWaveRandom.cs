using UnityEngine;
using System.Collections;

/**
 * SpawnWaveを利用した敵の出現例。
 * Unity公式チュートリアルSpaceShooterのGameControllerに実装されている
 * 敵の出現ルーチンをもとに実装しなおしたもの。
 * @url http://unity3d.com/jp/learn/tutorials/projects/space-shooter/game-controller?playlist=17147
 */
public class SpawnWaveRandom : SpawnWave {
	/** 敵を出現させる座標*/
	public Vector3 spawnValues = new Vector3(6f, 0f, 16f);
	/** 出現させる敵の数*/
	public int hazardCount = 10;
	/** 出現待ちする秒数*/
	public float spawnWait = 0.5f;
	/** ウェーブが始まるまでの待ち時間*/
	public float startWait = 1f;
	/** ウェーブ後に次のウェーブに移行するまでの待ち時間*/
	public float waveWait = 4f;

	/** 敵を出現させる関数*/
	public override IEnumerator spawnWave ()
	{
		yield return new WaitForSeconds (startWait);
		for (int i = 0; i < hazardCount; i++) {
			GameObject hazard = spawnPrefabs [Random.Range (0, spawnPrefabs.Length)];
			Vector3 spawnPosition = new Vector3 (
				                        Random.Range (-spawnValues.x, spawnValues.x),
				                        spawnValues.y,
				                        spawnValues.z);
			Instantiate (hazard, spawnPosition, Quaternion.identity);
			yield return new WaitForSeconds (spawnWait);
		}

		yield return new WaitForSeconds (waveWait);
	}
}
