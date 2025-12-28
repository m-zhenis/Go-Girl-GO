using System.Collections;
using UnityEngine;

public class SegmentGenerator : MonoBehaviour
{
    public GameObject[] segment;

    [SerializeField] public int zPosition = 50;
    [SerializeField] public bool creatingSegment = false;
    [SerializeField] public int segmentNumber;
    
    void Update()
    {
        if (creatingSegment == false)
        {
            creatingSegment = true;
            StartCoroutine(SegmentGenerate());
        }
    }

    IEnumerator SegmentGenerate()
    {
        segmentNumber = Random.Range(0, 3);
        Instantiate(segment[segmentNumber], new Vector3(0, 0, zPosition), Quaternion.identity);
        zPosition += 50;
        yield return new WaitForSeconds(3);
        creatingSegment = false;
    }
}
