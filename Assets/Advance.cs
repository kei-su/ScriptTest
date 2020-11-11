using UnityEngine;
using System.Collections;

public class Boss
{
	private int mp = 53;
	
	public void Magic(int lossmp)
	{
		this.mp -= lossmp;
		Debug.Log("魔法攻撃した。残りMPは" + mp);
	}

}

public class Advance : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
	Boss lastboss = new Boss();

	//所定回数分繰り返す
	for(int i = 0; i <= 10; i++)
	{
	   	//所定回数より大きい場合表示←ここがすごくダサくなりました。mpで決めたい。
		if(i > 9)
		{
			Debug.Log("MPが足りないため魔法が使えない。");
		}
		
		//その他条件を表示
		else
		{	
			lastboss.Magic(5);
			
		}
    	}
     }

    // Update is called once per frame
    void Update()
    {
        
    }
}
