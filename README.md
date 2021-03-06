# UnityRenderStreaming-Ayame-Sample

![image](https://github.com/tarakoKutibiru/UnityRenderStreaming-Ayame-Sample/blob/image/Image/UnityRenderStreaming-Ayame-Sample.gif?raw=true)

# これは何

Unity Render Streamingのシグナリング処理を、株式会社時雨堂様のAyameというシグナリングサーバに対応させてみたものです。

# サンプルの動かし方
1.このリポジトリをクローンして開きます。

2.[Ayame Lite](https://ayame-lite.shiguredo.jp/beta)にアクセスしてサインアップ。

3.Ayame Liteに書いてあるシグナリングURLとシグナリングキーをコピーして、Render Streamingコンポーネントに貼り付けます。

![image](https://github.com/tarakoKutibiru/UnityRenderStreaming-Ayame-Sample/blob/image/Image/SignalingKey.png?raw=true)

4.RoomIDをフォーマットに沿って適当に作成してRender Streamingコンポーネントに貼り付けます。

    例：GitHubID@TestRoom

以上で映像を送信するUnity側の設定はOKです。次に映像の受信側の設定を行います。時雨堂様が簡単にためせるウェブサイトを公開してくださっているので、それを使います。

5.URLを作ってAyame-Web-SDK-Samplesにアクセスする

先程適当に作成したRoomIDとAyame Liteのシグナリングキーを使ってURLをつくりアクセスします。

    https://openayame.github.io/ayame-web-sdk-samples/recvonly.html?roomId=<ROOMID>&signalingKey=<SIGNALING_KEY>

6.Unityを実行したあと、Ayame-Web-SDK-Smaple側の接続ボタンを押すと、シグナリングが実行されて、P2P通信が始まります。

# 関連
映像の受信側をReact Nativeで作成してみました。
https://github.com/tarakoKutibiru/UnityRenderStreaming-Ayame-ReactNative-Sample

# Discord

UnityでAyameを利用する人のためのコミュニティを作ってみました。私自身がサポートする可能性は低いですが、開発者同士の議論の場として使って頂けると嬉しいです。

[Discord](https://discord.gg/wGSG6SjkPA)