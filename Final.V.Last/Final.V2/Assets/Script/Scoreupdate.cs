using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Scoreupdate : MonoBehaviour
{
	public Text Scoretext; 
	public int Score;

    public void ScoreAdd()
	{
		Score += 1; 
		Scoretext.text = "Score: " + Score.ToString();	
	}
    void Update()
    {

    }
}
