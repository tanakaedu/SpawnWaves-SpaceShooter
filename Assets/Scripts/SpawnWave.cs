using UnityEngine;
using System.Collections;

/**
 * 敵の出現を制御するためのベースクラス
 * 敵の出現パターンを作成する手順
 * 1. SpawnWave_ウェーブ名などで、新しいクラスを作成してこのクラスを継承
 * 2. public override IEnumerator spawnWave()を定義して、上書きする
 * 3. Unityで新しいゲームオブジェクトを作成して、作成したスクリプトを追加
 * 4. パラメータを設定
 * 5. 作成したゲームオブジェクトをプレハブ化して、[Hierarchy]ビューから削除
 * 6. [Hierarchy]ビューの[Game Controller]の[Spawn Waves]欄に追加する
 */
public abstract class SpawnWave : MonoBehaviour {
	/** このウェーブで出現させる敵のプレハブ*/
	public GameObject[] spawnPrefabs;

	/** デフォルトは、Unity公式のSpaceShooterの出現ルーチン。
	 * ランダムで、設定されている敵を出現させる
	 */
	public abstract IEnumerator spawnWave ();
}
