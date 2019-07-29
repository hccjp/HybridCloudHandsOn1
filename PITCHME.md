# HCCJP ハンズオン

AzureとAzureStackを用いたIaaS,PaaS,FaaS体験

- スライドURL <https://gitpitch.com/hccjp/hybridcloudhandson1>

---


## ハンズオン目的

このハンズオンではAzureおよびAzure StackをもちいてIaaS, PaaS, FaaSの概要を体験していただきます。

---

## アジェンダ

1. サブスクリプション準備
2. 仮想マシン展開 - ブラウザ
3. 展開後のWindows Server 2016の確認
4. 仮想マシン展開 - PowerShell
5. テンプレート展開
6. コンテナ基盤展開
7. Webサイト作成
8. Teamsにメッセージを送信するWebサービス作成

---

## アジェンダ - 1

1. サブスクリプション準備(←今ここ)
2. 仮想マシン展開 - ブラウザ
3. 展開後のWindows Server 2016の確認
4. 仮想マシン展開 - PowerShell
5. テンプレート展開
6. コンテナ基盤展開
7. Webサイト作成
8. Teamsにメッセージを送信するWebサービス作成

---

## 1. サブスクリプション準備

- ハンズオンで利用するAzure用サブスクリプションを確認します。(各自)
- ハンズオンで利用するAzure Stack用サブスクリプションを確認します。(代表者1名)

---

### Azureサブスクリプション準備(各自)

- Azureサブスクリプションは事前に準備をお願いしていました。
- Azure管理ポータルにアクセスし「サブスクリプション」を表示、確認してください。

---

- <https://portal.azure.com/> にアクセスします
- サブスクリプション一覧を表示します

![サブスクリプションの表示](2019-07-24-21-26-15.png)

---

- 有効なサブスクリプションが存在する事を確認します。

![サブスクリプション一覧](2019-07-24-21-27-19.png)

---

### AzureStackのサブスクリプションを確認します。(代表者1名

- 管理ポータルにアクセスし「サブスクリプション」を表示、確認します。

---

- Azure Stackの管理ポータルにアクセスします
- サブスクリプション一覧を表示します

![サブスクリプションの表示](2019-07-24-21-58-06.png)

---

- 有効なサブスクリプションが存在する事を確認します。

![サブスクリプション一覧](2019-07-24-21-58-58.png)

---

## アジェンダ - 2

1. サブスクリプション準備
2. 仮想マシン展開 - ブラウザ(←今ここ)
3. 展開後のWindows Server 2016の確認
4. 仮想マシン展開 - PowerShell
5. テンプレート展開
6. コンテナ基盤展開
7. Webサイト作成
8. Teamsにメッセージを送信するWebサービス作成

---

## 2. 仮想マシン展開 - ブラウザ

- AzureにWindows Server 2016を展開します。(各自)
- Azure StackにWindows Server 2016を展開します。(代表者1名)

---

### AzureにWindows Server 2016を展開します。(各自)

---

@snap[midpoint span-80]

![リソースの作成](2019-07-26-12-13-29.png)

@snapend

---

@snap[midpoint span-80]

![Windows Server 2016 Datacenter](2019-07-26-12-16-46.png)

@snapend

---

@snap[midpoint span-80]

![仮想マシンの作成](2019-07-26-12-19-20.png)

@snapend

---

@snap[midpoint span-80]

![リソースグループ新規作成](2019-07-26-12-21-52.png)

@snapend

---

@snap[midpoint span-80]

![インスタンスの詳細](2019-07-26-12-23-28.png)

@snapend

---

@snap[midpoint span-80]

![管理者アカウント](2019-07-26-12-32-03.png)

@snapend

---

@snap[midpoint span-80]

![受信ポートの規則](2019-07-26-12-33-41.png)

@snapend

---

@snap[midpoint span-80]

![お金を節約](2019-07-26-12-47-26.png)

@snapend

---

@snap[midpoint span-80]

![仮想マシンの作成](2019-07-26-13-08-06.png)

@snapend

---

@snap[midpoint span-80]

![デプロイ](2019-07-26-12-52-17.png)

@snapend

---

あとは待てば完了です！

---

### Azure StackにWindows Server 2016を展開します。(代表者1名)

---

@snap[midpoint span-80]

![新規](2019-07-26-13-19-48.png)

@snapend

---

@snap[midpoint span-80]

![Windows Server 2016 pay-as-you-use](2019-07-26-14-43-06.png)

@snapend

---

@snap[midpoint span-40]

![作成](2019-07-26-14-45-14.png)

@snapend

---

@snap[midpoint span-40]

![基本](2019-07-26-14-50-00.png)

@snapend

---

@snap[midpoint span-80]

![サイズの選択](2019-07-26-14-55-56.png)

@snapend

---

@snap[midpoint span-30]

![設定1](2019-07-26-14-57-41.png)

@snapend

---

@snap[midpoint span-30]

![設定2](2019-07-26-14-58-49.png)

@snapend

---

@snap[midpoint span-50]

![概要](2019-07-26-15-00-01.png)

@snapend

---

@snap[midpoint span-80]

![デプロイ](2019-07-26-15-02-32.png)

@snapend

---

@snap[midpoint span-80]

![デプロイ進行中](2019-07-26-15-03-20.png)

@snapend

---

あとは待てば完了です！

---

## アジェンダ - 3

1. サブスクリプション準備
2. 仮想マシン展開 - ブラウザ
3. 展開後のWindows Server 2016の確認(←今ここ)
4. 仮想マシン展開 - PowerShell
5. テンプレート展開
6. コンテナ基盤展開
7. Webサイト作成
8. Teamsにメッセージを送信するWebサービス作成

---

## 3. 展開後のWindows Server 2016の確認

---

### Azure に展開したWindows Server 2016の確認

---

![デプロイ完了](2019-07-26-13-35-26.png)

---

![仮想マシンのネットワーク設定](2019-07-26-13-37-45.png)

---

### Azure VMの構成

![IPアドレスマップ](2019-07-26-14-12-06.png)
- ※ 引用元：https://blogs.technet.microsoft.com/mskk-cloudos/2016/04/06/azure-ip/

---

![接続](2019-07-26-14-35-43.png)

---

![仮想マシンに接続する](2019-07-26-14-37-31.png)

---

![RDP](2019-07-26-14-38-55.png)

---

![発行元](2019-07-26-14-39-56.png)

---

![資格情報](2019-07-26-14-25-45.png)

---

![リモートコンピューターのID](2019-07-26-14-26-29.png)

---

![WindowsServer2016](2019-07-26-14-32-54.png)

---

かんたんに展開でき、きちんと動作していましたね！

---

### Azure Stackに展開したWindows Server 2016の確認

---

![デプロイ完了](2019-07-26-15-26-44.png)

---

![リソースグループ](2019-07-26-16-00-34.png)

---

![接続](2019-07-26-16-02-14.png)

---

![RDPファイルのダウンロード](2019-07-26-16-26-09.png)

---

![RDP](2019-07-26-16-28-07.png)

---

![発行元](2019-07-26-16-28-58.png)

---

@snap[midpoint span-60]

![資格情報](2019-07-26-16-30-17.png)

@endsnap

---

@snap[midpoint span-60]

![リモートコンピューターのID](2019-07-26-16-31-08.png)

@endsnap

---

![WindowsServer2016](2019-07-26-16-34-46.png)

---

かんたんに展開でき、きちんと動作していましたね！

---

- 手動でブラウザ上のGUIで仮想マシンを展開する方法を見てもらいました。

---

- 今作成した環境を削除します。
  
---

### Azure 上のリソースの削除

---

![リソースグループ](2019-07-26-18-02-41.png)

---

![リソースグループの削除](2019-07-26-18-03-35.png)

---

![リソースグループの削除](2019-07-26-18-04-35.png)

---

### Azure Stack上のリソースの削除

---

![リソースグループ](2019-07-26-18-05-52.png)

---

![リソースグループの削除](2019-07-26-18-06-31.png)

---

![リソースグループの削除](2019-07-26-18-07-22.png)

---

## アジェンダ - 4

1. サブスクリプション準備
2. 仮想マシン展開 - ブラウザ
3. 展開後のWindows Server 2016の確認
4. 仮想マシン展開 - PowerShell(←今ここ)
5. テンプレート展開
6. コンテナ基盤展開
7. Webサイト作成
8. Teamsにメッセージを送信するWebサービス作成

---

## 4. 仮想マシン展開 - PowerShell

---

### Azure への仮想マシン展開 - PowerShell

---

![CloudShell](2019-07-26-22-09-07.png)

---

![ストレージ](2019-07-26-22-12-24.png)

- BashとPowerShellの選択ではPowerShellを選択してください

---

```
cd $home\clouddrive
git clone https://github.com/hccjp/HybridCloudHandsOn1.git
cd ./HybridCloudHandsOn1/
./NewVM.ps1
location?: JapanEast
```
---

![展開中](2019-07-26-22-59-05.png)

---

![VM展開](2019-07-26-22-59-55.png)

---

![VM展開終了](2019-07-26-23-18-08.png)

---

- 確認後リソースグループを削除します。

```
Remove-AzResourceGroup -Name HCCJP_WS2016byPS -Force
```

---

### Azure Stackへの仮想マシン展開 - PowerShell

---

- Azure Stackへの接続が設定されています。

![AzureRMEnvironments](2019-07-26-23-43-02.png)

---

```
cd c:\tmp
git clone https://github.com/hccjp/HybridCloudHandsOn1.git
cd ./HybridCloudHandsOn1/
Add-AzureRmAccount -Environment AzureStackUser
./NewVM.ps1
location?: tokyo
```

---

- Azure / Azure Stackともに全く同じスクリプトでVM展開ができました！

---

- 確認後リソースグループを削除します。

```
Remove-AzResourceGroup -Name HCCJP_WS2016byPS -Force
```

---

## アジェンダ - 5

1. サブスクリプション準備
2. 仮想マシン展開 - ブラウザ
3. 展開後のWindows Server 2016の確認
4. 仮想マシン展開 - PowerShell
5. テンプレート展開(←今ここ)
6. コンテナ基盤展開
7. Webサイト作成
8. Teamsにメッセージを送信するWebサービス作成

---

## 5. テンプレート展開

- Azure にARMテンプレートを展開します。
- Azure StackにARMテンプレートを展開します。

---

### Azure にARMテンプレートを展開します

---

![テンプレートを検索](2019-07-28-14-28-35.png)

---

![テンプレートを選択](2019-07-28-14-29-27.png)

---

![テンプレートを作成](2019-07-28-14-30-21.png)

---

![テンプレートを選択](2019-07-28-14-32-46.png)

---

![パラメーター](2019-07-28-14-37-08.png)

---

![使用条件](2019-07-28-14-38-23.png)

---

![デプロイ状況の確認](2019-07-28-14-44-33.png)

---

![テンプレート展開成功](2019-07-28-15-07-43.png)

---

![RGへのアクセス](2019-07-28-15-11-05.png)

---

![VMクリック](2019-07-28-15-12-43.png)

---

![接続](2019-07-28-15-13-28.png)

---

![RDPファイルダウンロード](2019-07-28-15-14-18.png)

---

![RDPファイル](2019-07-28-15-15-17.png)

---

![接続](2019-07-28-15-16-20.png)

---

![認証情報](2019-07-28-15-17-21.png)

---

![リモートコンピューターID](2019-07-28-15-17-56.png)

---

![Active Directory Site and Services](2019-07-28-15-20-34.png)

---

![DCs](2019-07-28-15-21-59.png)

---

- 確認後リソースグループを削除します。

![リソースグループ削除](2019-07-28-15-23-53.png)

---

### AzureStack にARMテンプレートを展開します

---

![テンプレートの検索](2019-07-28-15-28-55.png)

---

![テンプレート展開の選択](2019-07-28-15-34-02.png)

---

![作成](2019-07-28-15-35-08.png)

---

![テンプレートの編集](2019-07-28-15-36-25.png)

---

![クイックスタートテンプレート](2019-07-28-15-37-06.png)

---

![テンプレート選択](2019-07-28-15-38-31.png)

---

![保存](2019-07-28-15-39-50.png)

---

![パラメーターの編集](2019-07-28-15-40-40.png)

---

![パラメーター](2019-07-28-15-42-34.png)

---

![テンプレート展開](2019-07-28-15-45-03.png)

---

![進行中のデプロイの確認](2019-07-28-15-46-35.png)

---

![デプロイ進行中](2019-07-28-15-50-52.png)

---

- 今回は環境の問題(インターネットの名前解決ができない)でこのテンプレート展開は失敗します。
- 限定的な環境でも展開成功するようにテンプレートにPullRequestを出そうと思います。

---

## アジェンダ - 6

1. サブスクリプション準備
2. 仮想マシン展開 - ブラウザ
3. 展開後のWindows Server 2016の確認
4. 仮想マシン展開 - PowerShell
5. テンプレート展開
6. コンテナ基盤展開(←今ここ)
7. Webサイト作成
8. Teamsにメッセージを送信するWebサービス作成

---

## 6. コンテナ基盤展開

---

### Azure へのコンテナ基盤展開

---

![Search Container](2019-07-28-17-58-57.png)

---

![AKS](2019-07-28-17-59-45.png)

---

![作成](2019-07-28-18-00-23.png)

---

![Kubernetesクラスターを作成](2019-07-28-18-03-20.png)

---

![確認および作成](2019-07-28-18-07-29.png)

---

![作成](2019-07-28-18-08-22.png)

---

![Deoploy Complete](2019-07-28-18-17-53.png)

---

![Kubernetes Service](2019-07-28-18-18-21.png)

---

![Kubernetes Service - Overview](2019-07-28-18-19-06.png)

---

![delete - AKS](2019-07-28-18-20-37.png)

---

### Azure Stackへのコンテナ基盤展開

---

![Kubernetes Cluster](2019-07-28-16-19-17.png)

---

![作成](2019-07-28-16-19-59.png)

---

![基本](2019-07-28-16-20-55.png)

---

- publickey
  - ssh-rsa AAAAB3NzaC1yc2EAAAADAQABAAACAQDZKRx3tZPzZNc7rEZDPJGM6cZ+DeoN16CnvdK4uP958LJOlko70ah3RAB/WJg3/BS5mCU42AljxNMwJLdo3hYItjj068M37V+cv6D7ewXoACaeYYBH4PGGsFNhf/A6geFdtZt+JdupUlARmNKzoHxawolGLZMV6249S6vz6+bNcAkvQtgbYGbzlRjiE633Hz0mmx7m1+vuRMIjhvq409U6aNgmSHoIiCefNv5oMyFnqCnXMaQnKheQLJoNDVtILycprH/UjUc/pPG8tU1CgfTJVdKuO0JHGf3/21Y1l5UbI0bKpv9kBD1oFzn/I9MNQnYTkEBm6q/EVH0lxH1uwrvQeObyU+aKmsBwKmsaX11cIwU1mRUmhfdi/y6bAHbrYLVQa9+diGw+ClQPbXE9iTLsHiiJdNCgshqSnTqMOwL6nAX4wPeYPpW+5SkfChhrrvwicuHiEWdE/LfGXKc/xNuAwHhe1OTB4C0DRFeiUmEtjQGzRYK3+yUJfRwKW2dfthgfF6TSiM6iA6JKJjIdlRcobxim8kMk8r1ZVaKgIIZ1YjcveeuifXW3KlVPwxnc1DKgXObkTfteYYFKloVCUlIjCn8n+2qa9OIbuhrA4W2hNZHKU2dSNvhzJR3dOu3hz9uvYR5q182aoA1NPaWliV3UqgP/rXdvMExqBB21KrqXBQ== ebibibi@gmail.com

---

- アプリケーション (クライアント) ID
  - HybridCloudDemoSPN
  - 2347abf7-923c-49f9-9660-1e9b687f528b
- アプリケーションシークレット
  - その場で生成します

---

![Kubernetes Cluster Settings](2019-07-28-17-04-31.png)

---

![検証](2019-07-28-17-05-09.png)

---

![作成](2019-07-28-17-05-34.png)

---

![展開](2019-07-28-17-06-31.png)

---

![デプロイ進行中](2019-07-28-17-07-30.png)

---

![デプロイ完了](2019-07-28-17-49-36.png)

---

![リソースグループアクセス](2019-07-28-17-50-45.png)

---

![Kubernetes Cluster](2019-07-28-17-51-17.png)

---

## アジェンダ - 7

1. サブスクリプション準備
2. 仮想マシン展開 - ブラウザ
3. 展開後のWindows Server 2016の確認
4. 仮想マシン展開 - PowerShell
5. テンプレート展開
6. コンテナ基盤展開
7. Webサイト作成(←今ここ)
8. Teamsにメッセージを送信するWebサービス作成

---

## 7. Webサイト作成

---

### AzureでのWebサイト作成(全員)

---

![web検索](2019-07-28-19-30-29.png)

---

![Webアプリ](2019-07-28-19-31-34.png)

---

![作成](2019-07-28-19-32-17.png)

---

![Webアプリ作成](2019-07-28-19-40-01.png)

---

![サイズ変更](2019-07-28-19-40-36.png)

---

![スペックの選択](2019-07-28-19-41-15.png)

---

![F1](2019-07-28-19-42-27.png)

---

![確認と作成](2019-07-28-19-43-23.png)

---

![作成](2019-07-28-19-44-17.png)

---

![デプロイ進行中](2019-07-28-19-45-12.png)

---

![デプロイ完了](2019-07-28-19-45-50.png)

---

![参照](2019-07-28-19-46-45.png)

---

![web page](2019-07-28-19-49-12.png)

---

- もろもろ確認したら削除します。

---

![リソースグループに移動](2019-07-28-19-50-44.png)

---

![リソースグループ](2019-07-28-19-51-37.png)

---

![削除](2019-07-28-19-52-37.png)

---

### AzureStackでのWebサイト作成(代表１名)

---

![Web検索](2019-07-28-19-58-09.png)

---

![Web App](2019-07-28-19-59-35.png)

---

![作成](2019-07-28-20-00-18.png)

---

![Web App作成](2019-07-28-20-02-17.png)

---

![App Serviceプラン作成](2019-07-28-20-04-51.png)

---

![新しい App Service プラン](2019-07-28-20-05-51.png)

---

![価格レベルを選択](2019-07-28-20-07-37.png)

---

![作成](2019-07-28-20-08-23.png)

---

![リソースに移動](2019-07-28-20-09-59.png)

---

![参照](2019-07-28-20-15-35.png)

---

![Webサイト](2019-07-28-20-16-24.png)

---

## アジェンダ - 8

1. サブスクリプション準備
2. 仮想マシン展開 - ブラウザ
3. 展開後のWindows Server 2016の確認
4. 仮想マシン展開 - PowerShell
5. テンプレート展開
6. コンテナ基盤展開
7. Webサイト作成(←今ここ)
8. Teamsにメッセージを送信するWebサービス作成

---

## 8. Teamsにメッセージを送信するWebサービス作成

---

![Incoming Web Hook](2019-07-28-20-53-23.png)

---

- Incoming Web Hook
  - https://outlook.office.com/webhook/9260568e-df73-4b63-9668-6349b3ce05ad@88cb30cf-9982-4b0b-950f-243b551e44ba/IncomingWebhook/6aed418937dc4120b583b23391010f2b/4ee8d085-8181-4c77-9626-44218cc2b583

---

### Azureに「Teamsにメッセージを送信するWebサービス」を展開

---

![リソースの作成](2019-07-28-21-17-08.png)

---

![Function App](2019-07-28-21-18-52.png)

---

![作成](2019-07-28-21-19-28.png)

---

![Function App作成パラメータ](2019-07-28-21-22-13.png)

---

![リソースに移動](2019-07-28-21-24-15.png)

---

![関数新規作成](2019-07-28-21-25-10.png)

---

![新しい関数](2019-07-28-21-25-53.png)

---

![HTTP trigger](2019-07-28-21-27-06.png)

---

![新しい関数](2019-07-28-21-28-20.png)

---

![初期状態](2019-07-28-21-29-00.png)

---

```

#r "Newtonsoft.Json"

using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System.Collections;
using Newtonsoft.Json;

public static async Task<IActionResult> Run(HttpRequest req, ILogger log)
{
    string message = req.Query["message"];
    string url = "https://outlook.office.com/webhook/9260568e-df73-4b63-9668-6349b3ce05ad@88cb30cf-9982-4b0b-950f-243b551e44ba/IncomingWebhook/6aed418937dc4120b583b23391010f2b/4ee8d085-8181-4c77-9626-44218cc2b583";

    using (HttpClient httpClient = new HttpClient())
    {
    var param = new Hashtable();
    param["Text"] = message;
    var json = JsonConvert.SerializeObject(param);

    var content = new StringContent(json);
    HttpResponseMessage response = await httpClient.PostAsync(url, content);
    }

    return message != null
        ? (ActionResult)new OkObjectResult($"message sent. {message}")
        : new BadRequestObjectResult("Please pass a message on the query string or in the request body");
}
```

---

- コード
- http://bit.ly/2YmDOm1

---

![コード保存](2019-07-28-21-35-30.png)

---

![関数のURLの取得](2019-07-28-21-36-38.png)

---

![関数URLコピー](2019-07-28-21-37-32.png)

---

![実行](2019-07-28-21-42-06.png)

---

![文字列作成](2019-07-28-21-44-40.png)

---

![実行](2019-07-28-21-44-59.png)

---

![実行結果](2019-07-28-21-45-40.png)

---

- 確認したらリソースグループを削除します。

---

![リソースグループに移動](2019-07-28-21-46-50.png)

---

![削除](2019-07-28-21-47-27.png)

---

![削除](2019-07-28-21-48-12.png)

---

### AzureStackに「Teamsにメッセージを送信するWebサービス」を展開

---

![functionの検索](2019-07-28-21-52-43.png)

---

![function app](2019-07-28-21-53-31.png)

---

![作成](2019-07-28-21-54-08.png)

---

![Function App 作成](2019-07-28-21-55-16.png)

---

![リソースに移動](2019-07-28-21-56-46.png)

---

![新規作成](2019-07-28-21-57-55.png)

---

![新しい関数](2019-07-28-21-58-42.png)

---

![HTTP Trigger](2019-07-28-21-59-23.png)

---

![作成](2019-07-28-22-00-09.png)

---

```

#r "Newtonsoft.Json"

using System.Net;
using System.Collections;
using Newtonsoft.Json;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
    string url = "https://outlook.office.com/webhook/9260568e-df73-4b63-9668-6349b3ce05ad@88cb30cf-9982-4b0b-950f-243b551e44ba/IncomingWebhook/6aed418937dc4120b583b23391010f2b/4ee8d085-8181-4c77-9626-44218cc2b583";

    string message = req.GetQueryNameValuePairs()
        .FirstOrDefault(q => string.Compare(q.Key, "message", true) == 0)
        .Value;

    using (HttpClient httpClient = new HttpClient())
    {
    var param = new Hashtable();
    param["Text"] = message;
    var json = JsonConvert.SerializeObject(param);

    var content = new StringContent(json);
    HttpResponseMessage response = await httpClient.PostAsync(url, content);
    }

    return message == null
        ? req.CreateResponse(HttpStatusCode.BadRequest, "Please pass a name on the query string or in the request body")
        : req.CreateResponse(HttpStatusCode.OK, "message sent. " + message);
}

```

---

- コード
  - http://bit.ly/32Y1mAS

---

![関数の作成と実行](2019-07-28-22-10-19.png)

---

![関数のURL](2019-07-28-22-11-23.png)

---

![コピー](2019-07-28-22-12-01.png)

---

![Message sent](2019-07-28-22-14-09.png)

---

![Message from Azure Stack](2019-07-28-22-15-03.png)

---

## アジェンダ - 振り返り

1. サブスクリプション準備
2. 仮想マシン展開 - ブラウザ
3. 展開後のWindows Server 2016の確認
4. 仮想マシン展開 - PowerShell
5. テンプレート展開
6. コンテナ基盤展開
7. Webサイト作成
8. Teamsにメッセージを送信するWebサービス作成

---

- 以上でハンズオンは終了です。
- お疲れ様でした！
