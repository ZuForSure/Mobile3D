using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDespawn : ZuMonoBehaviour
{
    private void OnCollisionExit(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Player")) return;

        StartCoroutine(this.DepspawnDelay());
    }

    protected virtual IEnumerator DepspawnDelay()
    {
        yield return new WaitForSeconds(1);
        Destroy(transform.parent.gameObject);
    }
}
