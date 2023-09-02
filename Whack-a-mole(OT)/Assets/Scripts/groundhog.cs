using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundhog : MonoBehaviour
{
    // Groundhog positions 
    private Vector2 startPosition = new Vector2(0f, -7.88f);
    private Vector2 endPosition = Vector2.zero;
    // Groundhog duration
    private float showDuration = 0.5f;
    private float duration = 1f;

    private IEnumerator ShowHide(Vector2 start, Vector2 end)
    {
        // groundhog under the hole
        transform.localPosition = start;

        // groundhog appearing
        float elapsed = 0f;
        while (elapsed < showDuration)
        {
            transform.localPosition = Vector2.Lerp(start, end, elapsed/showDuration);
            elapsed += Time.deltaTime;
            yield return null;
        }

        // groundhog above the hole
        transform.localPosition = end;

        // groundhog still duration
        yield return new WaitForSeconds(duration);

        // groundhog hiding
        elapsed = 0f;
        while (elapsed < showDuration)
        {
            transform.localPosition = Vector2.Lerp(end, start, elapsed/showDuration);
            elapsed += Time.deltaTime;
            yield return null;
        }

        // groundhog back under the hole
        transform.localPosition = start;
    }
    private void Start() 
    {
        StartCoroutine(ShowHide(startPosition, endPosition));
    }
}
