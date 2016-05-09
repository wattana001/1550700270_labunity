using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Scoreupdate : MonoBehaviour
{
	public Text Scoretxt; 
	public int Score;
    void Start()
    {

    }
    void Update()
    {

    }
    public void ScoreAdd()
	{
		Score += 1; 
		Scoretxt.text = "Score: " + Score.ToString();	
	}
}
