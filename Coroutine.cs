using System.Collections;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(OnTimerStart());
    }

    // Update is called once per frame
    private void Update()
    {
        Debug.Log("dd");
    }
    private IEnumerator OnTimerStart()
    {
        yield return null;

        while (true)
        {
            yield return new WaitForSeconds(1);
            Debug.Log("¤·¤·");
        }
    }
}
