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
                Instantiate(block, new Vector3(j + block.transform.position.x, i + block.transform.position.y, 0), Quaternion.identity);
            }
        }
    }
}