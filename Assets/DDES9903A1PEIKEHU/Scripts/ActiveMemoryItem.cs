using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveMemoryItem : MonoBehaviour
{
    public float delay = 24f;

    public void ActiveItems()
    {
        // Assuming the button click calls this method
        StartCoroutine(ActivateComponentsAfterDelayCoroutine());
    }

    IEnumerator ActivateComponentsAfterDelayCoroutine()
    {
        yield return new WaitForSeconds(delay);

        GameObject[] memoryItems = GameObject.FindGameObjectsWithTag("memoryItem");
        foreach (GameObject item in memoryItems)
        {
            Movable movable = item.GetComponent<Movable>();
            GradientColor gradientColor = item.GetComponent<GradientColor>();

            if (movable != null)
            {
                movable.enabled = true;
            }

            if (gradientColor != null)
            {
                gradientColor.enabled = true;
            }
        }
    }
}
