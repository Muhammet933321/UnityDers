using UnityEngine;

public class ColliderRandomCreater : MonoBehaviour
{
    [SerializeField] GameObject goldPref;
    [SerializeField] Collider coll;
    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
             CreateOneGold();
        }
       
    }

    private void CreateOneGold()
    {
        Instantiate(goldPref, RandomPointInColldier(), Quaternion.identity);
    }

    private Vector3 RandomPointInColldier()
    {
        Bounds bound = coll.bounds;
        float minX = bound.min.x;
        float minY = bound.min.y;
        float minZ = bound.min.z;
        float maxX = bound.max.x;
        float maxY = bound.max.y;
        float maxZ = bound.max.z;

        float x = Random.Range(minX, maxX);
        float y = Random.Range(minY, maxY);
        float z = Random.Range(minZ, maxZ);

        return new Vector3(x, y, z);
    }
}
