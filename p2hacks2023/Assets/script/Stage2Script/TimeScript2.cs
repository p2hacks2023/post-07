using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript2 : MonoBehaviour
{
    //　トータル制限時間
	public static float totalTime2;
	//　制限時間（分）
	private int minute;
	//　制限時間（秒）
	private float seconds;
	//　前回Update時の秒数
	private float oldSeconds;
	private Text timerText;

	// 時間切れ時に表示するパネル
	[SerializeField]
	private GameObject GameOverPanel;

    //　追加時間（秒）
	[SerializeField]
	private float addseconds;
    
    // Start is called before the first frame update
    void Start()
    {
        totalTime2 = TimeScript.totalTime + addseconds;
		oldSeconds = 0f;
		timerText = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //　制限時間が0秒以下なら何もしない
		if (totalTime2 <= 0f) {
			return;
		}
		//　一旦トータルの制限時間を計測；
		//totalTime = minute * 60 + seconds;
		totalTime2 -= Time.deltaTime;
 
		//　再設定
		minute = (int) totalTime2 / 60;
		seconds = totalTime2 - minute * 60;
        
 
		//　タイマー表示用UIテキストに時間を表示する
		if((int)seconds != (int)oldSeconds) {
			timerText.text = minute.ToString("00") + ":" + ((int) seconds).ToString("00");
		}
		oldSeconds = seconds;
		//　制限時間以下になったらゲームオーバーパネルを表示する
		if(totalTime2 <= 0f) {
			GameOverPanel.SetActive(true);
		}

    }
}
