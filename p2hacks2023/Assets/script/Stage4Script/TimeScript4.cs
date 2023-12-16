using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript4 : MonoBehaviour
{
    //　トータル制限時間
	public static float totalTime4;
	//　制限時間（分）
	private int minute;
	//　制限時間（秒）
	private float seconds;
	//　前回Update時の秒数
	private float oldSeconds;
	private Text timerText;

	public static bool isText = false; //テキストを表示しているかどうかのフラグ

	// 残り10秒で表示するパネル
	[SerializeField]
	private GameObject TimerLim10;

	// 残り30秒で表示するパネル
	[SerializeField]
	private GameObject TimerLim30;
	
	// 時間切れ時に表示するパネル
	[SerializeField]
	private GameObject GameOverPanel;

    //　追加時間（秒）
	[SerializeField]
	private float addseconds;
    // Start is called before the first frame update
    void Start()
    {
        totalTime4 = TimeScript3.totalTime3 + addseconds;
		minute = (int) totalTime4 / 60;
		seconds = totalTime4 - minute * 60;
		oldSeconds = 0f;
		timerText = GetComponentInChildren<Text>();
		timerText.text = minute.ToString("00") + ":" + ((int) seconds).ToString("00");
		TimerLim10.SetActive(false);
		TimerLim30.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //　制限時間が0秒以下なら何もしない
		if (totalTime4 <= 0f) {
			return;
		}

		//テキスト表示中でなければ
		if(isText == false)
		{
			//　一旦トータルの制限時間を計測；
			//totalTime = minute * 60 + seconds;
			totalTime4 -= Time.deltaTime;
 
			//　再設定
			minute = (int) totalTime4 / 60;
			seconds = totalTime4 - minute * 60;
        
 
			//　タイマー表示用UIテキストに時間を表示する
			if((int)seconds != (int)oldSeconds) {
				timerText.text = minute.ToString("00") + ":" + ((int) seconds).ToString("00");
			}
			oldSeconds = seconds;
		}

		//　制限時間が10秒以下になったら表示する
		if(totalTime4 <= 11f) {
			TimerLim10.SetActive(true);
			TimerLim30.SetActive(false);
		}

		//　制限時間が30秒以下になったら表示する
		if(totalTime4 <= 31f) {
			TimerLim30.SetActive(true);
		}


		
		//　制限時間以下になったらゲームオーバーパネルを表示する
		if(totalTime4 <= 0f) {
			GameOverPanel.SetActive(true);
			TimerLim10.SetActive(false);
		}
    }
}
