using UnityEngine;

public class Grid : MonoBehaviour {

    public Transform block;

	// Use this for initialization
	void Start () {
        DrawGrid();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void DrawGrid ()
    {
        for(int i = 0; i < 10; i++)
        {
            for(int j = 0; j < 10; j++)
            {
                //Instantiate(block, new Vector3(j + block.transform.position.x, i + block.transform.position.y, 0), Quaternion.identity);
                //transform.localScale = new Vector3(0.9F, 0.9F, 0);
                //Transform clone;
                Instantiate(block, new Vector3(j + block.transform.position.x, i + block.transform.position.y, 0), Quaternion.identity);
                //transform.localScale = new Vector3(0.5F, 0.5F, 0);
                //clone = Instantiate(block, new Vector3(j, i, 0), Quaternion.identity) as Transform;
                //clone.transform.localScale -= new Vector3(0.5F, 0.5F, 0);
                //clone.name = "Board Space ( x = " + x.ToString() + " , y =" + y.ToString() + " )";
            }
        }
    }
}