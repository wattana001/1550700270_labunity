using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Scoreupdate : MonoBehaviour
{
	public Text ScoreText; 
	public int Score;

    public void ScoreAdd()
	{
		Score += 1; 
		ScoreText.text = "Score: " + Score.ToString();	
	}
    void Update()
    {

    }
}
