# SpawnWaves-SpaceShooter
Unity公式チュートリアルのSpaceShooterの敵の出現パターンを増やすためのコード。

# 使い方
1. SpaceShooterのGameController.cs内のSpawnWaves()関数を、本リポジトリのGameController.csのSpawnWaves()関数に置き換える
- 本リポジトリのScriptsフォルダー内の[SpawnWave.cs]と[SpawnWaveRandom.cs]と[SpawnWaveFormation.cs ]を、[SpaceShooter]のScriptsフォルダーにコピーする
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


# Waveの作り方
1. 敵を必要なだけ[Hierarchy]ビューにおいて、出現させたいフォーメーションで画面外に配置する
- Wave用に空のゲームオブジェクトを作成して、名前を[Wave自分の名前Waveの名前]に変更
- [Inspector]ビューの[Transform]欄を[Reset]して座標を原点にする
- [Project]ビューの[Scripts]フォルダー内から[SpawnWaveFormation]スクリプトをドラッグして、Wave用のゲームオブジェクトに追加
- [Hierarchy]ビューに並べたアステロイドや敵を全て、Wave用のゲームオブジェクトの子供にする
- 実行して、自分のイメージしている出現パターンになるように調整する
- 調整が完了したら、Wave用のゲームオブジェクトを[Project]ビューの[Prefabs]フォルダーにドラッグ＆ドロップして、プレハブ化
- [Hierarchy]ビューのWave用のゲームオブジェクトを削除する
- [Hierarchy]ビューから[GameController]を選択して、[Spawn Waves]欄に作成したWaveのプレハブをドラッグ＆ドロップ
以上で完了。実行して動作を確認する。



# スクリプトで出現させるオリジナルのウェーブの作成方法
敵の出現させるルーチンは、ベースクラスのSpawnWaveクラスを継承して作成する。

1. 新しいクラスを作成して、継承元をMonoBehaviourからSpawnWaveに変更する
2. public override IEnumerator spawnWave()を定義して、上書きする
3. Unityで新しいゲームオブジェクトを作成して、作成したスクリプトを追加
4. パラメータを設定
5. 作成したゲームオブジェクトをプレハブ化して、[Hierarchy]ビューから削除
6. [Hierarchy]ビューの[Game Controller]の[Spawn Waves]欄に追加する

詳しくは、[SpawnWaveRandomスクリプト](https://github.com/tanakaedu/SpawnWaves-SpaceShooter/blob/master/Assets/Scripts/SpawnWaveRandom.cs)を参照のこと。

