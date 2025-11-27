using UnityEngine;

public class PosRandomGoldCreater : MonoBehaviour
{
    [SerializeField] GameObject goldPref;
    [SerializeField] Vector3 centerPos;
    [SerializeField] Vector3 areaScale;
    void Start()
    {
        for (int i = 0; i< 10; i++)
        {
            CreateOneGold();
        }
    }
    private void CreateOneGold()
    {
        Instantiate(goldPref, CreateRandomPos(), Quaternion.identity);
    }
    private Vector3 CreateRandomPos()
    {
        float x = Random.Range(centerPos.x - areaScale.x, centerPos.x + areaScale.x);
        float y = Random.Range(centerPos.y - areaScale.y, centerPos.y + areaScale.y);
        float z = Random.Range(centerPos.z - areaScale.z, centerPos.z + areaScale.z);

        return new Vector3(x, y, z);
    }
}
