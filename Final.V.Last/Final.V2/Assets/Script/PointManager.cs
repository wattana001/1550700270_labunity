using UnityEngine;
using System.Collections;

public class PointManager : MonoBehaviour
{
    public GameObject objPointWall;
    public GameObject objBlockWall;
    
    public bool xLine = false;
    public bool yLine = true;
    public float Ymin = 180F;
    public float Ymax = 200F;
    public float Xmin = 250F;
    public float Xmax = 320F;
    
    private float xRandom = 0F;
    private float yRandom = 0F;
    
    private float yBlockWall = 0F;
    
    private static PointManager instance = null;
    public static PointManager Instance
    {
        get{return instance;}
    }
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    
	void Start () {
	
	}
    public void setBlockWall()
    {
        objBlockWall.transform.position = new Vector3( objPointWall.transform.position.x, objPointWall.transform.position.y, objBlockWall.transform.position.z);
    }
	public void randomPoint()
    {
        if(xLine)
        {
            xRandom = Random.Range(Xmin, Xmax);
        }
        else
        {
            xRandom = objPointWall.transform.position.x;
        }
        
        if(yLine)
        {
            yRandom = Random.Range(Ymin, Ymax);
        }
        else
        {
            yRandom = objPointWall.transform.position.y;
        }
        
        
        Vector3 position = new Vector3(xRandom, yRandom, objPointWall.transform.position.z);
        Instantiate(objPointWall, position, Quaternion.identity);
        
        if(yRandom < 193f)
        {
            yBlockWall = 193f;
        }
        else
        {
            yBlockWall = yRandom;            
        }
        objBlockWall.transform.position = new Vector3( xRandom, yBlockWall, 32.4f);
        
    }
	void Update ()
    {
	       
	}
}
