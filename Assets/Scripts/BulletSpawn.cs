using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;

    public void FireBulletOnTouch(Vector3 position, Quaternion rotation, int bulletType)
    {
        if(Input.touchCount > 0){
            SpawnBullet(position, rotation, bulletType);
        }
    }

    private void SpawnBullet(Vector3 position, Quaternion rotation, int bulletType)
    {
        if(bulletType == 1)
        {
            Instantiate(bulletPrefab, position, rotation);
        }
        else if(bulletType == 2)
        {
            Instantiate(bulletPrefab, position, rotation);
            StartCoroutine(DelayBetweenBullets(position, rotation, 0.1f));
            StartCoroutine(DelayBetweenBullets(position, rotation, 0.2f));
        }
    }

    IEnumerator DelayBetweenBullets(Vector3 position, Quaternion rotation, float delay)
    {
        yield return new WaitForSeconds(delay);
        Instantiate(bulletPrefab, position, rotation);
    }
}
