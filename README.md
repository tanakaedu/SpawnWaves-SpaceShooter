# SpawnWaves-SpaceShooter
Unity公式チュートリアルのSpaceShooterの敵の出現パターンを増やすためのコード。

# 使い方
1. SpaceShooterのGameController.cs内のSpawnWaves()関数を、本リポジトリのGameController.csのSpawnWaves()関数に置き換える
- 本リポジトリのScriptsフォルダー内の[SpawnWave.cs]と[SpawnWaveRandom.cs]を、[SpaceShooter]のScriptsフォルダーにコピーする
- SpaceShooterをUnityで開く
- [Hierarchy]ビューの[Create]から[Create Empty]で空のゲームオブジェクトを作成
- 名前を[SpawnWaveRandom]にする
- [Project]ビューの[Scripts]フォルダー内の[SpawnWaveRandom]をドラッグして、[Hierarchy]ビューの[SpawnWaveRandom]にドロップ
- [Project]ビューの[Prefabs]フォルダーから出現させたいアステロイドや敵のプレハブをドラッグして、[Inspector」ビューの[Spawn Prefabs]欄にドロップ
- [Hierarchy]ビューの[SpawnWaveRandom]をドラッグして、[Project]ビューの[Prefabs]フォルダーにドロップして、プレハブ化
- [Hierarchy]ビューの[SpawnWaveRandom]を削除
- [Hierarchy]ビューから[Game Controller]を選択
- [Project]ビューの[Prefabs]フォルダーから[SpawnWaveRandom]をドラッグして、[Inspector]ビューの[Game Controller]スクリプトの[Spawn Waves]欄にドロップ

以上で設定完了。実行結果は変わらないが、自前でウェーブを作成して登録することができるようになった。


# オリジナルのウェーブの作成方法
敵の出現させるルーチンは、ベースクラスのSpawnWaveクラスを継承して作成する。

1. 新しいクラスを作成して、継承元をMonoBehaviourからSpawnWaveに変更する
2. public override IEnumerator spawnWave()を定義して、上書きする
3. Unityで新しいゲームオブジェクトを作成して、作成したスクリプトを追加
4. パラメータを設定
5. 作成したゲームオブジェクトをプレハブ化して、[Hierarchy]ビューから削除
6. [Hierarchy]ビューの[Game Controller]の[Spawn Waves]欄に追加する

詳しくは、[SpawnWaveRandomスクリプト](https://github.com/tanakaedu/SpawnWaves-SpaceShooter/blob/master/Assets/Scripts/SpawnWaveRandom.cs)を参照のこと。

