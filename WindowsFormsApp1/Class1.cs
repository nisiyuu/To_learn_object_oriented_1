﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    class Class1
    {
        ///
        public Class1(){}
        public Class1(int num){　//自作コンストラクタ　コンストラクタは戻り値を持たない
            this.test = num;
        }
        /// <summary>
        /// 文字列を引数にとるコンストラクタ
        /// </summary>
        /// <param name="str">あいさつ</param>
        public Class1(string str)
        {
            this.str = str;
        }
        private string str = "おはよう";//組み込み　int型のインスタンス変数(フィールド）
        private int test = 1;//組み込み　int型のインスタンス変数
        public const int test2 = 2;
        public int showTest()　//組み込み　int型のインスタンスメソッド
        {
            return this.test;  //privateだと関数をけいゆしてでないと参照できない
        }
        public int showTest(int num)
        {
            return this.showTest() + num;
        }

    }
}


//publicとprivate publicであればインスタンスから参照できる＆privateだと同じクラス内でしか参照できない
//Form1.csからprivateのtestを呼び出すには、例えばpublicのshowTest（メソッド）で囲んであげることで可能

//同じコンストラクタ名でいくつか種類がつくれる シグネチャが異なる
//引数なしのインスタンスと・・・A
//int型引数をもつインスタンスなど・・・B

//BはAの機能+int型引数を活用した機能
//これがオーバーロード。複数のシグニチャをもつことができる。

//クラス型なら全てobject型これを継承してstring型になったりする。※参照型にはインターフェイス型もある
//https://docs.microsoft.com/ja-jp/dotnet/api/system.string?view=netframework-4.8#methods
//https://docs.microsoft.com/ja-jp/dotnet/api/system.object?view=netframework-4.8
//くらすが継承されていることがわかる
//例えばStringクラスGetTypeは(継承元 Object)と書かれている。


