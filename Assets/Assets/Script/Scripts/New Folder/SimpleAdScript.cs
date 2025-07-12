using UnityEngine;
using UnityEngine.Advertisements;
using System.Collections;

public class SimpleAdScript : MonoBehaviour
{
	void Start ()
	{
		Advertisement.Initialize ("58056");

        //StartCoroutine (ShowAdWhenReady ()); //---->RF
    }

    public void show(){
		//Advertisement.Show ();
	}
    //IEnumerator ShowAdWhenReady()  //---->RF
    //{
    //	//while (!Advertisement.IsReady ())
    //	//	yield return null;

    //	//Advertisement.Show ();
    //}
}