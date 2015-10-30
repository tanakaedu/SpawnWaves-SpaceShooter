using UnityEngine;
using System.Collections;

/**
 * フォーメーションをプレハブに設定した敵を出現させるためのスクリプト
 * 敵の出現パターンを作成する手順
 * 1. [Hierarchy]ビューで、出現させたい形状に敵を配置する
 * 2. ウェーブを制御するために空のゲームオブジェクトを作成して、適当な名前をつける
 * 3. 並べた敵をすべてその子供にする
 * 4. ウェーブ用のゲームオブジェクトにこのスクリプトを追加する]
 * 5. 出現させたオブジェクトがすべて画面から消えてから、何秒経過したら次のウェーブに移行させるかを、NextTime属性で設定
 * 6. 設定が完了したら、プレハブ化して、[Hierarchy]ビューから削除
 * 6. [Hierarchy]ビューの[Game Controller]の[Spawn Waves]欄に追加する
 */
public class SpawnWaveFormation : SpawnWave {
	/** 出現させたオブジェクトがすべて画面から消えてから、何秒経過したら次のウェーブに移行させるか(でっフォルトは3秒)*/
	public float NextTime = 3f;
	/** このウェーブが持っている敵のプレハブ*/
	Transform[] enemies;
	/** 出現待ち*/
	bool isStarted = false;

	void Start() {
		isStarted = true;
	}

	/** デフォルトは、Unity公式のSpaceShooterの出現ルーチン。
	 * ランダムで、設定されている敵を出現させる
	 */
	public override IEnumerator spawnWave () {
		// 生成待ち
		while (!isStarted) {
			yield return null;
		}

		// 自分が持っているゲームオブジェクトをすべて確認
		enemies	= gameObject.GetComponentsInChildren<Transform>();
		int count = 0;

		// 終了を確認
		while (count < enemies.Length) {
			count = 1;	// 自分を含めておく
			for (int i = 0; i < enemies.Length; i++) {
				if (enemies [i] == null) {
					count++;
				}
			}
			yield return null;
		}

		// 次のウェーブを待つ
		yield return new WaitForSeconds(NextTime);
	}
}

