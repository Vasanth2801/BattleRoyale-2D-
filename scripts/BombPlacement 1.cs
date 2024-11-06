using UnityEngine;

public class BombPlacementP1 : MonoBehaviour
{
    public GameObject bombPrefab; 
    public KeyCode placeBombKey = KeyCode.Space; 

    void Update()
    {
        if (Input.GetKeyDown(placeBombKey))
        {
            PlaceBomb();
        }
    }

    void PlaceBomb()
    {
        
        Vector3 bombPosition = new Vector3(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y), 0);
        Instantiate(bombPrefab, bombPosition, Quaternion.identity);
    }
}
